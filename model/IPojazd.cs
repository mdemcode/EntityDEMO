using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDEMO.model
{
    public interface IPojazd
    {
        string TypPojazdu { get; set; }
        int predkoscMax { get; set; }
        int SposobPrzemieszczania { get; set; }

        void Jedz();
    }
}
