using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class ProdajnoMestoMapiranje : ClassMap<ProdajnoMesto>
    {
        public ProdajnoMestoMapiranje()
        {
            Table("PRODAJNO_MESTO");

            Id(x => x.idProdajnogMesta, "ID_PRODAJNOG_MESTA").GeneratedBy.Sequence("ID_PRODAJNOG_MESTA_SEQ");

            Map(x => x.mestoProdajnogMesta, "MESTO");
            Map(x => x.adresaProdajnogMesta, "ADRESA");
            Map(x => x.nazivProdajnogMesta, "NAZIV");

            HasManyToMany(x => x.listaLekova).Table("PRODAJE").ParentKeyColumn("ID_PROD_M")
                   .ChildKeyColumn("ID_LEKA_PRODAJA")
                   .Inverse().Cascade.All();
            HasMany(x => x.listaProdaja).KeyColumn("ID_PROD_M").LazyLoad().Cascade.All().Inverse();

            HasMany(x => x.listaZaposlenih).KeyColumn("ID_PR_MESTO").LazyLoad().Cascade.All().Inverse();
           

            HasMany(x => x.listaIzdatihRecepata).KeyColumn("ID_PROD_MESTO");
        }
    }
}
