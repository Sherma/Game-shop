using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
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

        [Route("Games/List")]
        [Route("Games/List/{category}")]

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Game> games = null;
            string currCatogory = "";
            if(string.IsNullOrEmpty(category))
            {
                games = _allGames.Games.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("strategy", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = _allGames.Games.Where(i => i.Category.categoryname.Equals("Стратегії")).OrderBy(i => i.id);
                    currCatogory = "Стратегії";
                }
                else
                {
                    if (string.Equals("3d_action", category, StringComparison.OrdinalIgnoreCase))
                    {
                        games = _allGames.Games.Where(i => i.Category.categoryname.Equals("3D-Action")).OrderBy(i => i.id);
                        currCatogory = "3D-Action";
                    }
                    else
                    {
                        if (string.Equals("simulator", category, StringComparison.OrdinalIgnoreCase))
                        {
                            games = _allGames.Games.Where(i => i.Category.categoryname.Equals("Симулятри")).OrderBy(i => i.id);
                            currCatogory = "Симулятри";
                        }
                        else
                        {
                            if (string.Equals("adventure", category, StringComparison.OrdinalIgnoreCase))
                            {
                                games = _allGames.Games.Where(i => i.Category.categoryname.Equals("Пригодницькі")).OrderBy(i => i.id);
                                currCatogory = "Пригодницькі";
                            }
                        }
                    }
                }
            }
            var gameObject = new GamesListViewModel
            {
                AllGames = games,
                currentCategory = currCatogory
            };

            ViewBag.Title = "Сторінка з іграми";

            return View(gameObject);
        }

    }
}
