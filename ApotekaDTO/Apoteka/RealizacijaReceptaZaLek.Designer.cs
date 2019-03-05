namespace Apoteka
{
    partial class RealizacijaReceptaZaLek
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblLek = new System.Windows.Forms.Label();
            this.cmbxOblikPakovanja = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbLekarID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTipRecepta = new System.Windows.Forms.TextBox();
            this.txbKolicinaLeka = new System.Windows.Forms.TextBox();
            this.btnIzdajRecept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recept";
            // 
            // lblLek
            // 
            this.lblLek.AutoSize = true;
            this.lblLek.Location = new System.Drawing.Point(12, 32);
            this.lblLek.Name = "lblLek";
            this.lblLek.Size = new System.Drawing.Size(25, 13);
            this.lblLek.TabIndex = 1;
            this.lblLek.Text = "Lek";
            // 
            // cmbxOblikPakovanja
            // 
            this.cmbxOblikPakovanja.FormattingEnabled = true;
            this.cmbxOblikPakovanja.Items.AddRange(new object[] {
            "TABLETA",
            "SIRUP",
            "PRASAK",
            "INEKCIJA"});
            this.cmbxOblikPakovanja.Location = new System.Drawing.Point(105, 67);
            this.cmbxOblikPakovanja.Name = "cmbxOblikPakovanja";
            this.cmbxOblikPakovanja.Size = new System.Drawing.Size(121, 21);
            this.cmbxOblikPakovanja.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Oblik pakovanja";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datum Izdavanja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lekar ID";
            // 
            // txbLekarID
            // 
            this.txbLekarID.Location = new System.Drawing.Point(105, 170);
            this.txbLekarID.Name = "txbLekarID";
            this.txbLekarID.Size = new System.Drawing.Size(100, 20);
            this.txbLekarID.TabIndex = 7;
            this.txbLekarID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLekarID_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tip recepta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kolicina leka";
            // 
            // txbTipRecepta
            // 
            this.txbTipRecepta.Location = new System.Drawing.Point(105, 218);
            this.txbTipRecepta.Name = "txbTipRecepta";
            this.txbTipRecepta.Size = new System.Drawing.Size(100, 20);
            this.txbTipRecepta.TabIndex = 10;
            // 
            // txbKolicinaLeka
            // 
            this.txbKolicinaLeka.Location = new System.Drawing.Point(105, 267);
            this.txbKolicinaLeka.Name = "txbKolicinaLeka";
            this.txbKolicinaLeka.Size = new System.Drawing.Size(100, 20);
            this.txbKolicinaLeka.TabIndex = 11;
            this.txbKolicinaLeka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbKolicinaLeka_KeyPress);
            // 
            // btnIzdajRecept
            // 
            this.btnIzdajRecept.Location = new System.Drawing.Point(105, 311);
            this.btnIzdajRecept.Name = "btnIzdajRecept";
            this.btnIzdajRecept.Size = new System.Drawing.Size(75, 23);
            this.btnIzdajRecept.TabIndex = 12;
            this.btnIzdajRecept.Text = "Izdaj Recept";
            this.btnIzdajRecept.UseVisualStyleBackColor = true;
            this.btnIzdajRecept.Click += new System.EventHandler(this.btnIzdajRecept_Click);
            // 
            // RealizacijaReceptaZaLek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 346);
            this.Controls.Add(this.btnIzdajRecept);
            this.Controls.Add(this.txbKolicinaLeka);
            this.Controls.Add(this.txbTipRecepta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbLekarID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbxOblikPakovanja);
            this.Controls.Add(this.lblLek);
            this.Controls.Add(this.label1);
            this.Name = "RealizacijaReceptaZaLek";
            this.Text = "RealizacijaReceptaZaLek";
            this.Load += new System.EventHandler(this.RealizacijaReceptaZaLek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLek;
        private System.Windows.Forms.ComboBox cmbxOblikPakovanja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbLekarID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTipRecepta;
        private System.Windows.Forms.TextBox txbKolicinaLeka;
        private System.Windows.Forms.Button btnIzdajRecept;
    }
}