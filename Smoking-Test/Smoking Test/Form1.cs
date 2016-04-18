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
    public partial class Form1 : Form
    {
        public class Prasanja
        {
            public int prasanje1 { get; set; }
            public int prasanje2 { get; set; }
            public int prasanje3 { get; set; }
            public int prasanje4 { get; set; }
            public int prasanje5 { get; set; }
            public int prasanje6 { get; set; }
            public int[] odgovori { get; set; } = new int[24];
            public Prasanja()
            {

            }
            public Prasanja(int a, int b, int c, int d, int e, int f)
            {
                prasanje1 = a;
                prasanje2 = b;
                prasanje3 = c;
                prasanje4 = d;
                prasanje5 = e;
                prasanje6 = f;
            }
        }
        public Prasanja prasanja;
        public Form1()
        {
            InitializeComponent();
            button1.Select();
            prasanja = new Prasanja (0, 0, 0, 0, 0, 0);
            for (int i=0; i<24; i++)
            {
                prasanja.odgovori[i] = 0;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form9 forma9 = new Form9();
            this.Visible = false;
            forma9.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show(
                "Дали сте сигурни дека сакате да излезете од апликацијата?",
                "Излез од апликацијата", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rezultat == DialogResult.Yes)
                Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
