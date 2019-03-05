using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Entiteti
{
    public class NezeljeniEfekti
    {
        //public virtual string idLEK { get; set; }
        public virtual string opisEfekta { get; set; }
        public virtual Lek idLeka { get; set; }

        public override bool Equals(object Object)
        {
            /*if (Object.ReferenceEquals(this, Object))
                return true;

            if (Object.GetType() != typeof(NezeljeniEfekti))
                return false;

            NezeljeniEfekti recievedObject = (NezeljeniEfekti)Object;

            if (opisEfekta.Equals(recievedObject.opisEfekta) &&
                (idLeka.komercijalniNaziv == recievedObject.idLeka.komercijalniNaziv))
            {
                return true;
            }*/

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
