namespace SecretImage
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnShow1 = new System.Windows.Forms.Button();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.btnShow3 = new System.Windows.Forms.Button();
            this.btnShow4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow1
            // 
            this.btnShow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnShow1.Location = new System.Drawing.Point(12, 12);
            this.btnShow1.Name = "btnShow1";
            this.btnShow1.Size = new System.Drawing.Size(104, 66);
            this.btnShow1.TabIndex = 0;
            this.btnShow1.Text = "Лемур";
            this.btnShow1.UseVisualStyleBackColor = true;
            this.btnShow1.Click += new System.EventHandler(this.btnShow1_Click);
            // 
            // btnShow2
            // 
            this.btnShow2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnShow2.Location = new System.Drawing.Point(12, 421);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(104, 66);
            this.btnShow2.TabIndex = 1;
            this.btnShow2.Text = "Кот";
            this.btnShow2.UseVisualStyleBackColor = true;
            this.btnShow2.Click += new System.EventHandler(this.btnShow2_Click);
            // 
            // btnShow3
            // 
            this.btnShow3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnShow3.Location = new System.Drawing.Point(380, 421);
            this.btnShow3.Name = "btnShow3";
            this.btnShow3.Size = new System.Drawing.Size(104, 66);
            this.btnShow3.TabIndex = 2;
            this.btnShow3.Text = "Собака";
            this.btnShow3.UseVisualStyleBackColor = true;
            this.btnShow3.Click += new System.EventHandler(this.btnShow3_Click);
            // 
            // btnShow4
            // 
            this.btnShow4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnShow4.Location = new System.Drawing.Point(380, 12);
            this.btnShow4.Name = "btnShow4";
            this.btnShow4.Size = new System.Drawing.Size(104, 66);
            this.btnShow4.TabIndex = 3;
            this.btnShow4.Text = "Сова";
            this.btnShow4.UseVisualStyleBackColor = true;
            this.btnShow4.Click += new System.EventHandler(this.btnShow4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecretImage.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(496, 499);
            this.Controls.Add(this.btnShow4);
            this.Controls.Add(this.btnShow3);
            this.Controls.Add(this.btnShow2);
            this.Controls.Add(this.btnShow1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(512, 538);
            this.MinimumSize = new System.Drawing.Size(512, 538);
            this.Name = "MainForm";
            this.Text = "Картинка с Секретом";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow1;
        private System.Windows.Forms.Button btnShow2;
        private System.Windows.Forms.Button btnShow3;
        private System.Windows.Forms.Button btnShow4;
    }
}

