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
    public partial class FormKsiazkaWypozyczona : Form
    {
        public FormKsiazkaWypozyczona()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KatalogKsiazek.DodajKsiazke(int.Parse(textBox1.Text), "wypozyczona", textBox2.Text);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KatalogKsiazek.DodajKsiazke(int.Parse(textBox1.Text), "polka", textBox2.Text);
            textBox1.Text = "";
        }
    }
}
