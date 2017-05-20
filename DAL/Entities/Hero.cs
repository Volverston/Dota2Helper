using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Hero
    {
        public int HeroId { get; set; }
        public int PickId { get; set; }
        public string HeroName { get; set; }
        public List<int> GHero { get; set; }
        public List<int> BHero { get; set; }
        public int HeroTypeId { get; set; }
    }
}
