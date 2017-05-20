using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string UserName { get; set; }
        public int WinCount { get; set; }
        public int GameCount { get; set; }
        public string Email { get; set; }
    }
}
