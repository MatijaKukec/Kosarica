using KosaricaZakupovinu2;
using System;
using System.Collections.Generic;
using System.Text;

namespace KosaricaZaKupovinu2
{
    class Kosarica
    {

        private Vlasnik vlasnik;
        private Guid id;
        private Status status;
        private List<Stavka> stavke;
        
        public Kosarica(Vlasnik _vlasnik)
        {
            vlasnik = _vlasnik;
            id = Guid.NewGuid();
            status = Status.Prazna;
            stavke = new List<Stavka>();
        }

        public Vlasnik VratiVlasnika()
        {
            return vlasnik;
        }

        public Guid VratiId()
        {
            return id;
        }

        public Status VratiStatus()
        {
            return status;
        }
   
        public List<Stavka> VratiStavke()
        {
            return stavke;
        }

        // dodavanje, brisanje iz kosarice
        public void DodajStavku(Stavka s)
        {
            if (!Zakljucana())
                stavke.Add(s);
            else
                throw new Exception("Košarica je realizirana!");
        }

        public void DodajStavku(string opis, decimal cijena, int kolicina)
        {
            stavke.Add(new Stavka(opis, cijena, kolicina));
        }

        public void ObrisiStavku(Stavka s)
        {
            if (!Zakljucana())
                stavke.Remove(s);
            else
                throw new Exception("Košarica je realizirana!");
        }

        public void OcistiStavke()
        {
            stavke.Clear();
        }

        // iznos kosarice
        public decimal VratiIznos()
        {
            decimal iznos=0;
            foreach (Stavka s in stavke)
                iznos += s.VratiIznos();
            return iznos;
        }

        //• Privatnu metodu zakljucana() koja vraća ako je košarica zaključana. 
        //Zaključena je ako joj je status Plaćena ili Stornirana. 
        //Ako je košarica zaključana onda metode za dodavanje i brisanje stavaka ne rade ništa.
        
        private bool Zakljucana()
        {
            return status == Status.Placena || status == Status.Stornirana;
        }

        // placanje i storniranje

        public void Plati()
        {
            status = Status.Placena;
        }

        public void Storniraj()
        {
            status = Status.Stornirana;
        }
    }
}
