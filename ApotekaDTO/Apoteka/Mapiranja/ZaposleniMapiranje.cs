using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class ZaposleniMapiranje : ClassMap<Zaposleni>
    {
        public ZaposleniMapiranje()
        {
            Table("ZAPOSLENI");


            Id(x => x.idZaposlenog).Column("ID_ZAPOSLENOG").GeneratedBy.SequenceIdentity("ID_ZAPOSLENOG_SEQ");

            Map(x => x.adresaZaposlenog, "ADRESA");
            Map(x => x.brojTelefona, "BROJ_TELEFONA");
            Map(x => x.datumRodjenja, "DATUM_RODJENJA");
            Map(x => x.ime, "IME");
            Map(x => x.prezime, "PREZIME");
            Map(x => x.maticniBroj, "MATICNI_BROJ");

            References(x => x.radi).Column("ID_PR_MESTO").LazyLoad();
            
            HasMany(x => x.listaIzdatihRecepata).KeyColumn("ID_ZAPOSLENI");
        }
    }
}
