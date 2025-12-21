namespace Project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.heart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Label();
            this.picGoGameControl = new System.Windows.Forms.PictureBox();
            this.picCircle = new System.Windows.Forms.PictureBox();
            this.picplayer = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PLayerName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGoGameControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 106;
            this.label1.Text = "score :";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.score.ForeColor = System.Drawing.Color.White;
            this.score.Location = new System.Drawing.Point(96, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(0, 24);
            this.score.TabIndex = 107;
            // 
            // heart
            // 
            this.heart.AutoSize = true;
            this.heart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.heart.ForeColor = System.Drawing.Color.White;
            this.heart.Location = new System.Drawing.Point(491, 13);
            this.heart.Name = "heart";
            this.heart.Size = new System.Drawing.Size(21, 24);
            this.heart.TabIndex = 108;
            this.heart.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(257, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 55);
            this.label2.TabIndex = 109;
            this.label2.Text = "กรุณา Click เพื่อเล่นต่อ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(202, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 55);
            this.label3.TabIndex = 110;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(946, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 24);
            this.label4.TabIndex = 214;
            this.label4.Text = "| |";
            this.label4.Click += new System.EventHandler(this.Chose_mode);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(208, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(555, 55);
            this.label5.TabIndex = 216;
            this.label5.Text = "กรุณา Click เพื่อเก็บคะแนน";
            this.label5.Click += new System.EventHandler(this.GOscore);
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Reset.ForeColor = System.Drawing.Color.White;
            this.Reset.Location = new System.Drawing.Point(750, 13);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(124, 24);
            this.Reset.TabIndex = 217;
            this.Reset.Text = "Reset Game";
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // picGoGameControl
            // 
            this.picGoGameControl.BackColor = System.Drawing.Color.Black;
            this.picGoGameControl.Image = global::Project.Properties.Resources.pngegg;
            this.picGoGameControl.Location = new System.Drawing.Point(890, 9);
            this.picGoGameControl.Name = "picGoGameControl";
            this.picGoGameControl.Size = new System.Drawing.Size(36, 28);
            this.picGoGameControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGoGameControl.TabIndex = 215;
            this.picGoGameControl.TabStop = false;
            this.picGoGameControl.Click += new System.EventHandler(this.GoControl);
            // 
            // picCircle
            // 
            this.picCircle.BackColor = System.Drawing.Color.Black;
            this.picCircle.Image = global::Project.Properties.Resources.circle_38648_1280;
            this.picCircle.Location = new System.Drawing.Point(476, 310);
            this.picCircle.Name = "picCircle";
            this.picCircle.Size = new System.Drawing.Size(36, 28);
            this.picCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCircle.TabIndex = 1;
            this.picCircle.TabStop = false;
            // 
            // picplayer
            // 
            this.picplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.picplayer.Location = new System.Drawing.Point(369, 685);
            this.picplayer.Name = "picplayer";
            this.picplayer.Size = new System.Drawing.Size(222, 10);
            this.picplayer.TabIndex = 0;
            this.picplayer.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(190, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 218;
            this.label6.Text = "Player :";
            // 
            // PLayerName
            // 
            this.PLayerName.BackColor = System.Drawing.Color.Black;
            this.PLayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PLayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.PLayerName.ForeColor = System.Drawing.Color.White;
            this.PLayerName.Location = new System.Drawing.Point(271, 11);
            this.PLayerName.Multiline = true;
            this.PLayerName.Name = "PLayerName";
            this.PLayerName.Size = new System.Drawing.Size(174, 20);
            this.PLayerName.TabIndex = 219;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(999, 707);
            this.Controls.Add(this.PLayerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picGoGameControl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heart);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCircle);
            this.Controls.Add(this.picplayer);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_2);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picGoGameControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picplayer;
        private System.Windows.Forms.PictureBox picCircle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label heart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picGoGameControl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Reset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PLayerName;
    }
}