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
    public partial class FormNoweSkontrum : Form
    {
        public FormNoweSkontrum()
        {
            InitializeComponent();
        }

        private void btnAnulujNoweSkontrum_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapiszNoweSkontrum_Click(object sender, EventArgs e)
        {
            bool rezultatParse = int.TryParse(tbMaxNumer.Text,out Zmienne.maxNumInw);
            if (rezultatParse == false)
            {
                //wyswietl okienko z bledem
                MessageBox.Show("Ostatni numer inwentarzowy wprowadzony niepoprawnie!");
            }
            else
            {
                Zmienne.plik += this.tbNoweSkontrum.Text.ToString();
                Zmienne.plik += ".xml";
                bool rezultat = KatalogKsiazek.NoweSkontrum(Zmienne.plik);
                if (rezultat == false)
                {
                    //wyswietl okienko z bledem
                    MessageBox.Show("Nie udało się utworzyć pliku! Ścieżka: " + Zmienne.plik);
                }
            }
            this.Close();
        }
    }
}
