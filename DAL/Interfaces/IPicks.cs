using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Interfaces
{
    interface IPicks
    {
        void InsertPick();
        bool DeletePick(int id);
        Pick EditPick(Pick pick);
        List<Pick> GetAllPicks();
        Pick GetPickById(int id);
    }
}
