using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apoteka.Entiteti
{
    public class Lek
    {
        public virtual string komercijalniNaziv { get; set; }
        public virtual string hemijskiNaziv { get; set; }
        public virtual string nacinDoziranjaZaOdrasle { get; set; }
        public virtual string nacinDoziranjaZaDecu { get; set; }
        public virtual string nacinDoziranjaZaTrudnice { get; set; }
        public virtual int cenaLeka { get; set; }
        public virtual int? procenatParticipacije { get; set; }
        public virtual string izdavanjeNaRecept { get; set; }
        public virtual string dejstvoLeka { get; set; }
        public virtual string tip { get; set; }
        public virtual Proizvodjac pripadaProizvodjacu { get; set; }

        public virtual IList<Pakovanje> listaPakovanja { get; set; }
        public virtual IList<Indikacije> listaIndikacija { get; set; }
        public virtual IList<Kontraindikacije> listaKontraindikacija { get; set; }
        public virtual IList<NezeljeniEfekti> listaNezeljenihEfekata { get; set; }
        public virtual IList<Prodaje> listaProdaja { get; set; }
        public virtual IList<ProdajnoMesto> listaProdajnihMesta { get; set; }

        public virtual IList<Recept> listRecepata { get; set; }

        public Lek()
        {
            listaPakovanja = new List<Pakovanje>();
            listaIndikacija = new List<Indikacije>();
            listaKontraindikacija = new List<Kontraindikacije>();
            listaNezeljenihEfekata = new List<NezeljeniEfekti>();
            listaProdaja = new List<Prodaje>();

            listaProdajnihMesta = new List<ProdajnoMesto>();

            listRecepata = new List<Recept>();
        }

    }

    public class Antibiotik:Lek
    {

    }
    public class Analgetik:Lek
    {

    }
    public class Antipiretik:Lek
    {

    }
    public class Diuretik:Lek
    {

    }
}
