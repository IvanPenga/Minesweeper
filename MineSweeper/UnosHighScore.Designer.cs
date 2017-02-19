namespace MineSweeper
{
    partial class UnosHighScore
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Unesi = new System.Windows.Forms.Button();
            this.Odustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 39);
            this.textBox1.TabIndex = 0;
            // 
            // Unesi
            // 
            this.Unesi.Location = new System.Drawing.Point(12, 57);
            this.Unesi.Name = "Unesi";
            this.Unesi.Size = new System.Drawing.Size(108, 44);
            this.Unesi.TabIndex = 1;
            this.Unesi.Text = "Unesi";
            this.Unesi.UseVisualStyleBackColor = true;
            this.Unesi.Click += new System.EventHandler(this.Unesi_Click);
            // 
            // Odustani
            // 
            this.Odustani.Location = new System.Drawing.Point(122, 57);
            this.Odustani.Name = "Odustani";
            this.Odustani.Size = new System.Drawing.Size(108, 44);
            this.Odustani.TabIndex = 2;
            this.Odustani.Text = "Odustani";
            this.Odustani.UseVisualStyleBackColor = true;
            this.Odustani.Click += new System.EventHandler(this.Odustani_Click);
            // 
            // UnosHighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 114);
            this.Controls.Add(this.Odustani);
            this.Controls.Add(this.Unesi);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UnosHighScore";
            this.Text = "Woohoo!";
            this.Load += new System.EventHandler(this.UnosHighScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Unesi;
        private System.Windows.Forms.Button Odustani;
    }
}