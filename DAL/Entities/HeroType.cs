using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class HeroType
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int HeroId { get; set; }
    }
}
