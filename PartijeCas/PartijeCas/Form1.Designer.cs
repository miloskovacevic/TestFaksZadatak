namespace PartijeCas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojPartije = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnUnesiPartiju = new System.Windows.Forms.Button();
            this.gbPromene = new System.Windows.Forms.GroupBox();
            this.txtIznosPromene = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUnesiPromenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrikaziBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbPromene.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Broj Partije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip partije";
            // 
            // txtBrojPartije
            // 
            this.txtBrojPartije.Location = new System.Drawing.Point(108, 13);
            this.txtBrojPartije.Name = "txtBrojPartije";
            this.txtBrojPartije.Size = new System.Drawing.Size(100, 20);
            this.txtBrojPartije.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tekuci_racun",
            "Dinarska_stednja",
            "Devizna_stednja",
            "Kreditna_stednja"});
            this.comboBox1.Location = new System.Drawing.Point(108, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUnesiPartiju);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtJMBG);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(25, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vlasnik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prezime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "JMBG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefon";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(83, 26);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 5;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(83, 50);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 6;
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(83, 75);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(100, 20);
            this.txtJMBG.TabIndex = 7;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(83, 104);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 8;
            // 
            // btnUnesiPartiju
            // 
            this.btnUnesiPartiju.Location = new System.Drawing.Point(108, 139);
            this.btnUnesiPartiju.Name = "btnUnesiPartiju";
            this.btnUnesiPartiju.Size = new System.Drawing.Size(75, 23);
            this.btnUnesiPartiju.TabIndex = 9;
            this.btnUnesiPartiju.Text = "Unesi partiju";
            this.btnUnesiPartiju.UseVisualStyleBackColor = true;
            this.btnUnesiPartiju.Click += new System.EventHandler(this.btnUnesiPartiju_Click);
            // 
            // gbPromene
            // 
            this.gbPromene.Controls.Add(this.btnUnesiPromenu);
            this.gbPromene.Controls.Add(this.txtIznosPromene);
            this.gbPromene.Controls.Add(this.label7);
            this.gbPromene.Enabled = false;
            this.gbPromene.Location = new System.Drawing.Point(25, 316);
            this.gbPromene.Name = "gbPromene";
            this.gbPromene.Size = new System.Drawing.Size(204, 104);
            this.gbPromene.TabIndex = 5;
            this.gbPromene.TabStop = false;
            this.gbPromene.Text = "Promene";
            // 
            // txtIznosPromene
            // 
            this.txtIznosPromene.Location = new System.Drawing.Point(83, 28);
            this.txtIznosPromene.Name = "txtIznosPromene";
            this.txtIznosPromene.Size = new System.Drawing.Size(100, 20);
            this.txtIznosPromene.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Iznos";
            // 
            // btnUnesiPromenu
            // 
            this.btnUnesiPromenu.Location = new System.Drawing.Point(108, 54);
            this.btnUnesiPromenu.Name = "btnUnesiPromenu";
            this.btnUnesiPromenu.Size = new System.Drawing.Size(75, 23);
            this.btnUnesiPromenu.TabIndex = 10;
            this.btnUnesiPromenu.Text = "Unesi promenu";
            this.btnUnesiPromenu.UseVisualStyleBackColor = true;
            this.btnUnesiPromenu.Click += new System.EventHandler(this.btnUnesiPromenu_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(108, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Prikazi promene >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrikaziBox
            // 
            this.txtPrikaziBox.Location = new System.Drawing.Point(301, 12);
            this.txtPrikaziBox.Multiline = true;
            this.txtPrikaziBox.Name = "txtPrikaziBox";
            this.txtPrikaziBox.Size = new System.Drawing.Size(324, 437);
            this.txtPrikaziBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 468);
            this.Controls.Add(this.txtPrikaziBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbPromene);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtBrojPartije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPromene.ResumeLayout(false);
            this.gbPromene.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojPartije;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUnesiPartiju;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPromene;
        private System.Windows.Forms.Button btnUnesiPromenu;
        private System.Windows.Forms.TextBox txtIznosPromene;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrikaziBox;
    }
}

