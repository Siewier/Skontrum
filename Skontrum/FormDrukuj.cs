using DGVPrinterHelper;
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
    public partial class FormDrukuj : Form
    {
        public FormDrukuj()
        {
            InitializeComponent();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDrukuj_Load(object sender, EventArgs e)
        {
            KatalogKsiazek.PosortujKsiazki();
            KatalogKsiazek.SzukajBrakujacych();
            dataGridView1.DataSource = Zmienne.tabela;

            string braki = Zmienne.tabelaBraki.Rows.Count.ToString();
            label5.Text = braki;
        }

        private void btnDrukuj_Click(object sender, EventArgs e)
        {
            string nazwaSzkoly = tbSzkola.Text;
            string bibliotekarz = tbBibliotekarz.Text;
            string data = dateTimePicker1.Value.ToShortDateString();
            
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Skontrum";

            printer.SubTitle ="Szkoła: " + nazwaSzkoly + " Data: " + data;

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.NoClip;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = true;

            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = "Wykonane przez: " + bibliotekarz;

            printer.FooterSpacing = 15;



            printer.PrintDataGridView(dataGridView1);
        }
    }
}
