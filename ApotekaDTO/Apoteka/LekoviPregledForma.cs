using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Apoteka
{
    public partial class LekoviPregledForma : Form
    {
        public List<LekPregled> lekovi { get; set; }
        public ProdajnoMestoPregled prMe { get; set; }
        public FarmaceutPregled fp { get; set; }

        public LekoviPregledForma()
        {
            InitializeComponent();
        }
        public LekoviPregledForma(ProdajnoMestoPregled p, FarmaceutPregled f)
        {
            this.prMe = p;
            this.fp = f;
            InitializeComponent();

        }

        private void LekoviPregledForma_Load(object sender, EventArgs e)
        {
            prikaziLekove();
            lblFarmaceut.Text ="Farmaceut"+" "+ fp.ime +" "+ fp.prezime;
            lblProdajnoMesto.Text = prMe.naziv+" "+prMe.adresa;
        }

        private void prikaziLekove()
        {
            lekovi = DTOManager.lekoviInfo(prMe.id);
            dgvLek.DataSource = lekovi;
        }

        private void btnProdajaLeka_Click(object sender, EventArgs e)
        {
            if (dgvLek.SelectedRows.Count == 0)
                return;
            int selectedRow = dgvLek.SelectedRows[0].Index;
            string idLek = (string)dgvLek["naziv", selectedRow].Value;
            //MessageBox.Show(idLek);
            LekPregled l = vratiLek(idLek);
            if(l.naRecept.Equals("NE"))
            {
                MessageBox.Show("Prodata je jedno pakovanje Leka");
                try { DTOManager.updateKolicinuLeka(prMe, l, 1); }
                catch (Exception eee) { MessageBox.Show(eee.Message); }
            }
            else
            {
                RealizacijaReceptaZaLek rrzl = new RealizacijaReceptaZaLek(l);
                DialogResult dr=rrzl.ShowDialog();
                if(dr==DialogResult.OK)
                {
                    ReceptRealizacija r = new ReceptRealizacija();
                    r.idLekara=rrzl.lekarIdd;
                    r.kolicinaLeka=rrzl.kolocinaLeka;
                    r.oblikPakovanja=rrzl.oblikPakovanje;
                    r.tip=rrzl.tip;
                    r.datumIzdavanja = rrzl.datIzda;
                    r.datumRealizacije = rrzl.datRealizacija;
                    r.lek = l;
                    r.farmaceut = fp;
                    r.prodajnoMesto = prMe;
                    MessageBox.Show("Lek je izdat");
                    try { DTOManager.ReceptRealizuje(r); }
                    catch (Exception eee) { MessageBox.Show(eee.Message); }

                    try { DTOManager.updateKolicinuLeka(prMe, l, r.kolicinaLeka); }
                    catch (Exception eee) { MessageBox.Show(eee.Message); }
                    prikaziLekove();

                    //prikaziLekove();
                }
                //MessageBox.Show("Lek se izdaje na recept");
            }


        }

        private LekPregled vratiLek(string s)
        {
            foreach(LekPregled l in lekovi)
            {
                if (l.naziv.Equals(s))
                    return l;
            }
            return null;
        }
    }
}
