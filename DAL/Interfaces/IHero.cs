using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IHero
    {
        void InsertHero();
        bool DeleteHero(int id);
        Hero EditHero(Hero hero);
        List<Hero> GetAllHeroes();
        Hero GetHeroById(int id);

    }
}
