using Microsoft.AspNetCore.Mvc;
using WebWare.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebWare.Controllers
{
    public class DashboardController : Controller
    {
        private WebWareContext _context;
        public IActionResult Index()
        {
            return View();
        }
    }
}
