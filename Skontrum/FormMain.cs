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
            formNS.Show();
        }

        private void btnZPolki_Click(object sender, EventArgs e)
        {
            FormKsiazkaZPolki formKZP = new FormKsiazkaZPolki();
            formKZP.Show();
        }

        private void btnWypozyczone_Click(object sender, EventArgs e)
        {
            FormKsiazkaWypozyczona formKW = new FormKsiazkaWypozyczona();
            formKW.Show();
        }

        private void btnUbytki_Click(object sender, EventArgs e)
        {
            FormUbytek formU = new FormUbytek();
            formU.Show();
        }

        private void btnPodsumowanie_Click(object sender, EventArgs e)
        {
            FormPodsumowanie formPod = new FormPodsumowanie();
            formPod.Show();
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            FormTabela formT = new FormTabela();
            formT.Show();
        }
    }
}
