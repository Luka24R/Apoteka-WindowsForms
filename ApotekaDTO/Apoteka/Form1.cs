using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Apoteka.Entiteti;
using NHibernate.Exceptions;

namespace Apoteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sd = DataLayer.GetSession();

                
                //Apoteka.Entiteti.Proizvodjac p = sd.Load<Apoteka.Entiteti.Proizvodjac>(2);
                //Analgetik l = sd.Load<Analgetik>("BROMAZEPAM");
                //IList<Kontraindikacije> list = sd.QueryOver<Kontraindikacije>().List<Kontraindikacije>();
                //Analgetik l1 = sd.Load<Analgetik>("BROMAZEPAM");
                Antibiotik l = sd.Load<Antibiotik>("ERITROMICIN");
                MessageBox.Show(l.izdavanjeNaRecept);
                Kontraindikacije k = sd.Load<Kontraindikacije>(l.listaKontraindikacija.ElementAt(0));
                MessageBox.Show(k.idLeka.komercijalniNaziv + " " + l.listaProdajnihMesta.ElementAt(0).nazivProdajnogMesta + " " + k.opisKontraindikacije);
                Indikacije i = sd.Load<Indikacije>(l.listaIndikacija.ElementAt(0));
                MessageBox.Show(i.idLeka.komercijalniNaziv + " " + l.listaProdajnihMesta.ElementAt(0).nazivProdajnogMesta + " " + i.opisIndikacije);
                NezeljeniEfekti n = sd.Load<NezeljeniEfekti>(l.listaNezeljenihEfekata.ElementAt(0));
                MessageBox.Show(n.idLeka.komercijalniNaziv + " " + l.listaProdajnihMesta.ElementAt(0).nazivProdajnogMesta + " " + n.opisEfekta);
                
                
                
                sd.Close();
            }
            //catch (GenericADOException ado) { MessageBox.Show(ado.Message.ToString()); }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnManyToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lek l1 = s.Load<Lek>("ERITROMICIN");

                foreach(ProdajnoMesto pm1 in l1.listaProdajnihMesta)
                {
                    MessageBox.Show(pm1.nazivProdajnogMesta+" "+pm1.listaProdaja.ElementAt(0).kolicinaLeka);
                }

                ProdajnoMesto pm2 = s.Load<ProdajnoMesto>(1);

                foreach(Lek l2 in pm2.listaLekova)
                {
                     MessageBox.Show(l2.komercijalniNaziv+" ");
                }


                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void zaposleniRecepti_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Load<Zaposleni>(1);
                
                foreach(Recept r in z.listaIzdatihRecepata)
                {
                    MessageBox.Show(r.serijskiBroj + " " + r.zaLek.komercijalniNaziv + " " + r.datumIzdavanja.ToShortDateString() + " " + r.datumRealizacije.ToShortDateString());
                }
                s.Close();

            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btncreateFarmaceut_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ProdajnoMesto p = s.Load<ProdajnoMesto>(1);
                Farmaceut f = new Farmaceut();
                f.adresaZaposlenog = "Pantelejska";
                f.brojTelefona = "+38164";
                f.datumRodjenja = DateTime.Now;
                f.ime = "AN";
                f.maticniBroj = "11111";
                f.prezime = "Pr";
                f.radi = p;
                f.datumObnoveLicence = DateTime.Now;
                f.datumDiplomiranja = DateTime.Now;
                
                s.Save(f);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnManyToOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Load<Zaposleni>(1);

                MessageBox.Show(z.radi.nazivProdajnogMesta);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sd = DataLayer.GetSession();
                IList<Zaposleni> zap = sd.QueryOver<Zaposleni>()
                                .Where(p => p.idZaposlenog == 2).List<Zaposleni>();
                Farmaceut z = (Farmaceut)zap[0];
                MessageBox.Show(z.ime);
                sd.Close();
            }
            
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession q = DataLayer.GetSession();

                

                Proizvodjac p = q.Load<Proizvodjac>(1);

                Antipiretik a = new Antipiretik();

                a.komercijalniNaziv = "ggvbi";

                a.cenaLeka = 11;
                a.dejstvoLeka = "esdvru";
                a.hemijskiNaziv="C12b23112";
                
                a.izdavanjeNaRecept = "DA";
    
                a.nacinDoziranjaZaDecu = "na 10 sati";
                a.nacinDoziranjaZaOdrasle = "na 8 sati";
                a.nacinDoziranjaZaTrudnice = "na 8 sati";
                a.pripadaProizvodjacu = p;
                a.procenatParticipacije = 5;

                Tableta t = new Tableta();
                t.kolicina = 1;
                t.sastav = "gposasdasdasddnjig";


                

                q.Save(a);
                
                t.pakujeLek = a;
                
                
                

                q.Save(t);

                a.listaPakovanja.Add(t);

                

                //sd.Flush();
                q.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sd = DataLayer.GetSession();

                ProdajnoMesto p = sd.Load<ProdajnoMesto>(4);
                Lek l = sd.Load<Lek>("ERITROMICIN");//nema ga u bazi ako se pokrece iz pocetka
                Prodaje pr = new Prodaje();
                pr.id.idLeka = l;
                pr.id.idProdajnogMesta = p;
                pr.kolicinaLeka = 200;
                sd.Save(pr);
                sd.Flush();

                sd.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
            ISession sd = DataLayer.GetSession();

            Zaposleni z = sd.Load<Zaposleni>(1);
            MessageBox.Show(z.idZaposlenog + " " + z.ime);
            Recept r1 = new Recept()
            {
                //serijskiBroj = 1584,
                tip = "Proba2",
                datumIzdavanja = new DateTime(2012, 12, 12),
                datumRealizacije = new DateTime(2012, 12, 12),
                oblikPakovanja = "TABLETA",
                kolicinaLeka = 1,
                idLekara = 1
            };

            Lek l = sd.Load<Lek>("ERITROMICIN");
            r1.zaLek = l;

            r1.idZaposlenog = z;

            ProdajnoMesto pr = sd.Load<ProdajnoMesto>(1);
            r1.idProdajnogMesta = pr;

            sd.SaveOrUpdate(r1);

            l.listRecepata.Add(r1);
            pr.listaIzdatihRecepata.Add(r1);
            z.listaIzdatihRecepata.Add(r1);

            zaposleniRecepti_Click(sender, e);

            sd.SaveOrUpdate(l);
            sd.SaveOrUpdate(pr);
            sd.SaveOrUpdate(z);

            sd.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sd = DataLayer.GetSession();
                
                Antibiotik a = sd.Load<Antibiotik>("ERITROMICIN");

                Kontraindikacije k = new Kontraindikacije();
                k.opisKontraindikacije = "pazi da te ne udari grom";
                Indikacije i = new Indikacije();
                i.opisIndikacije = "pre upotrebe promuckati";
                NezeljeniEfekti ne = new NezeljeniEfekti();
                ne.opisEfekta = "opadanje kose";
                
                k.idLeka = a;
                sd.Save(k);
                i.idLeka = a;
                sd.Save(i);
                ne.idLeka = a;
                sd.Save(ne);
                //a.listaKontraindikacija.Add(k);
                //sd.SaveOrUpdate(a);

                //sd.Flush();
                sd.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDTO_Click(object sender, EventArgs e)
        {
            ProdajnaMestaIzbor PMI = new ProdajnaMestaIzbor();
            PMI.Show();
        }

       
    }
}
