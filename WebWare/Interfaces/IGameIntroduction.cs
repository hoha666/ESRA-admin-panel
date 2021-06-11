using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebWare.Interfaces
{
    interface IGameIntroduction
    {
        IEnumerable<Models.Item> getGames();
    }
}
