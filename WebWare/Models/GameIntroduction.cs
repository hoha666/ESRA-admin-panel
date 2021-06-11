using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebWare.Models
{
    public class GameIntroduction
    {
        public string Name { get; set; }
        public string AgeRating { get; set; }
        public string IntroductionMin { get; set; }
        public List<string> genres { get; set; }
        public string platform { get; set; }
        public DateTime ReleaseYear { get; set; }
        public string Publisher { get; set; }
        public string TypeOfSource { get; set; }
        public string GamePlay { get; set; }
        public KeyValuePair<string, string> Pictograms { get; set; }
        public string ParentRecomendation { get; set; }
        public string CoverPictureFile { get; set; }
        public List<string> Pictures { get; set; }
        public List<string> Videos { get; set; }
        public int IdGame { get; set; }
    }
}
