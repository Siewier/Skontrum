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
            int iloscNaPolkach = KatalogKsiazek.PoliczNaPolkach();
            int iloscWypozyczonych = KatalogKsiazek.PoliczWypozyczone();
            int iloscUbytkow = KatalogKsiazek.PoliczUbytki();
            //label8
            label8.Text = iloscKsiazek.ToString();
            //label9
            label9.Text = iloscNaPolkach.ToString();
            //label10
            label10.Text = iloscWypozyczonych.ToString();
            //label11
            label11.Text = iloscUbytkow.ToString();
            //label12 i 13
            if (iloscKsiazek > 0) 
            {
                label12.Text = Zmienne.tabela.Rows[0][0].ToString();
                label13.Text = Zmienne.tabela.Rows[iloscKsiazek - 1][0].ToString();
            }
            else
            {
                label12.Text = "0";
                label13.Text = "0";
            }
            //label14
            //int iloscBrakujacych =  int.Parse(Zmienne.tabela.Rows[iloscKsiazek - 1][0].ToString()) - iloscKsiazek;
            //label14.Text = iloscBrakujacych.ToString();
            KatalogKsiazek.SzukajBrakujacych();
            label14.Text = Zmienne.tabelaBraki.Rows.Count.ToString();

        }

        private void btnWyswietlBrakujace_Click(object sender, EventArgs e)
        {
            //wyswietlanie brakujacych wpisow
            //MessageBox.Show("Czeka na zaimplemontowanie...");
            FormBrakujace formB = new FormBrakujace();
            formB.ShowDialog();
            this.Close();
        }
    }
}
