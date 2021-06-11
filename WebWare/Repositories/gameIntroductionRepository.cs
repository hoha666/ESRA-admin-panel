using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWare.Interfaces;
using WebWare.Models;
using WebWare.Models.GameIntroductionViewModels;

namespace WebWare.Repositories
{
    public class gameIntroductionRepository : IGameIntroduction
    {
        private ipdbContext _portal;
        public gameIntroductionRepository(ipdbContext context)
        {
            _portal = context;
        }
        public IEnumerable<Item> getGames()
        {
            var Introductions = new GameIntroductionViewModel(_portal, 1);
            List<Item> lastItems = GetData(Introductions);
            return lastItems;
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
