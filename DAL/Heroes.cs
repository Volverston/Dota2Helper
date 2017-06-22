using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Helpers;
using DAL.Interfaces;

namespace DAL
{
    public class Heroes : IHero
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Hero Edit(int id)
        {
            throw new NotImplementedException();
        }

        public List<Hero> GetAll()
        {
            string query = "SELECT * FROM Heroes";
            List<Hero> heroes = new List<Hero>();
            using (IDataReader reader = DBHelper.GetDataReader(query))
            {
                while (reader.Read())
                {
                    heroes.Add(new Hero()
                    {
                        HeroId = (int)reader["HeroId"],
                        HeroName = (string)reader["HeroName"]
                    });
                }
            }
            return heroes;
        }

        public Hero GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Hero item)
        {
            throw new NotImplementedException();
        }
    }
}
