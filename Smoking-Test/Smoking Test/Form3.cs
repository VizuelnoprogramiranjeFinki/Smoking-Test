using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smoking_Test
{
    public partial class Form3 : Form
    {
        public class prasanja
        {
            public int odgovor1 { get; set; }
            public int odgovor2 { get; set; }
            public int odgovor3 { get; set; }
            public int odgovor4 { get; set; }
            public int prasanje2 { get; set; }
            public int poeni { get; set; }
            public prasanja()
            {

            }
            public prasanja(int a, int b, int c, int d, int e, int f)
            {
                odgovor1 = a;
                odgovor2 = b;
                odgovor3 = c;
                odgovor4 = d;
                prasanje2 = e;
                poeni = f;
            }
        }
        prasanja prasanje = new prasanja(0, 0, 0, 0, -1, -1);
        public Form3()
        {
            InitializeComponent();
        }
        public void start (int a)
        {
            prasanje.poeni = a;
        } 
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 forma4 = new Form4();
            if (prasanje.prasanje2 == -1)
                MessageBox.Show(
                "Не можете да преминете на наредното прашање без да го одговорите ова!",
                "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                forma4.start(prasanje.prasanje2 + prasanje.poeni);
                this.Visible = false;
                forma4.Show();
            }
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((prasanje.odgovor1 % 2) == 0)
                prasanje.prasanje2 = 0;
            else
                prasanje.prasanje2 = -1;
            prasanje.odgovor1++;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if ((prasanje.odgovor2 % 2) == 0)
                prasanje.prasanje2 = 1;
            else
                prasanje.prasanje2 = -1;
            prasanje.odgovor2++;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if ((prasanje.odgovor3 % 2) == 0)
                prasanje.prasanje2 = 2;
            else
                prasanje.prasanje2 = -1;
            prasanje.odgovor3++;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if ((prasanje.odgovor4 % 2) == 0)
                prasanje.prasanje2 = 3;
            else
                prasanje.prasanje2 = -1;
            prasanje.odgovor4++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show(
                "Дали сте сигурни дека сакате да излезете од апликацијата? Сите пополнувања ќе се избришат!",
                "Излез од апликацијата", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rezultat == DialogResult.Yes)
                Application.Exit();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
