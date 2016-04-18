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
    public partial class Form8 : Form
    {
        public void rezultati (int a)
        {
            int b = (100 * a) / 18;
            label1.Text = String.Format("На тестот освоивте " + b + "%!");
            progressBar1.Increment(b);
            if (b<=20)
            {
                label4.Text = "Вие сте АНТИПУШАЧ или МНОГУ МАЛКУ ПУШИТЕ!";
                label3.Text = "Навистина Ви честитаме! Ви советуваме да продолжите и\n" +
                              "понатаму да не пушите, бидејќи со тоа го намалувате\n" +
                              "ризикот од сериозни болести.";
            }
            else if ((b>20)&&(b<=60))
            {
                label4.Text = "Вие пушите, но ВО РАЗУМНИ ГРАНИЦИ!";
                label3.Text = "Доколку не Ви пречат цигарите, можете да продолжите да\n" +
                              "пушите, НО ВО ТИЕ РАЗМЕРИ! Треба да имате силна самоконтрола,\n" +
                              "бидејќи многу е голема веројатноста пушач од Вашиот тип во\n" +
                              "определен животен период исполнет со проблеми да почне да пуши\n" +
                              "во поголема мера. Затоа, внимавајте!";
            }
            else if (b > 60)
            {
                label4.Text = "Вие сте ТЕЖОК ПУШАЧ!";
                label3.Text = "Вие сте зависни од цигарите и нив ги сметате за Ваш најдобар\n" +
                              "пријател. Ве советуваме да се информирате за штетните\n" +
                              "ефекти од цигарите врз здравјето. Обидете се да ги намалите или\n" +
                              "откажете, а доколку не успеете, ИТНО побарајте помош од Вашиот\n" +
                              "матичен лекар! Тој може да Ви помогне да ги намалите или откажете\n" +
                              "цигарите.";
            }
        }
        public Form8()
        {
            InitializeComponent();
            button3.Select();
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show(
                "Дали сте сигурни дека сакате да излезете од апликацијата? Сите пополнувања ќе се избришат!",
                "Излез од апликацијата", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rezultat == DialogResult.Yes)
                Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 forma = new Form1();
            forma.Visible = true;
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
