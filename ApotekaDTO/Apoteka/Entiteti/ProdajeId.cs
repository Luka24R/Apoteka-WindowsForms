using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Entiteti
{
    public class ProdajeId
    {
        public virtual ProdajnoMesto idProdajnogMesta { get; set; }
        public virtual Lek idLeka { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(ProdajeId))
                return false;

            ProdajeId recievedObject = (ProdajeId)obj;

            if ((idProdajnogMesta.idProdajnogMesta == recievedObject.idProdajnogMesta.idProdajnogMesta) &&
                (idLeka.komercijalniNaziv == recievedObject.idLeka.komercijalniNaziv))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
