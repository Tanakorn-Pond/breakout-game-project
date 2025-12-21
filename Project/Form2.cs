using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {

        // สร้างตัวแปลที่ใช้ใน program
        bool isGameOver;

        public int vSpeed;
        public int hSpeed;
        public int scoreend;
        public int Heartminus;
        public int Heartend;
        public string win;
        public string lose;
        PictureBox[] blockArray;
        public string Username;
        public String playnameTof4;


        public Form2()
        {
            InitializeComponent();

            

            // กำหนดค่าตัวแปลที่ใช้ใน program
            hSpeed = 5;
            vSpeed = 5;
            scoreend = 0;
            Heartminus = 1;
            Heartend = 0;
        }

        // Method สำหรับทำให้เกมเล่นต่อและกำหนดให้ข้อความใน label2 ไม่แสดง
        private void gamePlay()
        {
            timer1.Start();
        }

        // Method สำหรับทำให้เกมหยุด
        private void gameOver()
        {
            isGameOver = true;
            timer1.Stop();
            label3.Visible = true;
            label2.Visible = false;
            label5.Visible = true;
        }

        // Method สำหรับทำให้เกมหยุดและแสดงข้อความใน label2
        private void gamePause()
        {
            timer1.Stop();
            label2.Visible = true;
        }

        // เป้น Method ที่ใช้สร้าง PictureBox
        private void SetupBlock()
        {
            // สร้าง blockArray ที่เป็น PictureBox จำนวน 104 block
            blockArray = new PictureBox[104];

            // กำหนดจำนวนแถวและคอลัมน์ของบล็อก
            int rows = 8;
            int cols = 13;

            // กำหนดตำแหน่งเริ่มต้นของบล็อก
            int x = 12;
            int y = 70;

            // ใช้ loop for เพื่อกำหนดค่าของบล็อกใน array
            for (int i = 0; i < blockArray.Length; i++)
            {
                blockArray[i] = new PictureBox();
                blockArray[i].Height = 26;
                blockArray[i].Width = 75;
                blockArray[i].Tag = "Blocks";
                blockArray[i].BackColor = Color.White;
                blockArray[i].Location = new Point(x, y);
                blockArray[i].BorderStyle = BorderStyle.FixedSingle;

                // เพิ่ม blockArray เข้าไปใน Form
                this.Controls.Add(blockArray[i]);

                // ปรับค่า x เพื่อไปยังตำแหน่งของบล็อกถัดไป
                x += blockArray[i].Width;

                // ตรวจสอบว่าเป็นบล็อกที่สุดท้ายของแถวหรือไม่
                if ((i + 1) % cols == 0)
                {
                    // ถ้าเป็นบล็อกที่สุดท้ายของแถว ให้กำหนด x เพื่อเริ่มต้นบล็อกในแถวใหม่
                    x = 12;

                    // ปรับค่า y เพื่อขยับไปยังบรรทัดถัดไป
                    y += blockArray[i].Height;
                }
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            // เป็นการเพิ่มค่าความเร็วให้กับบอล
            picCircle.Top += vSpeed;
            picCircle.Left += hSpeed;

            // ถ้าบอลชนขอบบนบอลจะเด้งกลับ
            if (picCircle.Top < 0)
            {
                vSpeed = -vSpeed;
            }

            // ถ้าบอลชนขอบขวาบอลจะเด้งกลับ
            if (picCircle.Right > this.ClientSize.Width)
            {
                hSpeed = -hSpeed;
            }

            // ถ้าบอลชนขอบซ้ายบอลจะเด้งกลับ
            if (picCircle.Left < 0)
            {
                hSpeed = -hSpeed;
            }

            // ถ้าบอลชนแถบของผู้เล่นบอลจะเด้งกลับ
            if (picCircle.Bounds.IntersectsWith(picplayer.Bounds) == true)
            {
                vSpeed = -vSpeed;
            }

            

            //

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Blocks")
                {
                    if (picCircle.Bounds.IntersectsWith(x.Bounds))
                    {
                        scoreend += 1;
                        vSpeed = -vSpeed;
                        
                        score.Text = scoreend.ToString();

                        this.Controls.Remove(x);
                    }
                }
            }

            int Heart = Convert.ToInt32(heart.Text);

            // ถ้าบอลร่วงลงไปด้านล่างจะเรียกใช้ Method gamePause() และทำให้บอลกลับไปตำแหน่งเริ่มเกม
            // ถ้า score มีค่าเท่ากับ 104 จะเรียกใช้ Method  gameOver()
            if (picCircle.Top > this.ClientSize.Height)
            {
                Heartend = Heart - Heartminus;
                heart.Text = Heartend.ToString();
                picCircle.Location = new Point(470, 324);
                gamePause();
            }

            // ถ้าชีวิตหมดแล้วเรียกใช้ Method gameOver()
            if (heart.Text == "0")
            {
                gameOver();
            }

            // ถ้า score = 104 เรียกใช้ Method gameOver()
            if (score.Text == "104")
            {
                gameOver();
            }
        }

        private void ResetGame()
        {
            score.Text = "0";
            heart.Text = "3";
            scoreend = 0;
            picCircle.Top += vSpeed;
            picCircle.Left += hSpeed;
            picCircle.Location = new Point(470, 324);

            ClearBlocks();
            SetupBlock();
        }

        private void ClearBlocks()
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control x = this.Controls[i];
                if (x is PictureBox && (string)x.Tag == "Blocks")
                {
                    this.Controls.RemoveAt(i);
                }
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            picplayer.Left = e.X;
        }

        // กำหนด object ต่างๆ ของ Form หลัก
        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            Reset.Visible = false;
            picGoGameControl.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            gamePlay();
            label2.Visible = false;
            Reset.Visible = false;
            picGoGameControl.Visible = false;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            
        }

        private void Chose_mode(object sender, EventArgs e)
        {
            Reset.Visible = true;
            picGoGameControl.Visible = true;
            gamePause();
        }

        private void GoControl(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();          
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            
        }

        // กำหนด object ต่างๆ ของ Form หลัก
        private void Form2_Load_2(object sender, EventArgs e)
        {
            label3.Visible = false;
            label2.Visible = false;
            label5.Visible = false;
            Reset.Visible = false;
            picGoGameControl.Visible = false;
            SetupBlock();

            PLayerName.Text = Username;
            PLayerName.Text = playnameTof4;

        }

        // Method นี้เป็นการเรียก Form4 และส่งข้อมูลข้าม Form และเรียก Form4 ขึ้นมา
        private void GOscore(object sender, EventArgs e)
        {
            if (score.Text == "104")
            {
                win = "You Win";
            }
            else if (score.Text != "104")
            {
                win = "You Lose";
            }

            Form4 f4 = new Form4();
            f4.scoreToFrom = scoreend;
            f4.status = win;
            f4.usernameplayer = PLayerName.Text;
            f4.ShowDialog(); 
            
            
        }

        // Reset บล๊อกใหม่
        // เรียกใช้ Method ResetGame()
        private void Reset_Click(object sender, EventArgs e)
        {
            ResetGame();          
        }
    }
}
