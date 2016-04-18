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
    public partial class Form5 : Form
    {
        public class prasanja
        {
            public int odgovor1 { get; set; }
            public int odgovor2 { get; set; }
            public int odgovor3 { get; set; }
            public int odgovor4 { get; set; }
            public int prasanje4 { get; set; }
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
                prasanje4 = e;
                poeni = f;
            }
        }
        prasanja prasanje = new prasanja(0, 0, 0, 0, -1, -1);
        public Form5()
        {
            InitializeComponent();
        }
        public void start(int a)
        {
            prasanje.poeni = a;
        }
        private void Form5_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 forma6 = new Form6();
            if (prasanje.prasanje4 == -1)
                MessageBox.Show(
                "Не можете да преминете на наредното прашање без да го одговорите ова!",
                "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                forma6.start(prasanje.prasanje4 + prasanje.poeni);
                this.Visible = false;
                forma6.Show();
            }
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            if ((prasanje.odgovor1 % 2) == 0)
                prasanje.prasanje4 = 0;
            else
                prasanje.prasanje4 = -1;
            prasanje.odgovor1++;
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            if ((prasanje.odgovor2 % 2) == 0)
                prasanje.prasanje4 = 1;
            else
                prasanje.prasanje4 = -1;
            prasanje.odgovor2++;
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            if ((prasanje.odgovor3 % 2) == 0)
                prasanje.prasanje4 = 2;
            else
                prasanje.prasanje4 = -1;
            prasanje.odgovor3++;
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if ((prasanje.odgovor4 % 2) == 0)
                prasanje.prasanje4 = 3;
            else
                prasanje.prasanje4 = -1;
            prasanje.odgovor4++;
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
