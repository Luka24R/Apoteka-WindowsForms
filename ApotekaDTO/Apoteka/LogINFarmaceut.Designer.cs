namespace Apoteka
{
    partial class LogINFarmaceut
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
            this.tbxID = new System.Windows.Forms.TextBox();
            this.dgvFarmaceuti = new System.Windows.Forms.DataGridView();
            this.btnLogIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmaceuti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uneti ID izabranog farmaceuta";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(79, 235);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(100, 20);
            this.tbxID.TabIndex = 1;
            this.tbxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxID_KeyPress);
            // 
            // dgvFarmaceuti
            // 
            this.dgvFarmaceuti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFarmaceuti.Location = new System.Drawing.Point(12, 12);
            this.dgvFarmaceuti.Name = "dgvFarmaceuti";
            this.dgvFarmaceuti.Size = new System.Drawing.Size(243, 176);
            this.dgvFarmaceuti.TabIndex = 2;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(79, 276);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(100, 23);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // LogINFarmaceut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 311);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.dgvFarmaceuti);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.label1);
            this.Name = "LogINFarmaceut";
            this.Text = "LogINFarmaceut";
            this.Load += new System.EventHandler(this.LogINFarmaceut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmaceuti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.DataGridView dgvFarmaceuti;
        private System.Windows.Forms.Button btnLogIn;
    }
}