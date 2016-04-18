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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 12;
            numericUpDown1.Maximum = 150;
        }

        private void button1_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void numericUpDown1_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDown1.Value<18)
            {
                e.Cancel = false;
                errorProvider1.SetError(numericUpDown1, "Не смеете да го пополнувате тестот и да пушите ако сте помлади од 18 години! Ве молиме притиснете на Откажи!");
            }
            else
            {
                errorProvider1.SetError(numericUpDown1, null);
            }
        }

        private void otkazi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value >= 18)
            {
                this.Visible = false;
                Form2 forma = new Form2();
                forma.Show();
            }  
        }
    }
}
