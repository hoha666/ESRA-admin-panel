using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FluentFTP;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebWare.Models;
using WebWare.Models.MobileIntroduction;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebWare.Controllers
{
    [Authorize(Policy = "GameIntroduction")]
    public class MobileIntroductionController : Controller
    {
        private readonly ipdbContext _PortalContext;
        public IConfiguration Configuration { get; }
        public MobileIntroductionController(ipdbContext context, IConfiguration configuration)
        {
            _PortalContext = context;
            Configuration = configuration;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            TotalMobileIntroduction g = new TotalMobileIntroduction(_PortalContext, true);
            return View(g);
        }
        public IActionResult ShowMobileIntroductions()
        {
            TotalMobileIntroduction g = new TotalMobileIntroduction(_PortalContext, false);
            return View(g);
        }
        public IActionResult EditIntroduction(string gameId = "62000", string res = "")
        {
            MobileIntroduction MI = new MobileIntroduction();
            MobileIntroductionMaker(_PortalContext, gameId, MI);
            MI.result = res;/// azinja bayad edame bedam
            FtpClient myclient = new FtpClient(Configuration.GetConnectionString("FTPSERVER"));//"fOvz696$"
            myclient.Credentials = new System.Net.NetworkCredential(Configuration.GetConnectionString("FTPUSER"), Configuration.GetConnectionString("FTPPASS"));
            myclient.Connect();
            try
            {
                myclient.DownloadFile(@"wwwroot/FtpFilesMob/" + MI.gameIdReal + MI.CoverPicName, "/picture/game/icons/" + MI.gameIdReal + "/" + MI.CoverPicName);
            }
            catch (Exception w1) { }

            return View(MI);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditIntroduction([FromForm]MobileIntroduction model, string returnUrl = null)
        {
            var temp = new MobileIntroduction();
            MobileIntroductionMaker(_PortalContext, model.gameIdReal.ToString(), temp);
            //temp = gameIntroduction;
            ViewData["ReturnUrl"] = returnUrl;
            if (model.cover != null && model.cover.Length > 0)
            {
                var filepath = "wwwroot/ftpwerMob/" + model.cover.FileName;
                using (var stream = new FileStream(filepath, FileMode.Create))
                {
                    await model.cover.CopyToAsync(stream);
                }
                FtpClient myclient = new FtpClient(Configuration.GetConnectionString("FTPSERVER"));//"fOvz696$"
                myclient.Credentials = new System.Net.NetworkCredential(Configuration.GetConnectionString("FTPUSER"), Configuration.GetConnectionString("FTPPASS"));
                myclient.Connect();
                try
                {
                    if (temp.CoverPicName == null || temp.CoverPicName == "")
                    {
                        temp.CoverPicName = model.cover.FileName;
                        setPicInDb(_PortalContext, temp.CoverPicName, 7, temp.gameVersionId);
                    }
                    myclient.UploadFile(filepath, "/picture/game/icons/" + temp.gameIdReal + "/" + temp.CoverPicName, FtpExists.Overwrite, true, FtpVerify.None);
                }
                catch (Exception w1) { }
            }

            var VersionEdit = _PortalContext.TblVersion.SingleOrDefault(b => b.Id == temp.gameVersionId);
            if (VersionEdit != null)
            {
                VersionEdit.IntroductionMin = model.IntroductionMin;
                if (model.isInIntroduction)
                {
                    var GameEdit = _PortalContext.TblGame.SingleOrDefault(b => b.Id == model.gameIdReal);
                    GameEdit.IsInIntroduction = true;
                    GameEdit.ShowInEsraWebsite = true;
                }
                else
                {
                    var GameEdit = _PortalContext.TblGame.SingleOrDefault(b => b.Id == model.gameIdReal);
                    GameEdit.IsInIntroduction = false;
                    //GameEdit.ShowInEsraWebsite = false;
                }
                _PortalContext.SaveChanges();
            }

            var u = Url.Action("EditIntroduction", "MobileIntroduction", new { gameId = temp.gameIdReal, res = "Operation successfully ended" });
            //If we got this far, something failed, redisplay form
            return Redirect(u);
        }
        public void setPicInDb(ipdbContext context, string fileName, int picType, int idversion)
        {
            var a = new TblVersionScreenshot();
            a.IdVersion = idversion;
            a.IdScreenshotType = picType;//3 for cover and 2 for other pics
            var file = new TblFile();
            file.Name = fileName;
            file.UploadDateTime = DateTime.Now;
            context.TblFile.Add(file);
            context.SaveChanges();
            a.IdFile = file.Id;
            context.TblVersionScreenshot.Add(a);
            context.SaveChanges();


        }
        public void MobileIntroductionMaker(ipdbContext context, string gameId, MobileIntroduction mmv)
        {
            var game = (from a in context.TblGame where (a.Id.ToString() == gameId) select a).First<TblGame>();
            mmv.gameTitle = game.Name;
            mmv.gameIdReal = game.Id;
            if (game.IsInIntroduction is true)
                mmv.isInIntroduction = true;
            else
                mmv.isInIntroduction = false;
            var version = (from a in context.TblVersion where a.IdGame.ToString() == gameId select a).OrderByDescending(x => x.Id).First<TblVersion>();
            mmv.gameVersionId = version.Id;
            mmv.year = version.ReleaseDateTime.Value.Year;
            mmv.IntroductionMin = version.IntroductionMin;
            var esra = (from a in context.TblVersionEsra where a.IdVersion == version.Id select a).First<TblVersionEsra>();
            var age = (from a in context.TblEsra where a.Id == esra.IdEsra select a).First<TblEsra>();
            mmv.ageRating = age.Age;
            var screenshots = (from a in context.TblVersionScreenshot where a.IdVersion == version.Id select a).OrderByDescending(a => a.IdFile).ToList<TblVersionScreenshot>();
            var mfile = new TblFile();
            if (screenshots != null && screenshots.Count > 0)
            {
                mfile = (from b in context.TblFile where b.Id == screenshots[0].IdFile select b).OrderByDescending(x => x.Id).First<TblFile>();
                mmv.CoverPicName = mfile.Name;
            }
        }
    }
}
