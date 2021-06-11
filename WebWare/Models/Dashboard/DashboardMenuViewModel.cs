using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWare.Models.Dashboard;
using System.ComponentModel.DataAnnotations;

namespace WebWare.Models.Dashboard
{
    public class DashboardMenuViewModel
    {
        [Display(Name = "Menus")]
        public List<Menus> Menus { get; set; }

        public DashboardMenuViewModel()
        {
            Menus = new List<Menus>();
        }
        public void addMenu(Menus menu)
        {
            Menus.Add(menu);
        }
    }
}
