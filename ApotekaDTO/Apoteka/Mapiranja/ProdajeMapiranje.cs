using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class ProdajeMapiranje : ClassMap<Prodaje>
    {
        public ProdajeMapiranje()
        {
            Table("PRODAJE");

            CompositeId(x => x.id)
                .KeyReference(x => x.idProdajnogMesta, "ID_PROD_M")
                .KeyReference(x => x.idLeka, "ID_LEKA_PRODAJA");

            Map(x => x.kolicinaLeka, "KOLICINA_LEKA");

        }
    }
}
