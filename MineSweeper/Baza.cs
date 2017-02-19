using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Baza : Form
    {
        public Baza()
        {
            InitializeComponent();
        }

        HighScore h = new HighScore();
        private void Baza_Load(object sender, EventArgs e)
        {
            //string del = "create table highscores (Ime varchar(20), Minute varchar(3),Sekunde varchar(2))";
            this.ClientSize = new Size(451, 400);
            laganoToolStripMenuItem_Click(sender,e);



        }

        private void SakrijStupce()
        {
            PrikazHighscore.Columns["Minute"].Visible = false;
            PrikazHighscore.Columns["Sekunde"].Visible = false;

            PrikazHighscore.Columns[0].Width = 150;
            PrikazHighscore.Columns[3].Width = 150;
            PrikazHighscore.Columns[4].Width = 150;
        }

        private void laganoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikazHighscore.DataSource = null;
            PrikazHighscore.DataSource = h.dohvatiHighscore("Lagano");
            SakrijStupce();
        }

        private void srednjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikazHighscore.DataSource = null;
            PrikazHighscore.DataSource = h.dohvatiHighscore("Srednje");
            SakrijStupce();
        }

        private void teskoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikazHighscore.DataSource = null;
            PrikazHighscore.DataSource = h.dohvatiHighscore("Tesko");
            SakrijStupce();
        }

        private void hardcoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikazHighscore.DataSource = null;
            PrikazHighscore.DataSource = h.dohvatiHighscore("Hardcore");
            SakrijStupce();
        }
    }
}
