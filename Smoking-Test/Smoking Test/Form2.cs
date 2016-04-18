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
    public partial class Form2 : Form
    {
        public class prasanja
        {
            public int odgovor1 { get; set; }
            public int odgovor2 { get; set; }
            public int odgovor3 { get; set; }
            public int odgovor4 { get; set; }
            public int prasanje1 { get; set; }
            public prasanja ()
            {
                
            }
            public prasanja (int a, int b, int c, int d, int e)
            {
                odgovor1 = a;
                odgovor2 = b;
                odgovor3 = c;
                odgovor4 = d;
                prasanje1 = e;
            }
        }
        prasanja prasanje = new prasanja (0, 0, 0, 0, -1);
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 forma3 = new Form3();
            if (prasanje.prasanje1==-1)
                MessageBox.Show(
                "Не можете да преминете на наредното прашање без да го одговорите ова!",
                "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                forma3.start(prasanje.prasanje1);
                this.Visible = false;
                forma3.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            DialogResult rezultat = MessageBox.Show(
                "Дали сте сигурни дека сакате да излезете од апликацијата? Сите пополнувања ќе се избришат!",
                "Излез од апликацијата", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rezultat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((prasanje.odgovor1 % 2) == 0)
                prasanje.prasanje1 = 0;
            else
                prasanje.prasanje1 = -1;
            prasanje.odgovor1++;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if ((prasanje.odgovor2 % 2) == 0)
                prasanje.prasanje1 = 1;
            else
                prasanje.prasanje1 = -1;
            prasanje.odgovor2++;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if ((prasanje.odgovor3 % 2) == 0)
                prasanje.prasanje1 = 2;
            else
                prasanje.prasanje1 = -1;
            prasanje.odgovor3++;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if ((prasanje.odgovor4 % 2) == 0)
                prasanje.prasanje1 = 3;
            else
                prasanje.prasanje1 = -1;
            prasanje.odgovor4++;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
