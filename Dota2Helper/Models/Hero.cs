using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace Dota2Helper.Models
{
    public class Hero
    {
        public int HeroId { get; set; }
        public int PickId { get; set; }
        public string HeroName { get; set; }
        public List<int> GHero { get; set; }
        public List<int> BHero { get; set; }
        public int HeroTypeId { get; set; }

        public List<Hero> getAllHeroes()
        {
           var heroes = HeroesLogic.GetAllHeroes();
            List<Hero> her = new List<Hero>();
            foreach (var item in heroes)
            {
                var hero = new Hero();
                hero.HeroId = item.HeroId;
                HeroName = item.HeroName;
                her.Add(hero);
            }
            return her;
        }
    }
}
