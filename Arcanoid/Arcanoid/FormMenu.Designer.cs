namespace Arcanoid
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSpeedPlus = new System.Windows.Forms.Button();
            this.btnSpeedMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(677, 359);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(98, 62);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Начать игру\r\n";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSpeedPlus
            // 
            this.btnSpeedPlus.Location = new System.Drawing.Point(135, 370);
            this.btnSpeedPlus.Name = "btnSpeedPlus";
            this.btnSpeedPlus.Size = new System.Drawing.Size(75, 23);
            this.btnSpeedPlus.TabIndex = 1;
            this.btnSpeedPlus.Text = "+";
            this.btnSpeedPlus.UseVisualStyleBackColor = true;
            // 
            // btnSpeedMin
            // 
            this.btnSpeedMin.Location = new System.Drawing.Point(13, 369);
            this.btnSpeedMin.Name = "btnSpeedMin";
            this.btnSpeedMin.Size = new System.Drawing.Size(75, 23);
            this.btnSpeedMin.TabIndex = 2;
            this.btnSpeedMin.Text = "-";
            this.btnSpeedMin.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arcanoid.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 468);
            this.Controls.Add(this.btnSpeedMin);
            this.Controls.Add(this.btnSpeedPlus);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arcanoid";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSpeedPlus;
        private System.Windows.Forms.Button btnSpeedMin;
    }
}

