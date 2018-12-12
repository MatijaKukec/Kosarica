using System;
using System.Collections.Generic;
using System.Text;

namespace KosaricaZaKupovinu2
{
    public class Stavka
    {
        private string opis;
        private int kolicina;
        private decimal cijena;

        //• Konstruktor sa 3 ulazna parametra (opis, količina, cijena) 
        public Stavka(string opis, decimal cijena, int kolicina)
        {
            this.opis = opis;
            this.kolicina = kolicina;
            this.cijena = cijena;
        }

        //• Konstruktor sa 2 ulazna parametra (opis, cijena) – količina je 1 
        public Stavka(string opis, decimal cijena)
        {
            this.opis = opis;
            this.cijena = cijena;
            kolicina = 1;
        }

        //• VratiOpis() 
        public string VratiOpis()
        {
            return opis;
        }

        //• VratiKolicinu() 
        public int VratiKolicinu()
        {
            return kolicina;
        }

        //• VratiCijenu() 
        public decimal VratiCijenu()
        {
            return cijena;
        }

        //• VratiVrijednost() – vrijednost stavke  (cijena * količina
        public decimal VratiIznos()
        {
            return cijena * kolicina;
        }

        public override string ToString()
        {
            return String.Format("{0,-30}{1,5}{2,10:F2}",opis,kolicina,cijena);
        }
    }
}
