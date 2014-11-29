using System;
using System.Windows.Forms;

namespace Skontrum
{
    public partial class FormUbytek : Form
    {
        public FormUbytek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool rezultat = KatalogKsiazek.DodajKsiazke(int.Parse(textBox1.Text), "ubytek", textBox2.Text);
            if (rezultat == false)
            {
                MessageBox.Show("Już istnieje książka z tym numerem inwentażowym!");
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool rezultat = KatalogKsiazek.DodajKsiazke(int.Parse(textBox1.Text), "ubytek", textBox2.Text);
            if (rezultat == false)
            {
                MessageBox.Show("Już istnieje książka z tym numerem inwentażowym!");
            }
            textBox1.Text = "";
            //textBox2.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox2.Text != "")
            {
                KatalogKsiazek.DodajKsiazke(int.Parse(textBox1.Text), "ubytek", textBox2.Text);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
