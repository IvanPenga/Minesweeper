using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SoundPlayer muzika;
        public static int brojPolja = 81;
        public static int brojMina = 10;
        public static int preostaleMine;

        public static List<Polje> listaPolja;
        private void Form1_Load(object sender, EventArgs e)
        {
            KreirajPolja();
            NovaIgra();
        }
        
        private void KreirajPolja()
        {
            panel1.Size = new Size(27 * (int)Math.Sqrt(brojPolja), 27 * (int)Math.Sqrt(brojPolja));
            panel1.Location = new Point(0, menuStrip1.Height);
            this.ClientSize = new Size(panel1.Width, panel1.Height + menuStrip1.Height);

            panel1.Controls.Clear();
            Polje.ime = 0;
            listaPolja = new List<Polje>();

            int x = 0, y = 0;
            
            for (int i = 0; i < brojPolja; i++)
            {
                Polje polje = new Polje();
                polje.Location = new Point(x, y);
                polje.MouseUp += polje_MouseUp;
                x += polje.Size.Width;

                if ((i + 1) % Math.Sqrt(brojPolja) == 0)
                {
                    y += polje.Size.Height;
                    x = 0;
                }
                listaPolja.Add(polje);
                panel1.Controls.Add(polje);
            }
           
        }

        void polje_MouseUp(object sender, MouseEventArgs e)
        {
            if (Polje.zabraniClick == true)
            {
                return;
            }

            muzika = new SoundPlayer("klik2.wav");
            muzika.Play();

            Button polje = sender as Button;
            int vracenaVrijednost = listaPolja[int.Parse(polje.Name)].Polje_MouseUp(sender, e);
            if (vracenaVrijednost == brojPolja-brojMina)
            {
                Polje.zabraniClick = true;
                Vrijeme.Stop();
                UnosHighScore unos = new UnosHighScore(VrijemeMinute.Text,VrijemeSekunde.Text,razina);
                unos.Show();
            }
            if (Form1.preostaleMine <= 0)
            {
                this.Text = "Preostale mine: 0";
            }
            else
            {
                this.Text = "Preostale mine: " + Form1.preostaleMine;
            }

            if (vracenaVrijednost == -3)
            {
                Vrijeme.Stop();
                muzika = new SoundPlayer("mina.wav");
                muzika.Play();
                this.Text = ":(";
            }
            
        }
        

        private void NovaIgra()
        {
            int udioZelene = 0;
            int udioPlave = 255;
            int udioCrvene = 0;
            foreach (var polje in listaPolja)
            {
                polje.Mina = false;
                polje.BackColor = Color.FromArgb(udioCrvene,udioZelene,udioPlave);
                polje.ForeColor = Color.Black;
                polje.Text = "";
                if (razina == "Lagano")
                {
                    udioZelene += 2;
                    udioCrvene += 1 ;
                    continue;
                }
                if (razina == "Srednje")
                {
                    udioZelene += 1;
                    if (udioZelene % 2 == 0)
                    {
                        udioCrvene += 1;
                    }
                    continue;
                }
                if (razina == "Tesko" || razina == "Hardcore")
                {
                    udioCrvene = 50;
                    if (int.Parse(polje.Name) % 2 == 0)
                    {
                        udioZelene++;
                    }
                }
            }
            PostaviMine();
            PostaviVrijeme();
            PocetneVrijednosti();
        }
        private void PocetneVrijednosti()
        {
            preostaleMine = brojMina;
            this.Text = "Preostale mine: " + (preostaleMine).ToString();
            Polje.brojZatvorenihPolja = 0;
            Polje.zabraniClick = false;

        }
        private void PostaviVrijeme()
        {
            sekunde = 0;
            minute = 0;
            VrijemeSekunde.Text = sekunde.ToString();
            VrijemeMinute.Text = minute.ToString();
            Vrijeme.Start();
        }
        Random rand = new Random();
        
        private void PostaviMine()
        {
            for (int i = 0; i < brojMina;)
            {
                int randomPolje = rand.Next(0,brojPolja);
                if (Form1.listaPolja[randomPolje].Mina == false)
                {
                    Form1.listaPolja[randomPolje].Mina = true;
                    i++;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaIgra();
            muzika = new SoundPlayer("novaIgra.wav");
            muzika.Play();
        }

        int sekunde;
        int minute;

        private void Vrijeme_Tick(object sender, EventArgs e)
        {
            VrijemeSekunde.Text = sekunde.ToString();
            sekunde++;
            if (sekunde == 60)
            {
                minute++;
                VrijemeMinute.Text = minute.ToString();
                sekunde = 0;
            }

        }

        private void highscoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baza baza = new Baza();
            muzika = new SoundPlayer("HighScores.wav");
            muzika.Play();
            baza.ShowDialog();
        }
        string razina = "Lagano";
        private void x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            razina = "Lagano";
            brojPolja = 9*9;
            brojMina = 10;
            KreirajPolja();
            NovaIgra();
        }

        private void x20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            razina = "Srednje";
            brojPolja = 15*15;
            brojMina = 40;
            KreirajPolja();
            NovaIgra();
        }

        private void x30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            razina = "Tesko";
            brojPolja = 20 * 20;
            brojMina = 90;
            KreirajPolja();
            NovaIgra();
        }

        private void hardcoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            razina = "Hardcore";
            brojPolja = 20*20;
            brojMina = 399;
            KreirajPolja();
            NovaIgra();
        }
    }
}
