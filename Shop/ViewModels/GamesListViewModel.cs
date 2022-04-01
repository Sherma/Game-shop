using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class GamesListViewModel
    {
        public IEnumerable<Game> AllGames { get; set; }
        public string currentCategory { get; set; }
    }
}
