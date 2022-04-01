using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Game
    {
        public int id { set; get; }
        public string gamename { set; get; }
        public string shortdesc { set; get; }
        public string longdesc { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool isFavorite { set; get; }
        public bool available { set; get; }
        public int categoryID { set; get; }
        public virtual Category Category { set; get; }
    }
}
