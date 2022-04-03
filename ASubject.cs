using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    class ASubject
    {
        ArrayList list = new ArrayList();
        public void Dodaj(Sklep s)
        {
            list.Add(s);
        }
        public void Usun(Sklep s)
        {
            list.Remove(s);
        }
        public void Informacja(float cena)
        {
            
            foreach (Sklep p in list)
            {
                p.Update(cena);
            }

        }
    }
}
