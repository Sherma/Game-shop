using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class GameRepository : iAllGames
    {
        private readonly AppDBContent appDBContent;

        public GameRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Game> Games => appDBContent.Game.Include(c => c.Category);

        public IEnumerable<Game> getFavGames => appDBContent.Game.Where(p => p.isFavorite).Include(c => c.Category);

        public Game getObjectGame(int gameId) => appDBContent.Game.FirstOrDefault(p => p.id == gameId);
       
         
        
    }
}
