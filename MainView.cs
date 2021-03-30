using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable 0436

namespace Shool2
{
    public partial class MainView : Form
    {
        private static MainView _instance;

        public static MainView Instance
        {
            get {
                if (_instance == null)
                {
                    _instance = new MainView();
                }

                return _instance;
            }
        }

        public MainView()
        {
            InitializeComponent();
          
            textBoxPasword.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homePage1.Hide();
           // addWork1.Hide();
            this.BackColor = Color.FromArgb(41, 44, 51);
           
        }
        private void sendText(object sender, EventArgs e)
        {
            Random rand = new Random();
            string studentid = rand.Next(10000, 99999).ToString();
            this.BackColor = Color.FromArgb(41, 44, 51);
            User object1 = new User(textBoxName.Text, textBoxSur.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy"), textBoxPasword.Text,studentid);
           // richTextBox1.AppendText(object1.Name + " " + object1.Sur + " " +object1.date+ " "+object1.Studentid + Environment.NewLine);
           homePage1.Show();
           

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            /*DateTime dateD;
            dateD = dateTimePicker1.Value;
            string date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
    */        
        }

        private void homePage1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
