using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Entiteti
{
    public class Proizvodjac
    {
        public virtual int idProizvodjaca { get; protected set; }
        public virtual string imeProizvodjaca { get; set; }
        

        public virtual IList<Lek> listaLekova { get; set; }

        public Proizvodjac()
        {
            listaLekova = new List<Lek>();
        }
    }
}
