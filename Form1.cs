using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shool2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
            textBoxPasword.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(41, 44, 51);
        }
        private void sendText(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(41, 44, 51);
            Usere object1 = new Usere(textBoxName.Text, textBoxSur.Text, textBoxYear.Text, textBoxMonth.Text, textBoxDay.Text, textBoxPasword.Text);
            richTextBox1.AppendText(object1.Name + " " + object1.Sur + " " + object1.Year + "/" + object1.Month + "/" + object1.Day + Environment.NewLine);

        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
           name1.Hide();

        }



        private void textBoxSur_TextChanged(object sender, EventArgs e)
        {
            surename.Hide();
        }

        private void textBoxPasword_TextChanged(object sender, EventArgs e)
        {
            pass.Hide();
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            label4.Hide();
        }

        private void textBoxMonth_TextChanged(object sender, EventArgs e)
        {
            label5.Hide();
        }

        private void textBoxDay_TextChanged(object sender, EventArgs e)
        {
            label6.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
