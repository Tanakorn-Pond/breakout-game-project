using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form3 : Form
    {

        // สร้างตัวแปลที่ใช้ใน program
        public int vSpeed;
        public int hSpeed;
        public int scoreend;
        public int Heartminus;
        public int Heartend;
        public int score;
        public int speed;
        PictureBox[] blockArray;

        public Form3()
        {
            InitializeComponent();

            // กำหนดค่าตัวแปลที่ใช้ใน program
            hSpeed = 5;
            vSpeed = 5;
            scoreend = 0;
            Heartminus = 1;
            Heartend = 0;
            score = 0;
            speed = 1;

        }

        // Method สำหรับทำให้เกมเล่นต่อและกำหนดให้ข้อความใน label2 ไม่แสดง
        private void gamePlay()
        {
            timer1.Start();
            label2.Visible = false;
        }

        // Method สำหรับทำให้เกมหยุด
        private void gameOver()
        {
            timer1.Stop();
        }

        // Method สำหรับทำให้เกมหยุดและแสดงข้อความใน label2
        private void gamePause()
        {
            timer1.Stop();
            label2.Visible = true;

        }

        // Method สำหรับกำหนดค่าต่างๆเกี่ยวกับตัวเกม
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
                        score += 1;
                        vSpeed = -vSpeed;


                        this.Controls.Remove(x);
                    }
                }
            }

            // ถ้าบอลร่วงลงไปด้านล่างจะเรียกใช้ Method gamePause() และทำให้บอลกลับไปตำแหน่งเริ่มเกม
            // ถ้า score มีค่าเท่ากับ 104 จะเรียกใช้ Method  gameOver()
            if (picCircle.Top > this.ClientSize.Height)
            {
                picCircle.Location = new Point(470, 324);                
                gamePause();
                return;
            }
            if (score == 104)
            {
                gameOver();
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        // เป็น Method ที่ทำให้แถบผู้เล่นเลื่อนตามเมาส์
        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            picplayer.Left = e.X;
        }        

        // เป็น Method ที่ถ้ากดที่ Label2 จะทำการเรียกใช้ Method gameOlay()
        private void label2_Click(object sender, EventArgs e)
        {
            gamePlay();         
        }

        //
        private void ResetGame()
        {
            ClearBlocks();
            SetupBlock();
        }

        //
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

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }        

        private void Form3_Load_1(object sender, EventArgs e)
        {
        }

        // เป็น Method ที่กลับไปยังหน้าแรกของเกม
        private void picGoGameControl_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            gamePause();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SetupBlock();
            label2.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            gamePause();
        }

        private void ResetBall_Click(object sender, EventArgs e)
        {
            picCircle.Location = new Point(474, 339);
        }
    }
}
