using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Interfaces
{
    interface IHeroTypes
    {
        void InsertHeroType();
        bool DeleteHeroType(int id);
        HeroType EditHeroType(HeroType heroType);
        List<HeroType> GetAllHeroTypes();
        HeroType GetHeroTypeById(int id);
    }
}
