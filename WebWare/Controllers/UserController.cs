using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebWare.Models.User;
using WebWare.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebWare.Controllers
{

    public class UserController : Controller
    {
        private readonly WebWareContext _DbContext;
        [BindProperty]
        public EditedUser Editie { get; set; }

        // GET: /<controller>/
        public UserController(WebWareContext DbContext)
        {
            _DbContext = DbContext;
            Editie = new EditedUser();

        }
        public IActionResult Index()
        {
            UserViewModel systemUsers = new UserViewModel();
            systemUsers.aspNetUsers = (from a in _DbContext.AspNetUsers select a).ToList();
            return View(systemUsers);
        }

        public IActionResult EditUser(string username, string res = "")
        {
            AspNetUsers aspNetUsers = (from a in _DbContext.AspNetUsers where a.UserName == username select a).FirstOrDefault<AspNetUsers>();
            //EditedUser edited = new EditedUser();
            //edited.PhoneNumber = aspNetUsers.Id;
            //edited.Username = aspNetUsers.UserName;
            //edited.PhoneNumber = aspNetUsers.PhoneNumber;

            Editie.Id = aspNetUsers.Id;
            Editie.Username = aspNetUsers.UserName;
            Editie.PhoneNumber = aspNetUsers.PhoneNumber;
            Editie.res = res;
            ViewData["UserName"] = Editie.Username;
            if (aspNetUsers != null)
                return View(Editie);
            else
                return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser()
        {
            var USER = _DbContext.AspNetUsers.SingleOrDefault(b => b.Id == Editie.Id);
            USER.PhoneNumber = Editie.PhoneNumber;
            _DbContext.SaveChanges();

            var u = Url.Action("edituser", "user", new { username = Editie.Username, res = "ok" });

            return Redirect(u);
        }
    }
}
