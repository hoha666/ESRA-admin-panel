using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebWare.Data;
using WebWare.Models.GameIntroductionViewModels;
using WebWare.Models;
using FluentFTP;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebWare.Controllers
{
    [Authorize(Policy = "GameIntroduction")]
    public class GameIntroductionController : Controller
    {
        private readonly ipdbContext _PortalContext;
        public IConfiguration Configuration { get; }

        [BindProperty]
        public IntroductionViewModel gameIntroduction { get; set; }

        public GameIntroductionController(ipdbContext PortalContext, IConfiguration configuration)
        {
            Configuration = configuration;
            _PortalContext = PortalContext;
        }

        public IActionResult Index()
        {
            var Introductions = new GameIntroductionViewModel(_PortalContext, 0);
            return View(Introductions);
        }

        public IActionResult AddNewIntroduction()
        {
            //var sd = _PortalContext.TblGame.OrderByDescending(q => q.Id);
            //var te = (from b in _PortalContext.TblGame where b.Id == 45 select b).OrderByDescending(q => q.Id).ToList<TblGame>();

            //var Introductions = new GameIntroductionViewModel(_PortalContext, 1);
            return View(/*Introductions*/);
        }

        public IActionResult EditIntroduction(string gameId = "60200", string res = "")
        {
            gameIntroduction = new IntroductionViewModel();
            IntroductionViewModelMaker(_PortalContext, gameId, gameIntroduction);
            gameIntroduction.result = res;
            FtpClient myclient = new FtpClient(Configuration.GetConnectionString("FTPSERVER"));//"fOvz696$"
            myclient.Credentials = new System.Net.NetworkCredential(Configuration.GetConnectionString("FTPUSER"), Configuration.GetConnectionString("FTPPASS"));
            myclient.Connect();
            try
            {
                myclient.DownloadFile(@"wwwroot/FtpFiles/" + gameIntroduction.gameIdReal + gameIntroduction.CoverPicName, "/picture/game/gamePic/" + gameIntroduction.gameIdReal + "/" + gameIntroduction.CoverPicName);
            }
            catch (Exception w1) { }
            try
            {
                myclient.DownloadFile(@"wwwroot/FtpFiles/" + gameIntroduction.gameIdReal + gameIntroduction.PicName1, "/picture/game/gamePic/" + gameIntroduction.gameIdReal + "/" + gameIntroduction.PicName1);
            }
            catch (Exception w2) { }
            try
            {
                myclient.DownloadFile(@"wwwroot/FtpFiles/" + gameIntroduction.gameIdReal + gameIntroduction.PicName2, "/picture/game/gamePic/" + gameIntroduction.gameIdReal + "/" + gameIntroduction.PicName2);
            }
            catch (Exception w3) { }
            try
            {
                myclient.DownloadFile(@"wwwroot/FtpFiles/" + gameIntroduction.gameIdReal + gameIntroduction.PicName3, "/picture/game/gamePic/" + gameIntroduction.gameIdReal + "/" + gameIntroduction.PicName3);
            }
            catch (Exception w4) { }
            myclient.Disconnect();
            return View(gameIntroduction);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditIntroduction([FromForm]IntroductionViewModel model, string returnUrl = null)
        {
            var temp = new IntroductionViewModel();
            IntroductionViewModelMaker(_PortalContext, model.gameIdReal, temp);
            temp = gameIntroduction;
            ViewData["ReturnUrl"] = returnUrl;
            if (model.cover != null && model.cover.Length > 0)
            {
                var filepath = "wwwroot/ftpwer/" + model.cover.FileName;
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
                        setPicInDb(_PortalContext, temp.CoverPicName, 3, temp.gameVersionId);
                    }
                    else
                    {
                        try
                        {
                            myclient.DeleteFile("/picture/game/gamePic/" + temp.gameIdReal + "/" + temp.CoverPicName);
                        }
                        catch (Exception ex) { }
                        temp.CoverPicName = model.cover.FileName;
                        updatePicInDb(_PortalContext, temp.coverId, temp.CoverPicName);
                    }
                    myclient.UploadFile(filepath, "/picture/game/gamePic/" + temp.gameIdReal + "/" + temp.CoverPicName, FtpExists.Overwrite, true, FtpVerify.None);
                    myclient.DeleteFile(filepath);
                }
                catch (Exception w1) { var t = w1.Message.ToString(); var ter = 3; }
            }
            if (model.pic1 != null && model.pic1.Length > 0)
            {
                var filepath = "wwwroot/ftpwer/" + model.pic1.FileName;
                using (var stream = new FileStream(filepath, FileMode.Create))
                {
                    await model.pic1.CopyToAsync(stream);
                }
                FtpClient myclient = new FtpClient(Configuration.GetConnectionString("FTPSERVER"));//"fOvz696$"
                myclient.Credentials = new System.Net.NetworkCredential(Configuration.GetConnectionString("FTPUSER"), Configuration.GetConnectionString("FTPPASS"));
                myclient.Connect();
                try
                {
                    if (temp.PicName1 == null || temp.PicName1 == "")
                    {
                        temp.PicName1 = model.pic1.FileName;
                        setPicInDb(_PortalContext, temp.PicName1, 2, temp.gameVersionId);
                    }
                    else
                    {
                        try
                        {
                            myclient.DeleteFile("/picture/game/gamePic/" + temp.gameIdReal + "/" + temp.PicName1);
                        }
                        catch (Exception ex) { }
                        temp.PicName1 = model.pic1.FileName;
                        updatePicInDb(_PortalContext, temp.P1Id, temp.PicName1);
                    }
                    myclient.UploadFile(filepath, "/picture/game/gamePic/" + temp.gameIdReal + "/" + temp.PicName1, FtpExists.Overwrite, true, FtpVerify.None);
                    myclient.DeleteFile(filepath);
                }
                catch (Exception w1) { var t = w1.Message.ToString(); var ter = 3; }
            }
            if (model.pic2 != null && model.pic2.Length > 0)
            {
                var filepath = "wwwroot/ftpwer/" + model.pic2.FileName;
                using (var stream = new FileStream(filepath, FileMode.Create))
                {
                    await model.pic2.CopyToAsync(stream);
                }
                FtpClient myclient = new FtpClient(Configuration.GetConnectionString("FTPSERVER"));//"fOvz696$"
                myclient.Credentials = new System.Net.NetworkCredential(Configuration.GetConnectionString("FTPUSER"), Configuration.GetConnectionString("FTPPASS"));
                myclient.Connect();
                try
                {
                    if (temp.PicName2 == null || temp.PicName2 == "")
                    {
                        temp.PicName2 = model.pic2.FileName;
                        setPicInDb(_PortalContext, temp.PicName2, 2, temp.gameVersionId);
                    }
                    else
                    {
                        try
                        {
                            myclient.DeleteFile("/picture/game/gamePic/" + temp.gameIdReal + "/" + temp.PicName2);
                        }
                        catch (Exception ex) { }
                        temp.PicName2 = model.pic2.FileName;
                        updatePicInDb(_PortalContext, temp.P2Id, temp.PicName2);
                    }
                    myclient.UploadFile(filepath, "/picture/game/gamePic/" + temp.gameIdReal + "/" + temp.PicName2, FtpExists.Overwrite, true, FtpVerify.None);
                    myclient.DeleteFile(filepath);
                }
                catch (Exception w1) { }
            }
            if (model.pic3 != null && model.pic3.Length > 0)
            {
                var filepath = "wwwroot/ftpwer/" + model.pic3.FileName;
                using (var stream = new FileStream(filepath, FileMode.Create))
                {
                    await model.pic3.CopyToAsync(stream);
                }
                FtpClient myclient = new FtpClient(Configuration.GetConnectionString("FTPSERVER"));//"fOvz696$"
                myclient.Credentials = new System.Net.NetworkCredential(Configuration.GetConnectionString("FTPUSER"), Configuration.GetConnectionString("FTPPASS"));
                myclient.Connect();
                try
                {
                    if (temp.PicName3 == null || temp.PicName3 == "")
                    {
                        temp.PicName3 = model.pic3.FileName;
                        setPicInDb(_PortalContext, temp.PicName3, 2, temp.gameVersionId);
                    }
                    else
                    {
                        try
                        {
                            myclient.DeleteFile("/picture/game/gamePic/" + temp.gameIdReal + "/" + temp.PicName3);
                        }
                        catch (Exception ex) { }
                        temp.PicName3 = model.pic3.FileName;
                        updatePicInDb(_PortalContext, temp.P3Id, temp.PicName3);
                    }
                    myclient.UploadFile(filepath, "/picture/game/gamePic/" + temp.gameIdReal + "/" + temp.PicName3, FtpExists.Overwrite, true, FtpVerify.None);
                    myclient.DeleteFile(filepath);
                }
                catch (Exception w1)
                {
                    var t = w1.Message.ToString();
                }
            }
            var VersionEdit = _PortalContext.TblVersion.SingleOrDefault(b => b.Id == temp.gameVersionId);
            if (VersionEdit != null)
            {
                var versions = (from b in _PortalContext.TblVersion where b.IdGame == VersionEdit.IdGame && b.IdPlatform != 9 && b.IdPlatform != 8 select b);
                foreach (var mver in versions)
                {
                    var tuberclone = _PortalContext.TblVersion.SingleOrDefault(b => b.Id == mver.Id);
                    tuberclone.IntroductionMin = model.IntroductionMin;
                    tuberclone.GamePlay = model.gameplay;
                    tuberclone.ParentRecommendation = model.parentRecommendation;
                    tuberclone.AparatLink = model.VersionAparatLink;
                    //pictograms
                    var oldpictos = (from y in _PortalContext.TblVersionPictogram where y.IdVersion == tuberclone.Id select y).ToList<TblVersionPictogram>();
                    _PortalContext.TblVersionPictogram.RemoveRange(oldpictos);
                    _PortalContext.SaveChanges();
                    TblVersionPictogram p1 = new TblVersionPictogram();
                    p1.IdPictogram = 1;
                    p1.IdVersion = tuberclone.Id;
                    p1.IdRate = model.picto1;
                    _PortalContext.TblVersionPictogram.Add(p1);
                    TblVersionPictogram p2 = new TblVersionPictogram();
                    p2.IdPictogram = 2;
                    p2.IdVersion = tuberclone.Id;
                    p2.IdRate = model.picto2;
                    _PortalContext.TblVersionPictogram.Add(p2);
                    TblVersionPictogram p3 = new TblVersionPictogram();
                    p3.IdPictogram = 3;
                    p3.IdVersion = tuberclone.Id;
                    p3.IdRate = model.picto3;
                    _PortalContext.TblVersionPictogram.Add(p3);
                    TblVersionPictogram p4 = new TblVersionPictogram();
                    p4.IdPictogram = 4;
                    p4.IdVersion = tuberclone.Id;
                    p4.IdRate = model.picto4;
                    _PortalContext.TblVersionPictogram.Add(p4);
                    TblVersionPictogram p5 = new TblVersionPictogram();
                    p5.IdPictogram = 5;
                    p5.IdVersion = tuberclone.Id;
                    p5.IdRate = model.picto5;
                    _PortalContext.TblVersionPictogram.Add(p5);
                    TblVersionPictogram p6 = new TblVersionPictogram();
                    p6.IdPictogram = 6;
                    p6.IdVersion = tuberclone.Id;
                    p6.IdRate = model.picto6;
                    _PortalContext.TblVersionPictogram.Add(p6);

                    _PortalContext.SaveChanges();
                }
                VersionEdit.IntroductionMin = model.IntroductionMin;
                VersionEdit.GamePlay = model.gameplay;
                VersionEdit.ParentRecommendation = model.parentRecommendation;
                VersionEdit.AparatLink = model.VersionAparatLink;
                if (model.isInIntroduction)
                {
                    var GameEdit = _PortalContext.TblGame.SingleOrDefault(b => b.Id == int.Parse(model.gameIdReal));
                    GameEdit.IsInIntroduction = true;
                    GameEdit.ShowInEsraWebsite = true;
                }
                else
                {
                    var GameEdit = _PortalContext.TblGame.SingleOrDefault(b => b.Id == int.Parse(model.gameIdReal));
                    GameEdit.IsInIntroduction = false;
                    //GameEdit.ShowInEsraWebsite = false;
                }

                _PortalContext.SaveChanges();
            }

            var u = Url.Action("EditIntroduction", "GameIntroduction", new { gameId = temp.gameIdReal, res = "Operation successfully ended" });
            //If we got this far, something failed, redisplay form
            return Redirect(u);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return RedirectToPage("./Index");
            }
            var t = gameIntroduction.IntroductionMin;

            return RedirectToPage("./Index");
        }

        public void IntroductionViewModelMaker(ipdbContext context, string gameId, IntroductionViewModel mmv)
        {
            var game = (from a in context.TblGame where a.Id.ToString() == gameId select a).First<TblGame>();
            mmv.gameTitle = game.Name;
            mmv.gameIdReal = game.Id.ToString();
            var version = (from a in context.TblVersion  join b in context.TblVersionEsra on a.Id equals b.IdVersion where (a.IdGame.ToString() == gameId)&&(b.IdEsraType==3)&&(b.IdEsraStatus==1) select a).OrderByDescending(x => x.Id).First<TblVersion>();
            mmv.gameVersionId = version.Id;
            mmv.IntroductionMin = version.IntroductionMin;
            mmv.gameplay = version.GamePlay;
            mmv.parentRecommendation = version.ParentRecommendation;
            mmv.VersionAparatLink = version.AparatLink;
            var pictos = (from a in context.TblVersionPictogram where a.IdVersion == version.Id select a).ToList<TblVersionPictogram>();
            foreach (var picto in pictos)
            {
                if (picto.IdPictogram == 1)
                    mmv.picto1 = picto.IdRate;
                else if (picto.IdPictogram == 2)
                    mmv.picto2 = picto.IdRate;
                else if (picto.IdPictogram == 3)
                    mmv.picto3 = picto.IdRate;
                else if (picto.IdPictogram == 4)
                    mmv.picto4 = picto.IdRate;
                else if (picto.IdPictogram == 5)
                    mmv.picto5 = picto.IdRate;
                else if (picto.IdPictogram == 6)
                    mmv.picto6 = picto.IdRate;
            }
            var screenshots = (from a in context.TblVersionScreenshot where a.IdVersion == version.Id select a).OrderByDescending(a => a.IdFile).ToList<TblVersionScreenshot>();
            mmv.CoverPicName = "";
            mmv.PicName1 = "";
            mmv.PicName2 = "";
            mmv.PicName3 = "";

            screenshots.OrderBy(x => x.IdFile);
            foreach (var a in screenshots)
            {
                if (a.IdScreenshotType == 3 && mmv.CoverPicName == "")
                {
                    var mfile = (from b in context.TblFile where b.Id == a.IdFile select b).First<TblFile>();
                    if (mfile != null)
                    {
                        mmv.CoverPicName = mfile.Name;
                        mmv.coverId = mfile.Id;
                    }
                }
                else if (a.IdScreenshotType == 2)
                {
                    if (mmv.PicName1 == "")
                    {
                        var mfile = (from b in context.TblFile where b.Id == a.IdFile select b).First<TblFile>();
                        if (mfile != null)
                        {
                            mmv.PicName1 = mfile.Name;
                            mmv.P1Id = mfile.Id;
                        }
                    }
                    else if (mmv.PicName2 == "")
                    {
                        var mfile = (from b in context.TblFile where b.Id == a.IdFile select b).First<TblFile>();
                        if (mfile != null)
                        {
                            mmv.PicName2 = mfile.Name;
                            mmv.P2Id = mfile.Id;
                        }
                    }
                    else if (mmv.PicName3 == "")
                    {
                        var mfile = (from b in context.TblFile where b.Id == a.IdFile select b).First<TblFile>();
                        if (mfile != null)
                        {
                            mmv.PicName3 = mfile.Name;
                            mmv.P3Id = mfile.Id;
                        }
                    }
                }
            }


            mmv.PictoList = new List<SelectListItem> {
             new SelectListItem { Value = "0", Text = "0" },
             new SelectListItem { Value = "1", Text = "1" },
             new SelectListItem { Value = "2", Text = "2" },
             new SelectListItem { Value = "3", Text = "3" },
             new SelectListItem { Value = "4", Text = "4" },
             new SelectListItem { Value = "5", Text = "5" }
            };

            gameIntroduction = mmv;

        }

        public void setPicInDb(ipdbContext context, string fileName, int picType, int idversion)
        {
            var a = new TblVersionScreenshot();
            a.IdVersion = idversion;
            a.IdScreenshotType = picType;//3 for cover and 2 for other pics
            var file = new TblFile();
            file.Name = fileName;
            file.Url = fileName;
            file.UploadDateTime = DateTime.Now;
            context.TblFile.Add(file);
            context.SaveChanges();
            a.IdFile = file.Id;
            context.TblVersionScreenshot.Add(a);
            context.SaveChanges();


        }
        public void updatePicInDb(ipdbContext context, int fileid, string fileName)
        {
            var gq = (from b in context.TblFile where b.Id == fileid select b).FirstOrDefault<TblFile>();
            gq.Name = fileName;
            gq.Url = fileName;
            context.SaveChanges();


        }


    }
}
