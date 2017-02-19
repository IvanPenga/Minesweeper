namespace MineSweeper
{
    partial class Baza
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PrikazHighscore = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prikaziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laganoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.srednjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teskoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardcoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PrikazHighscore)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrikazHighscore
            // 
            this.PrikazHighscore.AllowUserToAddRows = false;
            this.PrikazHighscore.AllowUserToDeleteRows = false;
            this.PrikazHighscore.AllowUserToResizeColumns = false;
            this.PrikazHighscore.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrikazHighscore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.PrikazHighscore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrikazHighscore.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PrikazHighscore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.PrikazHighscore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PrikazHighscore.DefaultCellStyle = dataGridViewCellStyle21;
            this.PrikazHighscore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrikazHighscore.Location = new System.Drawing.Point(0, 24);
            this.PrikazHighscore.Margin = new System.Windows.Forms.Padding(2);
            this.PrikazHighscore.MultiSelect = false;
            this.PrikazHighscore.Name = "PrikazHighscore";
            this.PrikazHighscore.ReadOnly = true;
            this.PrikazHighscore.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.PrikazHighscore.RowHeadersVisible = false;
            this.PrikazHighscore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.PrikazHighscore.RowTemplate.Height = 27;
            this.PrikazHighscore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PrikazHighscore.ShowEditingIcon = false;
            this.PrikazHighscore.Size = new System.Drawing.Size(241, 171);
            this.PrikazHighscore.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(241, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prikaziToolStripMenuItem
            // 
            this.prikaziToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laganoToolStripMenuItem,
            this.srednjeToolStripMenuItem,
            this.teskoToolStripMenuItem,
            this.hardcoreToolStripMenuItem});
            this.prikaziToolStripMenuItem.Name = "prikaziToolStripMenuItem";
            this.prikaziToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.prikaziToolStripMenuItem.Text = "Prikazi";
            // 
            // laganoToolStripMenuItem
            // 
            this.laganoToolStripMenuItem.Name = "laganoToolStripMenuItem";
            this.laganoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.laganoToolStripMenuItem.Text = "Lagano";
            this.laganoToolStripMenuItem.Click += new System.EventHandler(this.laganoToolStripMenuItem_Click);
            // 
            // srednjeToolStripMenuItem
            // 
            this.srednjeToolStripMenuItem.Name = "srednjeToolStripMenuItem";
            this.srednjeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.srednjeToolStripMenuItem.Text = "Srednje";
            this.srednjeToolStripMenuItem.Click += new System.EventHandler(this.srednjeToolStripMenuItem_Click);
            // 
            // teskoToolStripMenuItem
            // 
            this.teskoToolStripMenuItem.Name = "teskoToolStripMenuItem";
            this.teskoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.teskoToolStripMenuItem.Text = "Tesko";
            this.teskoToolStripMenuItem.Click += new System.EventHandler(this.teskoToolStripMenuItem_Click);
            // 
            // hardcoreToolStripMenuItem
            // 
            this.hardcoreToolStripMenuItem.Name = "hardcoreToolStripMenuItem";
            this.hardcoreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hardcoreToolStripMenuItem.Text = "Hardcore";
            this.hardcoreToolStripMenuItem.Click += new System.EventHandler(this.hardcoreToolStripMenuItem_Click);
            // 
            // Baza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 195);
            this.Controls.Add(this.PrikazHighscore);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Baza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Highscores";
            this.Load += new System.EventHandler(this.Baza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrikazHighscore)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PrikazHighscore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prikaziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laganoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem srednjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teskoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardcoreToolStripMenuItem;
    }
}