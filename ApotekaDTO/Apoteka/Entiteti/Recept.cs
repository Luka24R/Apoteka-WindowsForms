using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Entiteti
{
    public class Recept
    {
        public virtual int serijskiBroj { get; set; }
        public virtual string tip { get; set; }
        public virtual DateTime datumIzdavanja { get; set; }
        public virtual string oblikPakovanja { get; set; }
        public virtual int kolicinaLeka { get; set; }
        public virtual DateTime datumRealizacije { get; set; }
        public virtual int idLekara { get; set; }
        public virtual Lek zaLek { get; set; }

        public virtual Zaposleni idZaposlenog { get; set; }
        public virtual ProdajnoMesto idProdajnogMesta { get; set; }
    }
}
