using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class NezeljeniEfektiMapiranje : ClassMap<NezeljeniEfekti>
    {
        public NezeljeniEfektiMapiranje()
        {
            Table("NEZELJENI_EFEKTI");
            CompositeId().KeyProperty(x => x.opisEfekta, "OPIS_EFEKTA")
                .KeyReference(x => x.idLeka, "ID_LEKA");
            //Id(x => x.idLEK).Column("ID_LEKA");
            
            //Map(x => x.opisEfekta, "OPIS_EFEKTA");
            //References(x => x.idLeka).Column("ID_LEKA").LazyLoad();

        }
    }
}
