using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class ReceptMapiranje : ClassMap<Recept>
    {
        public ReceptMapiranje()
        {
            Table("RECEPT");

            Id(x => x.serijskiBroj).Column("SERIJSKI_BROJ").GeneratedBy.SequenceIdentity("SERIJSKI_BROJ_SEQ");

            Map(x => x.tip, "TIP");
            Map(x => x.datumIzdavanja, "DATUM_IZDAVANJA");
            Map(x => x.oblikPakovanja, "OBLIK_PAKOVANJA");
            Map(x => x.kolicinaLeka, "KOLICINA_LEKA");
            Map(x => x.datumRealizacije, "DATUM_REALIZACIJE");
            Map(x => x.idLekara, "LEKARID");

            References(x => x.zaLek).Column("KOMERCIJALNI_NAZIV_LEKA");

            References(x => x.idZaposlenog).Column("ID_ZAPOSLENI").LazyLoad();
            References(x => x.idProdajnogMesta).Column("ID_PROD_MESTO").LazyLoad();
            
        }
    }
}
