using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EntityDEMO.model
{
    public class Samochod : IPojazd
    {
        public string TypPojazdu { get; set; }
        public int predkoscMax { get; set; }
        public int SposobPrzemieszczania { get; set; }

        public Samochod(string typ, int maxSpeed)
        {
            TypPojazdu = typ;
            predkoscMax = maxSpeed + 1;
            SposobPrzemieszczania = (int)Przemieszczanie.Jezdzi;
        }

        public void Jedz()
        {
            MessageBox.Show("Jedzie");
        }
    }

    public enum Przemieszczanie
    {
        Jezdzi,
        Lata,
        Plywa
    }
}
