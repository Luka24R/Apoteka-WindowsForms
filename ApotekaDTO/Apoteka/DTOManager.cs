using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Apoteka.Entiteti;
using NHibernate;
using NHibernate.Linq;


namespace Apoteka
{
    public class DTOManager
    {

        public static List<ProdajnoMestoPregled> prodajnaMePregled()
        {
            List<ProdajnoMestoPregled> prodMestaInfo = new List<ProdajnoMestoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ProdajnoMesto> mesta = from m in s.Query<ProdajnoMesto>()
                                                   select m;

                foreach (ProdajnoMesto p in mesta)
                {
                    prodMestaInfo.Add(new ProdajnoMestoPregled(p.idProdajnogMesta, p.nazivProdajnogMesta,p.adresaProdajnogMesta));
                }


                s.Close();


            }
            catch(Exception e)
            {
                
            }
            return prodMestaInfo;
        }

        public static List<LekPregled> lekoviInfo(int idprodajnogmesta)
        {
            List<LekPregled> lekInfo = new List<LekPregled>();
            //ovde i kolicina leka za idProdajnogMesta i dati Lek
            try
            {
                ISession s = DataLayer.GetSession();

                /*IList<Lek> lekovi = s.QueryOver<Lek>().Inner.JoinQueryOver<ProdajnoMesto>(x=>x.listaProdajnihMesta)
                                                                        .Where(y => y.idProdajnogMesta == idprodajnogmesta)
                                                                        .List<Lek>();*/
                ProdajnoMesto pm = s.Get<ProdajnoMesto>(idprodajnogmesta);

                foreach(Lek l in pm.listaLekova)
                {
                    if(l.GetType()==typeof(Entiteti.Antibiotik))
                    {
                        Prodaje x = s.Load<Prodaje>( new ProdajeId() { idLeka = l, idProdajnogMesta = pm } );
                        
                        lekInfo.Add(new LekPregled(l.komercijalniNaziv, l.cenaLeka, l.izdavanjeNaRecept, "ANTIBIOTIK") { kolicina=x.kolicinaLeka}  );
  
                    }
                    else if(l.GetType()==typeof(Entiteti.Analgetik))
                    {

                        Prodaje x = s.Load<Prodaje>(new ProdajeId() { idLeka = l, idProdajnogMesta = pm });
                        lekInfo.Add(new LekPregled(l.komercijalniNaziv, l.cenaLeka, l.izdavanjeNaRecept, "ANALGETIK") { kolicina=x.kolicinaLeka });
   
                    }
                    else if(l.GetType()==typeof(Entiteti.Antipiretik))
                    {
                        Prodaje x = s.Load<Prodaje>(new ProdajeId() { idLeka = l, idProdajnogMesta = pm });
                        lekInfo.Add(new LekPregled(l.komercijalniNaziv, l.cenaLeka, l.izdavanjeNaRecept, "ANTIPIRETIK") { kolicina=x.kolicinaLeka });
 
                    }
                    else {
                        Prodaje x = s.Load<Prodaje>(new ProdajeId() { idLeka = l, idProdajnogMesta = pm });
                        lekInfo.Add(new LekPregled(l.komercijalniNaziv, l.cenaLeka, l.izdavanjeNaRecept, "DIURETIK") { kolicina=x.kolicinaLeka });
                    }
                    
                }
               

                s.Close();
            }
            catch(Exception e)
            {
                
            }
           

            return lekInfo;
        }

        public static List<FarmaceutPregled> farmaceutiPregled(int idProdajnogMesta)
        {
            List<FarmaceutPregled> farmInfo = new List<FarmaceutPregled>();

            try 
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Farmaceut> farmaceuti = from m in s.Query<Farmaceut>()
                                                   where m.radi.idProdajnogMesta == idProdajnogMesta
                                                   select m;

                foreach(Farmaceut f in farmaceuti)
                {
                    farmInfo.Add(new FarmaceutPregled(f.idZaposlenog, f.ime, f.prezime));
                }

                s.Close();


            }
            catch(Exception e)
            {

            }
            return farmInfo;
        }

        public static ReceptRealizacija ReceptRealizuje(ReceptRealizacija rr)
        {
            try
            {
                //ucitaj lek za koji se realizuje
                //prodajnomesto na kome se realizuje
                //farmaceut koji ga realizuje
                ISession s = DataLayer.GetSession();
                Zaposleni z = s.Get<Zaposleni>(rr.farmaceut.id);
                
                
                Recept r = new Recept();
                
                    r.tip = rr.tip;
                    r.oblikPakovanja = rr.oblikPakovanja;
                    r.datumRealizacije = rr.datumRealizacije;
                    r.datumIzdavanja = rr.datumIzdavanja;
                    //r.datumIzdavanja = new DateTime(2012, 12, 12);
                    //r.datumRealizacije = new DateTime(2012, 12, 12);
                    r.kolicinaLeka = rr.kolicinaLeka;
                    r.idLekara = rr.idLekara;
                
                Lek l = s.Load<Lek>(rr.lek.naziv);
                r.zaLek = l;

                r.idZaposlenog = z;

                ProdajnoMesto p = s.Get<ProdajnoMesto>(rr.prodajnoMesto.id);
                r.idProdajnogMesta = p;

                s.SaveOrUpdate(r);

                l.listRecepata.Add(r);
                p.listaIzdatihRecepata.Add(r);
                z.listaIzdatihRecepata.Add(r);

                s.SaveOrUpdate(l);
                s.SaveOrUpdate(p);
                s.SaveOrUpdate(z);

                s.Close();

            }
            catch (Exception e)
            {

            }
            return rr;

        }

        public static void updateKolicinuLeka(ProdajnoMestoPregled pmp, LekPregled lp, int kolicina)
        {
            try
            {
                //za dati lek -lp-   smanjiti u tabeli "prodaje" kolicunu leka   na prodajnom mestu  -pmp-
                ISession s = DataLayer.GetSession();
                Lek l = s.Get<Lek>(lp.naziv);
                ProdajnoMesto pm = s.Get<ProdajnoMesto>(pmp.id);
                Prodaje x = s.Load<Prodaje>(new ProdajeId() { idLeka = l, idProdajnogMesta = pm });

                x.kolicinaLeka -= kolicina;
                s.Update(x);
                s.Flush();

                s.Close();
            }
            catch
            {

            }
        }

        
















    }
}
