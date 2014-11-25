using ClosedXML.Excel;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnNoweSkontrum_Click(object sender, EventArgs e)
        {
            FormNoweSkontrum formNS = new FormNoweSkontrum();
            
            formNS.ShowDialog();
            

            SkontrumZaladowane();
        }

        private void SkontrumZaladowane()
        {
            btnWczytajSkontrum.Enabled = false;
            btnNoweSkontrum.Enabled = false;
            btnZPolki.Enabled = true;
            btnWypozyczone.Enabled = true;
            btnUbytki.Enabled = true;
            btnPodsumowanie.Enabled = true;
            btnTabela.Enabled = true;
            btnZapisz.Enabled = true;
            btnDrukuj.Enabled = true;
            btnEksportuj.Enabled = true;
        }

        private void btnZPolki_Click(object sender, EventArgs e)
        {
            FormKsiazkaZPolki formKZP = new FormKsiazkaZPolki();
            formKZP.ShowDialog();
            
        }

        private void btnWypozyczone_Click(object sender, EventArgs e)
        {
            FormKsiazkaWypozyczona formKW = new FormKsiazkaWypozyczona();
            formKW.ShowDialog();

            SkontrumZaladowane();
        }

        private void btnUbytki_Click(object sender, EventArgs e)
        {
            FormUbytek formU = new FormUbytek();
            formU.ShowDialog();
        }

        private void btnPodsumowanie_Click(object sender, EventArgs e)
        {
            FormPodsumowanie formPod = new FormPodsumowanie();
            formPod.ShowDialog();
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            FormTabela formT = new FormTabela();
            formT.ShowDialog();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            KatalogKsiazek.ZapiszXML(Zmienne.plik);
            MessageBox.Show("Zapisano w: " + Zmienne.plik);
        }

        private void btnEksportuj_Click(object sender, EventArgs e)
        {
            KatalogKsiazek.ZapiszDoExcela();
        }

        private void btnWczytajSkontrum_Click(object sender, EventArgs e)
        {
            bool efekt = false;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                //string file = openFileDialog1.FileName;
                Zmienne.plik = openFileDialog1.FileName;
                efekt = KatalogKsiazek.WczytajXML(Zmienne.plik);
            }
            else
            {
                MessageBox.Show(result.ToString());
            }
            if (efekt == true)
            {
                SkontrumZaladowane();
                MessageBox.Show("Skontrum załadowane!");
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Zmienne.zapisane == false && Zmienne.wczytane == true)
            {
                DialogResult dialogResult = MessageBox.Show("Skontrum nie zostało zapisane po wprowadzeniu ostatnich zmian. Zapisać je przed wyjściem?", "Czy zapisać skontrum?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    KatalogKsiazek.ZapiszXML(Zmienne.plik);
                }
                //else if (dialogResult == DialogResult.No)
                //{
                //    //do something else
                //}
            }
        }

        private void btnDrukuj_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Kiedyś będzie działało ;)");
            FormDrukuj drukuj = new FormDrukuj();
            drukuj.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Zmienne.tabelaBraki.TableName = "Ksiazki";
            Zmienne.tabelaBraki.Columns.Add("nrInw", typeof(int));
            Zmienne.tabelaBraki.Columns.Add("stan", typeof(string));
            Zmienne.tabelaBraki.Columns.Add("miejsce", typeof(string));
            Zmienne.tabelaBraki.AcceptChanges();
        }
    }
}
