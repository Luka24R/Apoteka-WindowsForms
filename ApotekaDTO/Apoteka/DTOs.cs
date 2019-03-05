using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apoteka
{
    
    public class LekPregled
    {
        public string naziv { get; set; }
        public int cena { get; set; }
        public string naRecept { get; set; }
        public string tip { get; set; }
        //public string pakovanje { get; set; }

        public int kolicina { get; set; }

        public LekPregled(String n, int c, String r, String t)
        {
            this.naziv = n;
            this.cena = c;
            this.naRecept = r;
            this.tip = t;
        }

        

    }
    

    
    public class ProdajnoMestoPregled
    {
        public int id { get; set; }
        public String naziv { get; set; }
        public string adresa { get; set; }
        public ProdajnoMestoPregled(int i, String n, string a)
        {
            this.id = i;
            this.naziv = n;
            this.adresa = a;
        }

    }

    public class FarmaceutPregled
    {
        public int id { get; set; }
        public String ime { get; set; }
        public String prezime { get; set; }

        public FarmaceutPregled(int i, String im, String p)
        {
            this.id = i;
            this.ime = im;
            this.prezime = p;
        }
    }
    public class ReceptRealizacija
    {
        public DateTime datumRealizacije { get; set; }
        public DateTime datumIzdavanja { get; set; }
        public String oblikPakovanja { get; set; }
        public int kolicinaLeka { get; set; }
        public String tip { get; set; }
        public int idLekara { get; set; }

        public LekPregled lek { get; set; }
        public FarmaceutPregled farmaceut { get; set; }
        public ProdajnoMestoPregled prodajnoMesto { get; set; }

    }

}
