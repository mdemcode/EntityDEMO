using System;
using System.Data;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityDEMO.model
{
class KlasaBazy
{
        public class PojazdyDB : DbContext
        {
            public DbSet<Samochod> Samochody { get; set; }
            public DbSet<Samolot> Samoloty { get; set; }
            public DbSet<Statek> Statki { get; set; }
        }

    } 
}
