namespace PaCman
{
    partial class Controller_MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controller_MainForm));
            this.StartStop_pcbx = new System.Windows.Forms.PictureBox();
            this.Help_ttip = new System.Windows.Forms.ToolTip(this.components);
            this.MainMenu_strp = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.GameStatus_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.StartStop_pcbx)).BeginInit();
            this.MainMenu_strp.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartStop_pcbx
            // 
            this.StartStop_pcbx.Image = ((System.Drawing.Image)(resources.GetObject("StartStop_pcbx.Image")));
            this.StartStop_pcbx.Location = new System.Drawing.Point(565, 120);
            this.StartStop_pcbx.Name = "StartStop_pcbx";
            this.StartStop_pcbx.Size = new System.Drawing.Size(135, 136);
            this.StartStop_pcbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.StartStop_pcbx.TabIndex = 0;
            this.StartStop_pcbx.TabStop = false;
            this.Help_ttip.SetToolTip(this.StartStop_pcbx, "Нажмите для начала игры");
            this.StartStop_pcbx.Click += new System.EventHandler(this.StartStop_btn_Click);
            this.StartStop_pcbx.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.StartStop_pcbx_PreviewKeyDown);
            // 
            // Help_ttip
            // 
            this.Help_ttip.IsBalloon = true;
            this.Help_ttip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Help_ttip.ToolTipTitle = "Packman 1.0";
            // 
            // MainMenu_strp
            // 
            this.MainMenu_strp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.MainMenu_strp.Location = new System.Drawing.Point(0, 0);
            this.MainMenu_strp.Name = "MainMenu_strp";
            this.MainMenu_strp.Size = new System.Drawing.Size(728, 24);
            this.MainMenu_strp.TabIndex = 1;
            this.MainMenu_strp.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.играToolStripMenuItem.Text = "&Game";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Image = global::PaCman.Properties.Resources.Exit2__3_;
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.новаяИграToolStripMenuItem.Text = "&New Game";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::PaCman.Properties.Resources.Exit2__1_;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "&Exit";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.настройкиToolStripMenuItem.Text = "&Setings";
            // 
            // soundToolStripMenuItem
            // 
            this.soundToolStripMenuItem.Image = global::PaCman.Properties.Resources.Exit2__4_;
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            this.soundToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.soundToolStripMenuItem.Text = "&Sound";
            this.soundToolStripMenuItem.Click += new System.EventHandler(this.SoundToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.информацияToolStripMenuItem.Text = "&Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::PaCman.Properties.Resources.Exit2__2_;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameStatus_lbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 660);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(728, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // GameStatus_lbl
            // 
            this.GameStatus_lbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GameStatus_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GameStatus_lbl.Name = "GameStatus_lbl";
            this.GameStatus_lbl.Size = new System.Drawing.Size(0, 17);
            // 
            // Controller_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(728, 682);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.StartStop_pcbx);
            this.Controls.Add(this.MainMenu_strp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu_strp;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(744, 721);
            this.MinimumSize = new System.Drawing.Size(744, 721);
            this.Name = "Controller_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacman";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Controller_MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.StartStop_pcbx)).EndInit();
            this.MainMenu_strp.ResumeLayout(false);
            this.MainMenu_strp.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StartStop_pcbx;
        private System.Windows.Forms.ToolTip Help_ttip;
        private System.Windows.Forms.MenuStrip MainMenu_strp;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel GameStatus_lbl;

    }
}

