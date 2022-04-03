using System;

namespace entity
{
    class Program
    {
        static void Main(string[] args)
        {
            PrzykladowyProdukt produkt = new PrzykladowyProdukt();
            Sklep sklep = new Sklep("sklep");
            Sklep sklep1 = new Sklep("inny");
            produkt.Dodaj(sklep1);
            produkt.Dodaj(sklep);
            produkt.ZmianaCeny(10.12f);
            produkt.Usun(sklep1);
            produkt.ZmianaCeny(1.0f);
        }
    }
}
