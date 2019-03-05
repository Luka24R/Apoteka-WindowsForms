using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class KontraindikacijeMapiranje : ClassMap<Kontraindikacije>
    {

        public KontraindikacijeMapiranje()
        {
            Table("KONTRAINDIKACIJE");
            
            //Id(x => x.idLEK).Column("ID_LEKA_KIND");
            CompositeId().KeyProperty(x => x.opisKontraindikacije, "OPIS_KONTRAINDIKACIJA")
                .KeyReference(x => x.idLeka, "ID_LEKA_KIND");
                            //.KeyProperty(x => x.idLEK, "ID_LEKA_KIND");
            //Map(x => x.opisKontraindikacije, "OPIS_KONTRAINDIKACIJA");
            //References(x => x.idLeka).Column("ID_LEKA_KIND").LazyLoad();
        }

    }
}
