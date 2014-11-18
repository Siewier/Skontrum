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
    }
}
