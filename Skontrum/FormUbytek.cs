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
            DodajUbytek();
            this.Close();
        }

        private void DodajUbytek()
        {
            if (rbPoj.Checked == true)
            {
                bool rezultat = KatalogKsiazek.DodajKsiazke(int.Parse(textBox1.Text), "ubytek", textBox2.Text);
                if (rezultat == false)
                {
                    MessageBox.Show("Już istnieje książka z tym numerem inwentażowym!");
                }
            }
            else
            {
                int numerPoczatkowy = int.Parse(textBox3.Text);
                int numerKoncowy = int.Parse(textBox4.Text);
                do
                {
                    bool rezultat = KatalogKsiazek.DodajKsiazke(numerPoczatkowy, "ubytek", textBox2.Text);
                    if (rezultat == false)
                    {
                        MessageBox.Show("Już istnieje książka o numerze: " + numerPoczatkowy.ToString() + "!");
                    }
                    numerPoczatkowy++;
                } while (numerPoczatkowy < numerKoncowy);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajUbytek();
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox2.Text != "")
            {
                KatalogKsiazek.DodajKsiazke(int.Parse(textBox1.Text), "ubytek", textBox2.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void rbPoj_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPoj.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
            }
        }
    }
}
