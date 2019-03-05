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
    public partial class ProdajnaMestaIzbor : Form
    {
        public List<ProdajnoMestoPregled> pmp { get; set; }
        public ProdajnaMestaIzbor()
        {
            InitializeComponent();
        }

        private void btnLogIN_Click(object sender, EventArgs e)
        {
            if (dgvProdajnaMestaIzbor.SelectedRows.Count == 0)
                return;
            int selectedRow = dgvProdajnaMestaIzbor.SelectedRows[0].Index;
            int idProdajnogM = (int)dgvProdajnaMestaIzbor["ID", selectedRow].Value;

            /*LogINFarmaceut log = new LogINFarmaceut(idProdajnogM);
            log.ShowDialog();*/
            LogINFarmaceut log = new LogINFarmaceut(pmp.ElementAt(idProdajnogM-1));
            log.ShowDialog();
            //MessageBox.Show(idProdajnogM.ToString()+" "+ idProdajnogM.GetType());
        }

        private void prikazProdajnihMesta()
        {
            pmp = DTOManager.prodajnaMePregled();
            dgvProdajnaMestaIzbor.DataSource = pmp;
            dgvProdajnaMestaIzbor.AutoResizeColumn(1);
            dgvProdajnaMestaIzbor.AutoResizeColumn(2);


        }

        private void ProdajnaMestaIzbor_Load(object sender, EventArgs e)
        {
            prikazProdajnihMesta();
        }
    }
}
