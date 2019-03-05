namespace Apoteka
{
    partial class ProdajnaMestaIzbor
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
            this.btnLogIN = new System.Windows.Forms.Button();
            this.dgvProdajnaMestaIzbor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdajnaMestaIzbor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogIN
            // 
            this.btnLogIN.Location = new System.Drawing.Point(142, 209);
            this.btnLogIN.Name = "btnLogIN";
            this.btnLogIN.Size = new System.Drawing.Size(151, 23);
            this.btnLogIN.TabIndex = 1;
            this.btnLogIN.Text = "LogIN farmaceut";
            this.btnLogIN.UseVisualStyleBackColor = true;
            this.btnLogIN.Click += new System.EventHandler(this.btnLogIN_Click);
            // 
            // dgvProdajnaMestaIzbor
            // 
            this.dgvProdajnaMestaIzbor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProdajnaMestaIzbor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdajnaMestaIzbor.Location = new System.Drawing.Point(13, 13);
            this.dgvProdajnaMestaIzbor.Name = "dgvProdajnaMestaIzbor";
            this.dgvProdajnaMestaIzbor.Size = new System.Drawing.Size(408, 180);
            this.dgvProdajnaMestaIzbor.TabIndex = 2;
            // 
            // ProdajnaMestaIzbor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 263);
            this.Controls.Add(this.dgvProdajnaMestaIzbor);
            this.Controls.Add(this.btnLogIN);
            this.Name = "ProdajnaMestaIzbor";
            this.Text = "ProdajnaMestaIzbor";
            this.Load += new System.EventHandler(this.ProdajnaMestaIzbor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdajnaMestaIzbor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogIN;
        private System.Windows.Forms.DataGridView dgvProdajnaMestaIzbor;
    }
}