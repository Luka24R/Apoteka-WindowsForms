using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apoteka.Entiteti
{
    public class Zaposleni
    {
        public virtual int idZaposlenog { get; protected set; }
        public virtual string adresaZaposlenog { get; set; }
        public virtual string brojTelefona { get; set; }
        public virtual DateTime datumRodjenja { get; set; }
        public virtual string ime { get; set; }
        public virtual string prezime { get; set; }
        public virtual string maticniBroj { get; set; }
        public virtual ProdajnoMesto radi { get; set; }

        public virtual IList<Recept> listaIzdatihRecepata { get; set; }

        

        public Zaposleni()
        {
            listaIzdatihRecepata = new List<Recept>();
        }
    }

}
