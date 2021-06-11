using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Contents
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int CategoryId { get; set; }
        public DateTime PublishedDate { get; set; }
        public int View { get; set; }
        public string Sender { get; set; }
        public string SubTitle { get; set; }
        public string Image { get; set; }
    }
}
