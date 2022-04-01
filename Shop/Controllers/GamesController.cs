using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class GamesController : Controller
    {
        private readonly iAllGames _allGames;
        private readonly iGameCategory _allCategories;
        public GamesController(iAllGames IAllGames, iGameCategory iGamesCategories)
        {
            _allGames = IAllGames;
            _allCategories = iGamesCategories;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Сторінка з іграми";
            GamesListViewModel obj = new GamesListViewModel();
            obj.AllGames = _allGames.Games;
            obj.currentCategory = "Ігри";
            return View(obj);
        }

    }
}
