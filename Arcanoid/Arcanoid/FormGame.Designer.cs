namespace Arcanoid
{
    partial class FormGame
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
            this.lblTop = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.btnRocket = new System.Windows.Forms.Button();
            this.ball = new System.Windows.Forms.RadioButton();
            this.brick2 = new System.Windows.Forms.Label();
            this.brick5 = new System.Windows.Forms.Label();
            this.brick4 = new System.Windows.Forms.Label();
            this.brick3 = new System.Windows.Forms.Label();
            this.brick1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTop
            // 
            this.lblTop.BackColor = System.Drawing.Color.Yellow;
            this.lblTop.Location = new System.Drawing.Point(1, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(861, 23);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "\r\n";
            // 
            // lblLeft
            // 
            this.lblLeft.BackColor = System.Drawing.Color.Yellow;
            this.lblLeft.Location = new System.Drawing.Point(1, 23);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(25, 386);
            this.lblLeft.TabIndex = 1;
            this.lblLeft.Text = "\r\n";
            // 
            // lblRight
            // 
            this.lblRight.BackColor = System.Drawing.Color.Yellow;
            this.lblRight.Location = new System.Drawing.Point(837, 23);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(25, 386);
            this.lblRight.TabIndex = 2;
            this.lblRight.Text = "\r\n";
            // 
            // btnRocket
            // 
            this.btnRocket.Enabled = false;
            this.btnRocket.Location = new System.Drawing.Point(385, 416);
            this.btnRocket.Name = "btnRocket";
            this.btnRocket.Size = new System.Drawing.Size(75, 23);
            this.btnRocket.TabIndex = 3;
            this.btnRocket.Text = "+++++\r\n";
            this.btnRocket.UseVisualStyleBackColor = true;
            // 
            // ball
            // 
            this.ball.AutoSize = true;
            this.ball.Checked = true;
            this.ball.Enabled = false;
            this.ball.Location = new System.Drawing.Point(415, 397);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(14, 13);
            this.ball.TabIndex = 4;
            this.ball.TabStop = true;
            this.ball.UseVisualStyleBackColor = true;
            // 
            // brick2
            // 
            this.brick2.BackColor = System.Drawing.Color.Red;
            this.brick2.Location = new System.Drawing.Point(87, 228);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(71, 23);
            this.brick2.TabIndex = 5;
            this.brick2.Text = "\r\n";
            // 
            // brick5
            // 
            this.brick5.BackColor = System.Drawing.Color.Red;
            this.brick5.Location = new System.Drawing.Point(696, 228);
            this.brick5.Name = "brick5";
            this.brick5.Size = new System.Drawing.Size(71, 23);
            this.brick5.TabIndex = 6;
            this.brick5.Text = "\r\n";
            // 
            // brick4
            // 
            this.brick4.BackColor = System.Drawing.Color.Red;
            this.brick4.Location = new System.Drawing.Point(696, 107);
            this.brick4.Name = "brick4";
            this.brick4.Size = new System.Drawing.Size(71, 23);
            this.brick4.TabIndex = 7;
            this.brick4.Text = "\r\n";
            // 
            // brick3
            // 
            this.brick3.BackColor = System.Drawing.Color.Red;
            this.brick3.Location = new System.Drawing.Point(389, 172);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(71, 23);
            this.brick3.TabIndex = 8;
            this.brick3.Text = "\r\n";
            // 
            // brick1
            // 
            this.brick1.BackColor = System.Drawing.Color.Red;
            this.brick1.Location = new System.Drawing.Point(87, 107);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(71, 23);
            this.brick1.TabIndex = 9;
            this.brick1.Text = "\r\n";
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(863, 473);
            this.Controls.Add(this.brick1);
            this.Controls.Add(this.brick3);
            this.Controls.Add(this.brick4);
            this.Controls.Add(this.brick5);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.btnRocket);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormGame";
            this.Shown += new System.EventHandler(this.FormGame_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Button btnRocket;
        private System.Windows.Forms.RadioButton ball;
        private System.Windows.Forms.Label brick2;
        private System.Windows.Forms.Label brick5;
        private System.Windows.Forms.Label brick4;
        private System.Windows.Forms.Label brick3;
        private System.Windows.Forms.Label brick1;
        private System.Windows.Forms.Timer timer;
    }
}