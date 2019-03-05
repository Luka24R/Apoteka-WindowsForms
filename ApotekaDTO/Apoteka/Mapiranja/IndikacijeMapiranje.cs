using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class IndikacijeMapiranje : ClassMap<Indikacije>
    {
        public IndikacijeMapiranje()
        {
            Table("INDIKACIJE");

            //Id(x => x.idLEK).Column("ID_LEKA_IND");
            CompositeId().KeyProperty(x => x.opisIndikacije, "OPIS_INDIKACIJA")
                .KeyReference(x => x.idLeka, "ID_LEKA_IND");
            //Map(x => x.opisIndikacije, "OPIS_INDIKACIJA");
            //References(x => x.idLeka).Column("ID_LEKA_IND").LazyLoad();


        }
    }
}
