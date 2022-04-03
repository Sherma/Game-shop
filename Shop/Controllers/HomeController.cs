using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController: Controller
    {
        private readonly iAllGames _gameRep;

        public HomeController(iAllGames gameRep)
        {
            _gameRep = gameRep;
        }

        public ViewResult Index()
        {
            var homeGames = new HomeViewModel
            {
                favGames = _gameRep.getFavGames
            };
            return View(homeGames);

        }
    }
}
