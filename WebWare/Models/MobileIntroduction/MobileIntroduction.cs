using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace WebWare.Models.MobileIntroduction
{
    public class MobileIntroduction
    {
        public string result { get; set; }
        public string gameTitle { get; set; }
        public int gameIdReal { get; set; }
        public int gameVersionId { get; set; }
        public string platform { get; set; }
        public int year { get; set; }
        public string publisherName { get; set; }
        public string ageRating { get; set; }
        public string IntroductionMin { get; set; }
        public string CoverPicName { get; set; }
        [FileExtensions(Extensions = "jpg,jpeg,png,pdf")]
        public IFormFile cover { get; set; }
        public bool isInIntroduction { get; set; }
    }
}
