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
