using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota2Helper.Models
{
    public class Pick
    {
        public int PickId { get; set; }
        public int HeroId { get; set; }
        public DateTime PlayDate { get; set; }
        public bool Result { get; set; }
        public int Player { get; set; }
    }
}
