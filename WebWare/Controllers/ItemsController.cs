using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebWare.Models;
using WebWare.Models.GameIntroductionViewModels;
using WebWare.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebWare.Controllers.api
{
    [Route("[controller]")]
    public class ItemsController : Controller
    {
        private ipdbContext _context;
        public ItemsController(ipdbContext context)
        {
            _context = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();

                // Skip number of Rows count  
                var start = Request.Form["start"].FirstOrDefault();

                // Paging Length 10,20  
                var length = Request.Form["length"].FirstOrDefault();

                // Sort Column Name  
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();

                // Sort Column Direction (asc, desc)  
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();

                // Search Value from (Search box)  
                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                //Paging Size (10, 20, 50,100)  
                int pageSize = length != null ? Convert.ToInt32(length) : 0;

                int skip = start != null ? Convert.ToInt32(start) : 0;

                int recordsTotal = 0;
                // getting all Customer data  
                var customerData = (from b in _context.TblGame
                                    join c in _context.TblVersion on b.Id equals c.IdGame
                                    join d in _context.TblVersionEsra on c.Id equals d.IdVersion
                                    where ((b.IsInIntroduction != true) && b.ShowInEsraWebsite == true && c.IdPlatform != 8 && c.IdPlatform != 9 && d.IdEsraStatus == 1 && d.IdEsraType == 3)
                                    select b).OrderByDescending(x => x.Id).ToList<TblGame>();
                //Sorting  
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    customerData = customerData.OrderBy(x => x.Name).ToList<TblGame>();
                }
                //Search  
                if (!string.IsNullOrEmpty(searchValue))
                {
                    customerData = customerData.Where(m => m.Name.ToLower().Contains(searchValue.ToLower())).ToList<TblGame>();
                }

                //total number of rows counts   
                recordsTotal = customerData.Count();
                //Paging   
                var data = customerData.Skip(skip).Take(pageSize).ToList<TblGame>();
                List<DataTableModel> outData = new List<DataTableModel>();
                foreach (var t in data)
                {
                    DataTableModel n = new DataTableModel();
                    n.name = t.Name;
                    n.mid = t.Id.ToString();
                    outData.Add(n);
                }
                //Returning Json Data  
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = outData });

            }
            catch (Exception ex)
            {

            }

            //gameIntroductionRepository ali = new gameIntroductionRepository(_context);
            //List<Item> lastItems = ali.getGames().ToList<Item>();
            //dynamic response = new
            //{
            //    Data = lastItems,
            //    Draw = "1",
            //    RecordsFiltered = lastItems.Count,
            //    RecordsTotal = lastItems.Count
            //};

            return Ok("");
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private List<Models.Item> GetData(GameIntroductionViewModel gijoe)
        {
            List<Models.Item> lastItems = new List<Models.Item>();
            for (int i = 0; i < gijoe.GiGames.Count; i++)
            {
                Item me = new Item();
                me.ageRating = gijoe.GiGames[i].AgeRating;
                me.gamePlatform = gijoe.GiGames[i].platform;
                me.gameTitle = gijoe.GiGames[i].Name;
                me.genre = gijoe.GiGames[i].genres[0].ToString();
                me.editGame = gijoe.GiGames[i].IdGame.ToString();
                lastItems.Add(me);
            }
            return lastItems;
        }
    }
}
