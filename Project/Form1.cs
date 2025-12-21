using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public string namepr;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Username = NamePlayer.Text;
            f2.ShowDialog();

            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Choose_mode(object sender, EventArgs e)
        {
            labelTest.Visible = true;
            labelNormal.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelTest.Visible = false;
            labelNormal.Visible = true;      

        }

        private void Chose_mode2(object sender, EventArgs e)
        {
            labelTest.Visible = false;
            labelNormal.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
