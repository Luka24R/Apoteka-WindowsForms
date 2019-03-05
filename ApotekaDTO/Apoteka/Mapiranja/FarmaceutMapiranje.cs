using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class FarmaceutMapiranje : SubclassMap<Farmaceut>
    {
        public FarmaceutMapiranje()
        {
            Table("FARMACEUT");

            KeyColumn("ID_ZAPOSLEN");

            Map(x => x.datumDiplomiranja, "DATUM_DIPLOMIRANJA");
            Map(x => x.datumObnoveLicence, "DATUM_OBNOVE_LICENCE");
        }
    }
}
