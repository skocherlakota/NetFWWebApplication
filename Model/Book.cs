using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFWWebApplication.Model
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PubDate { get; set; }
        public decimal Price { get; set; }
    }
}