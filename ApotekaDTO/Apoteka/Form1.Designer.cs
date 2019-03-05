namespace Apoteka
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnManyToMany = new System.Windows.Forms.Button();
            this.zaposleniRecepti = new System.Windows.Forms.Button();
            this.btncreateFarmaceut = new System.Windows.Forms.Button();
            this.btnManyToOne = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnDTO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Indi_KontraIndi_NezEfekti_Leka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManyToMany
            // 
            this.btnManyToMany.Location = new System.Drawing.Point(29, 55);
            this.btnManyToMany.Name = "btnManyToMany";
            this.btnManyToMany.Size = new System.Drawing.Size(218, 23);
            this.btnManyToMany.TabIndex = 1;
            this.btnManyToMany.Text = "ManyToMany";
            this.btnManyToMany.UseVisualStyleBackColor = true;
            this.btnManyToMany.Click += new System.EventHandler(this.btnManyToMany_Click);
            // 
            // zaposleniRecepti
            // 
            this.zaposleniRecepti.Location = new System.Drawing.Point(29, 113);
            this.zaposleniRecepti.Name = "zaposleniRecepti";
            this.zaposleniRecepti.Size = new System.Drawing.Size(218, 23);
            this.zaposleniRecepti.TabIndex = 2;
            this.zaposleniRecepti.Text = "One-to-Many (Zaposleni-recepti)";
            this.zaposleniRecepti.UseVisualStyleBackColor = true;
            this.zaposleniRecepti.Click += new System.EventHandler(this.zaposleniRecepti_Click);
            // 
            // btncreateFarmaceut
            // 
            this.btncreateFarmaceut.Location = new System.Drawing.Point(29, 142);
            this.btncreateFarmaceut.Name = "btncreateFarmaceut";
            this.btncreateFarmaceut.Size = new System.Drawing.Size(218, 23);
            this.btncreateFarmaceut.TabIndex = 3;
            this.btncreateFarmaceut.Text = "createFarmaceut";
            this.btncreateFarmaceut.UseVisualStyleBackColor = true;
            this.btncreateFarmaceut.Click += new System.EventHandler(this.btncreateFarmaceut_Click);
            // 
            // btnManyToOne
            // 
            this.btnManyToOne.Location = new System.Drawing.Point(29, 84);
            this.btnManyToOne.Name = "btnManyToOne";
            this.btnManyToOne.Size = new System.Drawing.Size(218, 23);
            this.btnManyToOne.TabIndex = 4;
            this.btnManyToOne.Text = "ManyToOne(Zaposleni-ProdajnoMesto)";
            this.btnManyToOne.UseVisualStyleBackColor = true;
            this.btnManyToOne.Click += new System.EventHandler(this.btnManyToOne_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "TablePerClassInheritance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "create sub class Antipiretik";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "createProdaje";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(29, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(218, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "noviRecept";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(29, 259);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(218, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "newIND_KIND_NEFEKAT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnDTO
            // 
            this.btnDTO.Location = new System.Drawing.Point(96, 317);
            this.btnDTO.Name = "btnDTO";
            this.btnDTO.Size = new System.Drawing.Size(75, 23);
            this.btnDTO.TabIndex = 10;
            this.btnDTO.Text = "DTO app";
            this.btnDTO.UseVisualStyleBackColor = true;
            this.btnDTO.Click += new System.EventHandler(this.btnDTO_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 352);
            this.Controls.Add(this.btnDTO);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnManyToOne);
            this.Controls.Add(this.btncreateFarmaceut);
            this.Controls.Add(this.zaposleniRecepti);
            this.Controls.Add(this.btnManyToMany);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnManyToMany;
        private System.Windows.Forms.Button zaposleniRecepti;
        private System.Windows.Forms.Button btncreateFarmaceut;
        private System.Windows.Forms.Button btnManyToOne;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnDTO;
    }
}

