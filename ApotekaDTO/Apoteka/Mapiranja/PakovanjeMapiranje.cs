using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class PakovanjeMapiranje : ClassMap<Pakovanje>
    {
        public PakovanjeMapiranje()
        {
            Table("PAKOVANJE");

            DiscriminateSubClassesOnColumn("TIP_PAKOVANJA");

            Id(x => x.idPakovanja).Column("ID_PAKOVANJA").GeneratedBy.SequenceIdentity("ID_PAKOVANJA_SEQ");

            Map(x => x.kolicina, "KOLICINA");
            Map(x => x.sastav, "SASTAV");
            //Map(x => x.tipPakovanja, "TIP_pakovanja");

            References(x => x.pakujeLek).Column("ID_LEKA").LazyLoad();
        }
    }

    class SirupMapiranje : SubclassMap<Sirup>
    {
        public SirupMapiranje()
        {
            DiscriminatorValue("SIRUP");
        }
    }

    class TabletaMapirane : SubclassMap<Tableta>
    {
        public TabletaMapirane()
        {
            DiscriminatorValue("TABLETA");
        }
    }

    class PrasakMapiranja : SubclassMap<Prasak>
    {
        public PrasakMapiranja()
        {
            DiscriminatorValue("PRASAK");
        }
    }

    class InekcijaMapiranja : SubclassMap<Inekcija>
    {
        public InekcijaMapiranja()
        {
            DiscriminatorValue("INEKCIJA");
        }
    }
}
