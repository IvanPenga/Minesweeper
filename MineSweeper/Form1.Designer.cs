namespace MineSweeper
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardcoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highscoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vrijeme = new System.Windows.Forms.Timer(this.components);
            this.VrijemeMinute = new System.Windows.Forms.Label();
            this.VrijemeSekunde = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(254, 23);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.setSizeToolStripMenuItem,
            this.highscoresToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // setSizeToolStripMenuItem
            // 
            this.setSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x10ToolStripMenuItem,
            this.x20ToolStripMenuItem,
            this.x30ToolStripMenuItem,
            this.hardcoreToolStripMenuItem});
            this.setSizeToolStripMenuItem.Name = "setSizeToolStripMenuItem";
            this.setSizeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.setSizeToolStripMenuItem.Text = "Set size";
            // 
            // x10ToolStripMenuItem
            // 
            this.x10ToolStripMenuItem.Name = "x10ToolStripMenuItem";
            this.x10ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.x10ToolStripMenuItem.Text = "Lagano";
            this.x10ToolStripMenuItem.Click += new System.EventHandler(this.x10ToolStripMenuItem_Click);
            // 
            // x20ToolStripMenuItem
            // 
            this.x20ToolStripMenuItem.Name = "x20ToolStripMenuItem";
            this.x20ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.x20ToolStripMenuItem.Text = "Srednje";
            this.x20ToolStripMenuItem.Click += new System.EventHandler(this.x20ToolStripMenuItem_Click);
            // 
            // x30ToolStripMenuItem
            // 
            this.x30ToolStripMenuItem.Name = "x30ToolStripMenuItem";
            this.x30ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.x30ToolStripMenuItem.Text = "Tesko";
            this.x30ToolStripMenuItem.Click += new System.EventHandler(this.x30ToolStripMenuItem_Click);
            // 
            // hardcoreToolStripMenuItem
            // 
            this.hardcoreToolStripMenuItem.Name = "hardcoreToolStripMenuItem";
            this.hardcoreToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.hardcoreToolStripMenuItem.Text = "Hardcore";
            this.hardcoreToolStripMenuItem.Click += new System.EventHandler(this.hardcoreToolStripMenuItem_Click);
            // 
            // highscoresToolStripMenuItem
            // 
            this.highscoresToolStripMenuItem.Name = "highscoresToolStripMenuItem";
            this.highscoresToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.highscoresToolStripMenuItem.Text = "Highscores";
            this.highscoresToolStripMenuItem.Click += new System.EventHandler(this.highscoresToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 219);
            this.panel1.TabIndex = 1;
            // 
            // Vrijeme
            // 
            this.Vrijeme.Enabled = true;
            this.Vrijeme.Interval = 1000;
            this.Vrijeme.Tick += new System.EventHandler(this.Vrijeme_Tick);
            // 
            // VrijemeMinute
            // 
            this.VrijemeMinute.AutoSize = true;
            this.VrijemeMinute.Location = new System.Drawing.Point(45, 6);
            this.VrijemeMinute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VrijemeMinute.Name = "VrijemeMinute";
            this.VrijemeMinute.Size = new System.Drawing.Size(13, 13);
            this.VrijemeMinute.TabIndex = 0;
            this.VrijemeMinute.Text = "0";
            // 
            // VrijemeSekunde
            // 
            this.VrijemeSekunde.AutoSize = true;
            this.VrijemeSekunde.Location = new System.Drawing.Point(62, 6);
            this.VrijemeSekunde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VrijemeSekunde.Name = "VrijemeSekunde";
            this.VrijemeSekunde.Size = new System.Drawing.Size(13, 13);
            this.VrijemeSekunde.TabIndex = 2;
            this.VrijemeSekunde.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 240);
            this.Controls.Add(this.VrijemeSekunde);
            this.Controls.Add(this.VrijemeMinute);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer Vrijeme;
        private System.Windows.Forms.Label VrijemeMinute;
        private System.Windows.Forms.Label VrijemeSekunde;
        private System.Windows.Forms.ToolStripMenuItem highscoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardcoreToolStripMenuItem;
    }
}

