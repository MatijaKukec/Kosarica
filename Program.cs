using System;
using System.Collections.Generic;
using System.Text;
using KosaricaZakupovinu2;


namespace KosaricaZaKupovinu2
{
    class Program
    {
        static void Main(string[] args)
        {
            // dođe Ana u Web dućan

            Vlasnik ana = new Vlasnik("anaanic@mev.hr", "Ana Anić", "Mihovljanska 16, Čakovec");


            Console.WriteLine("Kupac {0}",ana);
            ana.PromjeniAdresu("A.G.Matoša 112c, Osjek");

            Console.WriteLine("Kupac mijenja adresu... \n {0}", ana);

            // Ana uzima kosaricu
            Kosarica anina = new Kosarica(ana);

            // Ana ide kupovati i odabere iPhone
            Stavka iphone = new Stavka("iPhone XS", (decimal)5034.23);

            // baci u kosaricu
            anina.DodajStavku(iphone);
            anina.DodajStavku("USB kabel", 34.23m, 3);
            anina.DodajStavku("Maskica Spigen - Neo Hybrid Blue", 187,1);

            // ispisi kosaricu
            ispisKosarice(anina);

            // plati ili odustani
            anina.Plati();

            try
            {
                anina.DodajStavku(iphone);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Dogodila se greška: {0}", ex.Message);
            }

            

            Console.ReadKey();
        }
        // pomocna metoda
        private static void ispisKosarice(Kosarica k)
        {
            // glava
            Console.WriteLine("Košarica ID: {0}\nKupac: {1}\nStatus: {2}\nStavke //////////////////////////////\n",
                k.VratiId(), k.VratiStatus(), k.VratiStavke());
            // stavke
            int brojac = 0;
            foreach (Stavka s in k.VratiStavke())
            {
                Console.WriteLine("{0}. {1}", ++brojac, s);
            }
            // podnozje
            Console.WriteLine("Ukupno za platiti: {0,39:F2}", k.VratiIznos());
        }

    }
}
