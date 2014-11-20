using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skontrum
{
    public partial class FormPodsumowanie : Form
    {
        public FormPodsumowanie()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPodsumowanie_Load(object sender, EventArgs e)
        {
            KatalogKsiazek.PosortujKsiazki();
            int iloscKsiazek = KatalogKsiazek.PoliczKsiazki();
            //label8
            label8.Text = iloscKsiazek.ToString();
            //label9
            //label10
            //label11
            //label12
            label12.Text = Zmienne.tabela.Rows[0][0].ToString();
            //label13
            label13.Text = Zmienne.tabela.Rows[iloscKsiazek - 1][0].ToString();
            //label14

        }

        private void btnWyswietlBrakujace_Click(object sender, EventArgs e)
        {
            //wyswietlanie brakujacych wpisow
            MessageBox.Show("Czeka na zaimplemontowanie...");
        }
    }
}
