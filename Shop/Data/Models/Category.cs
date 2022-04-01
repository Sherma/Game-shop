using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryname { set; get; }
        public string description { set; get; }
        public List<Game> games { set; get; }
    }
}
