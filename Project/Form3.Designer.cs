namespace Project
{
    partial class Form3
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Label();
            this.picplayer = new System.Windows.Forms.PictureBox();
            this.picCircle = new System.Windows.Forms.PictureBox();
            this.picGoGameControl = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ResetBall = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoGameControl)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(258, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 55);
            this.label2.TabIndex = 320;
            this.label2.Text = "กรุณา Click เพื่อเล่นต่อ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Reset.ForeColor = System.Drawing.Color.White;
            this.Reset.Location = new System.Drawing.Point(762, 19);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(109, 24);
            this.Reset.TabIndex = 321;
            this.Reset.Text = "Reset Block";
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // picplayer
            // 
            this.picplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.picplayer.Location = new System.Drawing.Point(402, 685);
            this.picplayer.Name = "picplayer";
            this.picplayer.Size = new System.Drawing.Size(222, 10);
            this.picplayer.TabIndex = 319;
            this.picplayer.TabStop = false;
            // 
            // picCircle
            // 
            this.picCircle.BackColor = System.Drawing.Color.Black;
            this.picCircle.Image = global::Project.Properties.Resources.circle_38648_1280;
            this.picCircle.Location = new System.Drawing.Point(474, 339);
            this.picCircle.Name = "picCircle";
            this.picCircle.Size = new System.Drawing.Size(36, 28);
            this.picCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCircle.TabIndex = 318;
            this.picCircle.TabStop = false;
            // 
            // picGoGameControl
            // 
            this.picGoGameControl.BackColor = System.Drawing.Color.Black;
            this.picGoGameControl.Image = global::Project.Properties.Resources.pngegg;
            this.picGoGameControl.Location = new System.Drawing.Point(886, 9);
            this.picGoGameControl.Name = "picGoGameControl";
            this.picGoGameControl.Size = new System.Drawing.Size(42, 41);
            this.picGoGameControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGoGameControl.TabIndex = 322;
            this.picGoGameControl.TabStop = false;
            this.picGoGameControl.Click += new System.EventHandler(this.picGoGameControl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(948, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 24);
            this.label4.TabIndex = 323;
            this.label4.Text = "| |";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ResetBall
            // 
            this.ResetBall.AutoSize = true;
            this.ResetBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ResetBall.ForeColor = System.Drawing.Color.White;
            this.ResetBall.Location = new System.Drawing.Point(626, 19);
            this.ResetBall.Name = "ResetBall";
            this.ResetBall.Size = new System.Drawing.Size(93, 24);
            this.ResetBall.TabIndex = 324;
            this.ResetBall.Text = "Reset Ball";
            this.ResetBall.Click += new System.EventHandler(this.ResetBall_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(999, 707);
            this.Controls.Add(this.ResetBall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picGoGameControl);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picplayer);
            this.Controls.Add(this.picCircle);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoGameControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picCircle;
        private System.Windows.Forms.PictureBox picplayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Reset;
        private System.Windows.Forms.PictureBox picGoGameControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ResetBall;
    }
}