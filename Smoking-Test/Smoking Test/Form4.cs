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
    public partial class Form4 : Form
    {
        public class prasanja
        {
            public int odgovor1 { get; set; }
            public int odgovor2 { get; set; }
            public int odgovor3 { get; set; }
            public int odgovor4 { get; set; }
            public int prasanje3 { get; set; }
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
                prasanje3 = e;
                poeni = f;
            }
        }
        prasanja prasanje = new prasanja(0, 0, 0, 0, -1, -1);
        public Form4()
        {
            InitializeComponent();
        }
        public void start (int a)
        {
            prasanje.poeni = a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form5 forma5 = new Form5();
            if (prasanje.prasanje3 == -1)
                MessageBox.Show(
                "Не можете да преминете на наредното прашање без да го одговорите ова!",
                "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                forma5.start(prasanje.prasanje3 + prasanje.poeni);
                this.Visible = false;
                forma5.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show(
                "Дали сте сигурни дека сакате да излезете од апликацијата? Сите пополнувања ќе се избришат!",
                "Излез од апликацијата", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rezultat == DialogResult.Yes)
                Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((prasanje.odgovor1 % 2) == 0)
                prasanje.prasanje3 = 0;
            else
                prasanje.prasanje3 = -1;
            prasanje.odgovor1++;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if ((prasanje.odgovor2 % 2) == 0)
                prasanje.prasanje3 = 1;
            else
                prasanje.prasanje3 = -1;
            prasanje.odgovor2++;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if ((prasanje.odgovor3 % 2) == 0)
                prasanje.prasanje3 = 2;
            else
                prasanje.prasanje3 = -1;
            prasanje.odgovor3++;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if ((prasanje.odgovor4 % 2) == 0)
                prasanje.prasanje3 = 3;
            else
                prasanje.prasanje3 = -1;
            prasanje.odgovor4++;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
