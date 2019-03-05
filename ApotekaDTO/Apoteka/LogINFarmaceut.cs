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
    public partial class LogINFarmaceut : Form
    {
        public ProdajnoMestoPregled pmestop { get; set; }
        public int IDmesta { get; set; }
        public List<FarmaceutPregled> frm { get; set; }
        public LogINFarmaceut()
        {
            InitializeComponent();
        }

        public LogINFarmaceut(int i)
        {
            InitializeComponent();
            this.IDmesta = i;
        }
        public LogINFarmaceut(ProdajnoMestoPregled p)
        {
            this.pmestop = p;
            InitializeComponent();
        }

        private void tbxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void LogINFarmaceut_Load(object sender, EventArgs e)
        {
            prikazFarmaceuta();
        }

        private void prikazFarmaceuta()
        {
            frm = DTOManager.farmaceutiPregled(pmestop.id);
            dgvFarmaceuti.DataSource = frm;
            dgvFarmaceuti.Columns["id"].Visible = false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (dgvFarmaceuti.SelectedRows.Count == 0)
                return;
            int selectedRow = dgvFarmaceuti.SelectedRows[0].Index;
            int idFRM = (int)dgvFarmaceuti["ID", selectedRow].Value;
            
            if(!(proveraId_a(idFRM)==(Convert.ToInt32(tbxID.Text))) || String.IsNullOrWhiteSpace(tbxID.Text)==true)
            {
                MessageBox.Show("PogresanID");
                return;
            }
            else
            {
                //MessageBox.Show("Prijavlen si");
                FarmaceutPregled ff = vratiPrijavljenogFarmaceuta(idFRM);
                LekoviPregledForma lpf = new LekoviPregledForma(pmestop, ff);
                lpf.ShowDialog();
            }

        }

        private FarmaceutPregled vratiPrijavljenogFarmaceuta(int id)
        {
            foreach (FarmaceutPregled f in frm)
            {
                if (f.id == id)
                    return f;
            }
            return null;
        }
        private int proveraId_a(int id)
        {
            foreach (FarmaceutPregled f in frm)
            {
                if (f.id == id)
                    return f.id;
            }
            return -1;
        }
    }
}
