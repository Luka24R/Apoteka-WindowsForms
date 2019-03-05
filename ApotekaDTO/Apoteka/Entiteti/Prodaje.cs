using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Entiteti
{
    public class Prodaje
    {
        public virtual ProdajeId id { get; set; }
        public virtual int kolicinaLeka { get; set; }

        public Prodaje()
        {
            id = new ProdajeId();
        }
    }
}
