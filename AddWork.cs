using System;
using System.Windows.Forms;

namespace Shool2
{
    public partial class AddWork : UserControl
    {
        public AddWork()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string studentidWork = rand.Next(10000, 99999).ToString();
            string predmetidWork = rand.Next(10000, 99999).ToString();
            Work work1 = new Work( textBox1.Text, studentidWork,predmetidWork);
            //richTextBox1.AppendText(work1.WorkName + " " + Environment.NewLine);
        }
    }
}