using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWare.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebWare.Data;
using Microsoft.EntityFrameworkCore.Extensions.Internal;
using Microsoft.AspNetCore.Http;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.XPath;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebWare.Models.GameIntroductionViewModels
{
    public class IntroductionViewModel
    {
        public string result { get; set; }
        public string gameTitle { get; set; }
        public string gameIdReal { get; set; }
        public int gameVersionId { get; set; }
        public string IntroductionMin { get; set; }
        public string gameplay { get; set; }
        public string parentRecommendation { get; set; }
        public string CoverPicName { get; set; }
        public string PicName1 { get; set; }
        public string PicName2 { get; set; }
        public string PicName3 { get; set; }
        public int coverId { get; set; }
        public int P1Id { get; set; }
        public int P2Id { get; set; }
        public int P3Id { get; set; }
        [FileExtensions(Extensions = "jpg,jpeg,png,pdf")]
        public IFormFile cover { get; set; }
        [FileExtensions(Extensions = "jpg,jpeg,png,pdf")]
        public IFormFile pic1 { get; set; }
        [FileExtensions(Extensions = "jpg,jpeg,png,pdf")]
        public IFormFile pic2 { get; set; }
        [FileExtensions(Extensions = "jpg,jpeg,png,pdf")]
        public IFormFile pic3 { get; set; }
        public bool isInIntroduction { get; set; }
        public string VersionAparatLink { get; set; }
        public int picto1 { get; set; }
        public int picto2 { get; set; }
        public int picto3 { get; set; }
        public int picto4 { get; set; }
        public int picto5 { get; set; }
        public int picto6 { get; set; }
        public List<SelectListItem> PictoList { get; set; }
        
    }
}
