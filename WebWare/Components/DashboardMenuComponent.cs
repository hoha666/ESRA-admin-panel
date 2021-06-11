using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWare.Models.Dashboard;
using Microsoft.EntityFrameworkCore;
using WebWare;
using WebWare.Data;
using WebWare.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace WebWare.Components
{
    [ViewComponent(Name = "DashboardMenu")]
    public class DashboardMenuComponent : ViewComponent
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly WebWareContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        DashboardMenuViewModel myMenu;

        public DashboardMenuComponent(WebWareContext context,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _contextAccessor = contextAccessor;
        }
        public IViewComponentResult Invoke()
        {
            var userid = _userManager.GetUserId(this.HttpContext.User);//_userManager.GetUserAsync(User);
            if (userid == null)
            {
                var a = new RedirectToActionResult("login", "account", "");
                a.ExecuteResultAsync(new ActionContext(this.HttpContext, new Microsoft.AspNetCore.Routing.RouteData(), new Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor()));
            }
            var userMenus = from usermenu in _context.UserMenus
                            join menu in _context.Menus on usermenu.MenuId equals menu.Id
                            where usermenu.UserId == userid
                            select menu;
            myMenu = new DashboardMenuViewModel();
            foreach (var menu in userMenus)
            {
                var t = _contextAccessor.HttpContext.Request.Host.Value.ToString();
                if (menu.Url.Contains("http://") || menu.Url.Contains("https://"))
                {
                    if (_contextAccessor.HttpContext.Request.IsHttps)
                        menu.Url = menu.Url;
                    else
                        menu.Url = menu.Url;
                }
                else
                {
                    if (_contextAccessor.HttpContext.Request.IsHttps)
                        menu.Url = "https://" + t + "/" + menu.Url;
                    else
                        menu.Url = "http://" + t + "/" + menu.Url;
                }
                myMenu.addMenu(menu);
            }
            return View(myMenu);
        }
    }
}
