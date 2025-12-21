using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form4 : Form
    {
        public int scoreToFrom;
        public string status;
        public string usernameplayer;
        public Form4()
        {
            InitializeComponent();
            scoreToFrom = scoreToFrom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.playnameTof4 = usernameplayer;
            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Lose.Visible = false;
            Win.Visible = false;

            textBox1.Text = usernameplayer + "          " + scoreToFrom.ToString();
            Lose.Text = status;

            if(status == "You Win")
            {
                Win.Visible = true;
            }
            else if (status == "You Lose")
            {
                Lose.Visible = true;
            }
        }
    }
}
