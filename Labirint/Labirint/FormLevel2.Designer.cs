namespace Labirint
{
    partial class FormLevel2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFinish = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.labelDoor = new System.Windows.Forms.Label();
            this.labelFlash1 = new System.Windows.Forms.Label();
            this.labelFlash2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(937, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 415);
            this.label4.TabIndex = 12;
            this.label4.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(-1, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 415);
            this.label3.TabIndex = 11;
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(-1, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(952, 26);
            this.label2.TabIndex = 10;
            this.label2.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-1, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(986, 26);
            this.label1.TabIndex = 9;
            this.label1.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // labelFinish
            // 
            this.labelFinish.BackColor = System.Drawing.Color.Blue;
            this.labelFinish.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinish.Location = new System.Drawing.Point(822, 372);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(119, 73);
            this.labelFinish.TabIndex = 8;
            this.labelFinish.Text = "Finish";
            this.labelFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFinish.MouseEnter += new System.EventHandler(this.labelFinish_MouseEnter);
            // 
            // labelStart
            // 
            this.labelStart.BackColor = System.Drawing.Color.Lime;
            this.labelStart.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.Location = new System.Drawing.Point(21, 30);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(119, 73);
            this.labelStart.TabIndex = 7;
            this.labelStart.Text = "Start";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(160, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 318);
            this.label5.TabIndex = 13;
            this.label5.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(491, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(447, 26);
            this.label6.TabIndex = 14;
            this.label6.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(798, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 214);
            this.label7.TabIndex = 15;
            this.label7.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // lblKey
            // 
            this.lblKey.BackColor = System.Drawing.Color.Orange;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKey.Location = new System.Drawing.Point(825, 65);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(100, 38);
            this.lblKey.TabIndex = 16;
            this.lblKey.Text = "Ключ";
            this.lblKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKey.MouseEnter += new System.EventHandler(this.lblKey_MouseEnter);
            // 
            // labelDoor
            // 
            this.labelDoor.BackColor = System.Drawing.Color.Orange;
            this.labelDoor.Location = new System.Drawing.Point(825, 231);
            this.labelDoor.Name = "labelDoor";
            this.labelDoor.Size = new System.Drawing.Size(113, 38);
            this.labelDoor.TabIndex = 17;
            this.labelDoor.MouseEnter += new System.EventHandler(this.labelDoor_MouseEnter);
            // 
            // labelFlash1
            // 
            this.labelFlash1.BackColor = System.Drawing.Color.Red;
            this.labelFlash1.Location = new System.Drawing.Point(2, 287);
            this.labelFlash1.Name = "labelFlash1";
            this.labelFlash1.Size = new System.Drawing.Size(949, 10);
            this.labelFlash1.TabIndex = 18;
            this.labelFlash1.MouseEnter += new System.EventHandler(this.labelFlash1_MouseEnter);
            // 
            // labelFlash2
            // 
            this.labelFlash2.BackColor = System.Drawing.Color.Red;
            this.labelFlash2.Location = new System.Drawing.Point(512, 30);
            this.labelFlash2.Name = "labelFlash2";
            this.labelFlash2.Size = new System.Drawing.Size(10, 415);
            this.labelFlash2.TabIndex = 19;
            this.labelFlash2.MouseEnter += new System.EventHandler(this.labelFlash1_MouseEnter);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 800;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormLevel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 473);
            this.Controls.Add(this.labelFlash2);
            this.Controls.Add(this.labelFlash1);
            this.Controls.Add(this.labelDoor);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFinish);
            this.Controls.Add(this.labelStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLevel2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLevel2";
            this.Shown += new System.EventHandler(this.FormLevel2_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label labelDoor;
        private System.Windows.Forms.Label labelFlash1;
        private System.Windows.Forms.Label labelFlash2;
        private System.Windows.Forms.Timer timer;
    }
}