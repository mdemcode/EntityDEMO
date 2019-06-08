using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EntityDEMO.model
{
    class Samolot:IPojazd
    {
        public string TypPojazdu { get; set; }
        public int predkoscMax { get; set; }
        public int SposobPrzemieszczania { get; set; }

        public Samolot(string typ, int maxSpeed)
        {
            TypPojazdu = typ;
            predkoscMax = maxSpeed;
            SposobPrzemieszczania = (int)Przemieszczanie.Lata;
        }

        public void Jedz()
        {
            MessageBox.Show("Leci");
        }

    }
}
