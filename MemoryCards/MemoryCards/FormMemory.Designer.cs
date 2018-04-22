namespace MemoryCards
{
	partial class FormMemory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemory));
			this.menu = new System.Windows.Forms.MenuStrip();
			this.menuGame = new System.Windows.Forms.ToolStripMenuItem();
			this.menuGameNew = new System.Windows.Forms.ToolStripMenuItem();
			this.separator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuGameExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.menuRules = new System.Windows.Forms.ToolStripMenuItem();
			this.separator2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox0 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menu.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menu
			// 
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGame,
            this.menuHelp});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(800, 24);
			this.menu.TabIndex = 0;
			this.menu.Tag = "2";
			this.menu.Text = "menuStrip1";
			// 
			// menuGame
			// 
			this.menuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGameNew,
            this.separator1,
            this.menuGameExit});
			this.menuGame.Name = "menuGame";
			this.menuGame.Size = new System.Drawing.Size(46, 20);
			this.menuGame.Tag = "2";
			this.menuGame.Text = "Игра";
			// 
			// menuGameNew
			// 
			this.menuGameNew.Name = "menuGameNew";
			this.menuGameNew.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.menuGameNew.Size = new System.Drawing.Size(157, 22);
			this.menuGameNew.Tag = "2";
			this.menuGameNew.Text = "Новая Игра";
			this.menuGameNew.Click += new System.EventHandler(this.menuGameNew_Click);
			// 
			// separator1
			// 
			this.separator1.Name = "separator1";
			this.separator1.Size = new System.Drawing.Size(154, 6);
			this.separator1.Tag = "2";
			// 
			// menuGameExit
			// 
			this.menuGameExit.Name = "menuGameExit";
			this.menuGameExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
			this.menuGameExit.Size = new System.Drawing.Size(157, 22);
			this.menuGameExit.Tag = "2";
			this.menuGameExit.Text = "Выход";
			this.menuGameExit.Click += new System.EventHandler(this.menuGameExit_Click);
			// 
			// menuHelp
			// 
			this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRules,
            this.separator2,
            this.menuInfo});
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.Size = new System.Drawing.Size(68, 20);
			this.menuHelp.Tag = "2";
			this.menuHelp.Text = "Помощь";
			// 
			// menuRules
			// 
			this.menuRules.Name = "menuRules";
			this.menuRules.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.menuRules.Size = new System.Drawing.Size(176, 22);
			this.menuRules.Tag = "2";
			this.menuRules.Text = "Правила Игры";
			this.menuRules.Click += new System.EventHandler(this.menuRules_Click);
			// 
			// separator2
			// 
			this.separator2.Name = "separator2";
			this.separator2.Size = new System.Drawing.Size(173, 6);
			this.separator2.Tag = "2";
			// 
			// menuInfo
			// 
			this.menuInfo.Name = "menuInfo";
			this.menuInfo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
			this.menuInfo.Size = new System.Drawing.Size(176, 22);
			this.menuInfo.Tag = "2";
			this.menuInfo.Text = "Об авторе";
			this.menuInfo.Click += new System.EventHandler(this.menuInfo_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.pictureBox0, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox15, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox14, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox13, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox12, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox11, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox10, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox9, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox8, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox7, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(300, 300);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 426);
			this.tableLayoutPanel1.TabIndex = 1;
			this.tableLayoutPanel1.Tag = "2";
			// 
			// pictureBox0
			// 
			this.pictureBox0.BackColor = System.Drawing.Color.White;
			this.pictureBox0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox0.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox0.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox0.Image")));
			this.pictureBox0.Location = new System.Drawing.Point(603, 321);
			this.pictureBox0.Name = "pictureBox0";
			this.pictureBox0.Size = new System.Drawing.Size(191, 99);
			this.pictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox0.TabIndex = 15;
			this.pictureBox0.TabStop = false;
			this.pictureBox0.Tag = "0";
			this.pictureBox0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
			// 
			// pictureBox15
			// 
			this.pictureBox15.BackColor = System.Drawing.Color.White;
			this.pictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox15.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(404, 321);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(190, 99);
			this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox15.TabIndex = 14;
			this.pictureBox15.TabStop = false;
			this.pictureBox15.Tag = "15";
			this.pictureBox15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
			// 
			// pictureBox14
			// 
			this.pictureBox14.BackColor = System.Drawing.Color.White;
			this.pictureBox14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox14.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(205, 321);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(190, 99);
			this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox14.TabIndex = 13;
			this.pictureBox14.TabStop = false;
			this.pictureBox14.Tag = "14";
			this.pictureBox14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
			// 
			// pictureBox13
			// 
			this.pictureBox13.BackColor = System.Drawing.Color.White;
			this.pictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox13.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(6, 321);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(190, 99);
			this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox13.TabIndex = 12;
			this.pictureBox13.TabStop = false;
			this.pictureBox13.Tag = "13";
			this.pictureBox13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
			// 
			// pictureBox12
			// 
			this.pictureBox12.BackColor = System.Drawing.Color.White;
			this.pictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(603, 216);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(191, 96);
			this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox12.TabIndex = 11;
			this.pictureBox12.TabStop = false;
			this.pictureBox12.Tag = "12";
			this.pictureBox12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
			// 
			// pictureBox11
			// 
			this.pictureBox11.BackColor = System.Drawing.Color.White;
			this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(404, 216);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(190, 96);
			this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox11.TabIndex = 10;
			this.pictureBox11.TabStop = false;
			this.pictureBox11.Tag = "11";
			this.pictureBox11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
			// 
			// pictureBox10
			// 
			this.pictureBox10.BackColor = System.Drawing.Color.White;
			this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(205, 216);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(190, 96);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox10.TabIndex = 9;
			this.pictureBox10.TabStop = false;
			this.pictureBox10.Tag = "10";
			this.pictureBox10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
			// 
			// pictureBox9
			// 
			this.pictureBox9.BackColor = System.Drawing.Color.White;
			this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(6, 216);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(190, 96);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox9.TabIndex = 8;
			this.pictureBox9.TabStop = false;
			this.pictureBox9.Tag = "9";
			this.pictureBox9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
			// 
			// pictureBox8
			// 
			this.pictureBox8.BackColor = System.Drawing.Color.White;
			this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(603, 111);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(191, 96);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox8.TabIndex = 7;
			this.pictureBox8.TabStop = false;
			this.pictureBox8.Tag = "8";
			this.pictureBox8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.Color.White;
			this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(404, 111);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(190, 96);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox7.TabIndex = 6;
			this.pictureBox7.TabStop = false;
			this.pictureBox7.Tag = "7";
			this.pictureBox7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.Color.White;
			this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(205, 111);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(190, 96);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 5;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Tag = "6";
			this.pictureBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.White;
			this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(6, 111);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(190, 96);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 4;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Tag = "5";
			this.pictureBox5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.White;
			this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(603, 6);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(191, 96);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 3;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Tag = "4";
			this.pictureBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.White;
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(404, 6);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(190, 96);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Tag = "3";
			this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(205, 6);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(190, 96);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Tag = "2";
			this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::MemoryCards.Properties.Resources._0;
			this.pictureBox1.Location = new System.Drawing.Point(6, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(190, 96);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "1";
			this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseClick);
			// 
			// FormMemory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menu;
			this.Name = "FormMemory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Карточки Памяти";
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem menuGame;
		private System.Windows.Forms.ToolStripMenuItem menuGameNew;
		private System.Windows.Forms.ToolStripSeparator separator1;
		private System.Windows.Forms.ToolStripMenuItem menuGameExit;
		private System.Windows.Forms.ToolStripMenuItem menuHelp;
		private System.Windows.Forms.ToolStripMenuItem menuRules;
		private System.Windows.Forms.ToolStripSeparator separator2;
		private System.Windows.Forms.ToolStripMenuItem menuInfo;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox0;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

