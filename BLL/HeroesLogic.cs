using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;

namespace BLL
{
   public static class HeroesLogic
    {
       public static List<Hero> GetAllHeroes()
        {
            
            Heroes heroes = new Heroes();
            return heroes.GetAllHeroes();
        }
    }
}
