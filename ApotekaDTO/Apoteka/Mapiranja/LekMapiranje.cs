using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class LekMapiranje : ClassMap<Lek>
    {
        public LekMapiranje()
        {
            Table("LEK");

            DiscriminateSubClassesOnColumn("TIP_LEKA");

            Id(x => x.komercijalniNaziv, "KOMERCIJALNI_NAZIV").GeneratedBy.Assigned();
            Map(x => x.hemijskiNaziv, "HEMIJSKI_NAZIV");
            Map(x => x.dejstvoLeka, "DEJSTVO_LEKA");
            Map(x => x.cenaLeka, "CENA_LEKA");
            Map(x => x.procenatParticipacije, "PROCENAT_PARTICIPACIJE");
            Map(x => x.izdavanjeNaRecept, "IZDAVANJE_NA_RECEPT").Not.Nullable();
            Map(x => x.nacinDoziranjaZaDecu, "NACIN_DOZIRANJA_ZA_DECU");
            Map(x => x.nacinDoziranjaZaOdrasle, "NACIN_DOZIRANJA_ZA_ODRASLE");
            Map(x => x.nacinDoziranjaZaTrudnice, "NACIN_DOZIRANJA_ZA_TRUDNICE");

            References(x => x.pripadaProizvodjacu).Column("ID_PROIZV").LazyLoad();

            HasMany(x => x.listaPakovanja).KeyColumn("ID_LEKA").Inverse().Cascade.All();//1-n prema pakovanju

            HasMany(x => x.listaIndikacija).KeyColumn("ID_LEKA_IND").Cascade.All();
            HasMany(x => x.listaKontraindikacija).KeyColumn("ID_LEKA_KIND").Cascade.All();
            HasMany(x => x.listaNezeljenihEfekata).KeyColumn("ID_LEKA").Cascade.All();

            HasManyToMany(x => x.listaProdajnihMesta).Table("PRODAJE").ParentKeyColumn("ID_LEKA_PRODAJA")
                .ChildKeyColumn("ID_PROD_M")
                .Cascade.All();
            HasMany(x => x.listaProdaja).KeyColumn("ID_LEKA_PRODAJA").LazyLoad().Cascade.All().Inverse();


            HasMany(x => x.listRecepata).KeyColumn("KOMERCIJALNI_NAZIV_LEKA");
            


        }
    }
}



class AntibiotikMapiranje : SubclassMap<Antibiotik>
{
    public AntibiotikMapiranje()
    {
        DiscriminatorValue("ANTIBIOTIK");
    }
}

class AnalgetikMapiranje : SubclassMap<Analgetik>
{
    public AnalgetikMapiranje()
    {
        DiscriminatorValue("ANALGETIK");
    }
}

class AntipiretikMapiranje : SubclassMap<Antipiretik>
{
    public AntipiretikMapiranje()
    {
        DiscriminatorValue("ANTIPIRETIK");
    }
}

class DiuretikMapiranje : SubclassMap<Diuretik>
{
    public DiuretikMapiranje()
    {
        DiscriminatorValue("DIURETIK");
    }
}