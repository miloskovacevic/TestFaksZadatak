using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartijeCas
{
    public partial class Form1 : Form
    {
        Partija partija1;
        Vlasnik vlasnik1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesiPartiju_Click(object sender, EventArgs e)
        {
            partija1 = new Partija();

            partija1.BrojPartije = txtBrojPartije.Text;
            partija1.TipPartije = (TipPartije)comboBox1.SelectedIndex;   

            // vlasnik parije, unos

            vlasnik1 = new Vlasnik();

            vlasnik1.Ime = txtIme.Text.ToString();
            vlasnik1.Prezime = txtPrezime.Text.ToString();
            vlasnik1.JMBG = txtJMBG.Text.ToString();
            vlasnik1.Telefon = Convert.ToInt32(txtTelefon.Text.ToString());

            partija1.VlasnikPartije = vlasnik1;

            gbPromene.Enabled = true;
        }



        int i = 1;
        string rez = "";

        private void btnUnesiPromenu_Click(object sender, EventArgs e)
        {
            //int bilans = partija1.Balans;
            if (i < 11)
            {
                int trenutniBilans = partija1.Balans;
                partija1.Balans += Convert.ToInt32(txtIznosPromene.Text);
                
                rez += i.ToString() + "---" + trenutniBilans + "---" + partija1.Balans + "\r\n";
                i++;
                txtIznosPromene.Text = string.Empty;
            }
            else 
            {
                button1.Enabled = true;    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtPrikaziBox.Text = rez;
            this.Size = new Size(650, 580);
        }
    }
}
