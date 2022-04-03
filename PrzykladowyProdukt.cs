using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    class PrzykladowyProdukt:ASubject
    {
        public void ZmianaCeny(float ceny)
        {
            Informacja(ceny);
        }
    }
}
