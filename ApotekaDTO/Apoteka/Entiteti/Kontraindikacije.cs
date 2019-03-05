using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Entiteti
{
    public class Kontraindikacije
    {
        //public virtual string idLEK { get; set; }
        public virtual string opisKontraindikacije { get; set; }
        public virtual Lek idLeka { get; set; }

        public override bool Equals(object Object)
        {

            //if (Object.ReferenceEquals(this, Object))
            //    return true;

            //if (Object.GetType() != typeof(Kontraindikacije))
            //    return false;

            //Kontraindikacije recievedObject = (Kontraindikacije)Object;

            //if (opisKontraindikacije.Equals(recievedObject.opisKontraindikacije) &&
            //    (idLeka.komercijalniNaziv.Equals(recievedObject.idLeka.komercijalniNaziv)))
            //{
            //    return true;
            //}

            return false;
        }

        public override int GetHashCode()
        {
            //return (idLeka.komercijalniNaziv + "|" + opisKontraindikacije).GetHashCode();
            return base.GetHashCode();
        }
    }
}
