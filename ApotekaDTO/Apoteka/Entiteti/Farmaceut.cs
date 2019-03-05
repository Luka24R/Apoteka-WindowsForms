using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Entiteti
{
    public class Farmaceut:Zaposleni
    {
        public virtual DateTime datumObnoveLicence { get; set; }
        public virtual DateTime datumDiplomiranja { get; set; }
    }
}
