namespace Apoteka
{
    partial class LekoviPregledForma
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
            this.lblProdajnoMesto = new System.Windows.Forms.Label();
            this.lblFarmaceut = new System.Windows.Forms.Label();
            this.dgvLek = new System.Windows.Forms.DataGridView();
            this.btnProdajaLeka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLek)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdajnoMesto
            // 
            this.lblProdajnoMesto.AutoSize = true;
            this.lblProdajnoMesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdajnoMesto.Location = new System.Drawing.Point(96, 9);
            this.lblProdajnoMesto.Name = "lblProdajnoMesto";
            this.lblProdajnoMesto.Size = new System.Drawing.Size(137, 24);
            this.lblProdajnoMesto.TabIndex = 0;
            this.lblProdajnoMesto.Text = "ProdajnoMesto";
            // 
            // lblFarmaceut
            // 
            this.lblFarmaceut.AutoSize = true;
            this.lblFarmaceut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarmaceut.Location = new System.Drawing.Point(96, 50);
            this.lblFarmaceut.Name = "lblFarmaceut";
            this.lblFarmaceut.Size = new System.Drawing.Size(86, 20);
            this.lblFarmaceut.TabIndex = 1;
            this.lblFarmaceut.Text = "Farmaceut";
            // 
            // dgvLek
            // 
            this.dgvLek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLek.Location = new System.Drawing.Point(12, 103);
            this.dgvLek.Name = "dgvLek";
            this.dgvLek.Size = new System.Drawing.Size(504, 150);
            this.dgvLek.TabIndex = 2;
            // 
            // btnProdajaLeka
            // 
            this.btnProdajaLeka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdajaLeka.Location = new System.Drawing.Point(159, 292);
            this.btnProdajaLeka.Name = "btnProdajaLeka";
            this.btnProdajaLeka.Size = new System.Drawing.Size(180, 38);
            this.btnProdajaLeka.TabIndex = 3;
            this.btnProdajaLeka.Text = "Izdavanje Leka";
            this.btnProdajaLeka.UseVisualStyleBackColor = true;
            this.btnProdajaLeka.Click += new System.EventHandler(this.btnProdajaLeka_Click);
            // 
            // LekoviPregledForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 342);
            this.Controls.Add(this.btnProdajaLeka);
            this.Controls.Add(this.dgvLek);
            this.Controls.Add(this.lblFarmaceut);
            this.Controls.Add(this.lblProdajnoMesto);
            this.Name = "LekoviPregledForma";
            this.Text = "LekoviPregledForma";
            this.Load += new System.EventHandler(this.LekoviPregledForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdajnoMesto;
        private System.Windows.Forms.Label lblFarmaceut;
        private System.Windows.Forms.DataGridView dgvLek;
        private System.Windows.Forms.Button btnProdajaLeka;
    }
}