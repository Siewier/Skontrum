using System;
using System.Windows.Forms;

namespace Skontrum
{
    public partial class FormTabela : Form
    {
        public FormTabela()
        {

            InitializeComponent();

        }

        private void FormTabela_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Zmienne.tabela;
        }
    }
}
