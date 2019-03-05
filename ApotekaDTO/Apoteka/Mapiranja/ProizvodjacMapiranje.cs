using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class ProizvodjacMapiranje : ClassMap<Proizvodjac>
    {
        public ProizvodjacMapiranje()
        {
            Table("PROIZVODJAC");

            Id(x => x.idProizvodjaca, "ID_PROIZVODJACA").GeneratedBy.Sequence("ID_PROIZVODJACA_SEQ");
            Map(x => x.imeProizvodjaca, "IME_PROIZVODJACA");//.Column("Ime_proizvodjaca");

            HasMany(x => x.listaLekova).KeyColumn("ID_PROIZV").Cascade.All();
        }
    }
}
