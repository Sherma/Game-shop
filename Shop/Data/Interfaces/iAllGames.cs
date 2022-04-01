using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
    public interface iAllGames
    {
        IEnumerable<Game> Games { get;  }
        IEnumerable<Game> getFavGames { get;  }
        Game getObjectGame(int gameId);
    }
}
