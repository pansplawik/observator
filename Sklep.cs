using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    class Sklep:IObserwator
    {
        string imie;
        float cena = 0.0f;
        public Sklep(string name)
        {
            this.imie = name;
        }
        public void Update(float price)
        {
            this.cena = price;
            Console.WriteLine($"Cena produktu {this.imie} to {this.cena}");
        }
    }
    interface IObserwator
    {
        public void Update(float cena)
        {

        }
    }
}
