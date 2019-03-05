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
    public partial class RealizacijaReceptaZaLek : Form
    {

       

        public LekPregled l { get; set; }
        public ReceptRealizacija r { get; set; }
        public RealizacijaReceptaZaLek()
        {
            InitializeComponent();
        }

        public RealizacijaReceptaZaLek(LekPregled l)
        {
            this.l = l;
            InitializeComponent();
        }

        private void txbLekarID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txbKolicinaLeka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void RealizacijaReceptaZaLek_Load(object sender, EventArgs e)
        {
            lblLek.Text = l.naziv;
            
        }

        private bool validacija()
        {
            if(cmbxOblikPakovanja.SelectedIndex<0)
            {
                MessageBox.Show("Izabrati oblik pakovanja");
                                
                return false;
            }

            if (String.IsNullOrEmpty(txbKolicinaLeka.Text))
            {
                MessageBox.Show("Polje Kolicina ne sme biti prazno.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }
            if (String.IsNullOrEmpty(txbLekarID.Text))
            {
                MessageBox.Show("Polje ID lekara ne sme biti prazno.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }
            if (String.IsNullOrEmpty(txbTipRecepta.Text))
            {
                MessageBox.Show("Polje Kolicina ne sme biti prazno.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnIzdajRecept_Click(object sender, EventArgs e)
        {
            if (!validacija())
                return;
           /* r.datumIzdavanja = DateTime.Now;
            r.datumRealizacije = DateTime.Now;
            r.idLekara = Convert.ToInt32(txbLekarID.Text);
            r.kolicinaLeka = Convert.ToInt32(txbKolicinaLeka.Text);
            r.tip = txbTipRecepta.Text;
            r.oblikPakovanja = cmbxOblikPakovanja.SelectedItem.ToString();*/
            this.Close();
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }

         public string oblikPakovanje { get { return cmbxOblikPakovanja.SelectedItem.ToString(); } }
         public string tip { get { return txbTipRecepta.Text; } }
         public int kolocinaLeka { get { return Convert.ToInt32(txbKolicinaLeka.Text); } }
         public int lekarIdd { get { return Convert.ToInt32(txbKolicinaLeka.Text); } }
         public DateTime datIzda { get { return dateTimePicker1.Value; } }
         public DateTime datRealizacija
         {
             get
             {
                 return DateTime.Now;
                 
             }
         }
    }
}
