using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Interfaces
{
    interface IPlayers
    {
        void InsertPlayer();
        bool DeleteHero(int id);
        Player EditPlayer(Player player);
        List<Player> GetAllPlayers();
        Player GetPlayerById(int id);
    }
}
