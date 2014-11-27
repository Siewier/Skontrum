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
    public partial class FormBrakujace : Form
    {
        public FormBrakujace()
        {
            InitializeComponent();
        }

        private void FormBrakujace_Load(object sender, EventArgs e)
        {
            KatalogKsiazek.SzukajBrakujacych();
            dataGridView1.DataSource = Zmienne.tabelaBraki;
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnUbytki_Click(object sender, EventArgs e)
        //{
        //    KatalogKsiazek.OznaczJakoBrakujace();
        //    this.Close();
        //}
    }
}
