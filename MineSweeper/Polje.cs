using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public class Polje : Button
    {
        public bool Mina;
        public static int ime = 0;
        public Polje()
        {
            this.Size = new Size(27,27);
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Tahoma", 11,FontStyle.Bold);
            this.FlatAppearance.BorderColor = Color.Black;
            this.Name = ime.ToString();
            ime++;

        }

        public static int brojZatvorenihPolja = 0;
        public int Polje_MouseUp(object sender, MouseEventArgs e)
        {
            //ako je desni klik
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (this.Text == "Z")
                {
                    this.Text = "";
                    Form1.preostaleMine++;
                }
                else if (this.Text == "")
                {
                    this.Text = "Z";
                    Form1.preostaleMine--;
                }
                return 0;
            }

            //ako je lijevi klik
            
            brojMina = 0;
            if (this.Mina == true) //ako je mina
            {
                this.Text = "*";
                if (gameOver == false)
                {
                    GameOver(sender, e);
                    return -3;
                }
            }
            else if (this.Text == "" || this.Text == "Z")//ako nije mina
            {
                brojZatvorenihPolja++;
                if (this.Text == "Z") Form1.preostaleMine++;
                int ime = int.Parse(this.Name);
                if (ime >= Math.Sqrt(Form1.brojPolja)+1 && ime <= (Form1.brojPolja-Math.Sqrt(Form1.brojPolja)-2) && ime % Math.Sqrt(Form1.brojPolja) != 0 && (ime + 1) % Math.Sqrt(Form1.brojPolja) != 0) //pregledaj sredinu
                {
                    Sve();
                    Kraj(sender, e);
                    return brojZatvorenihPolja;
                }
                if (ime >= 1 && ime <= Math.Sqrt(Form1.brojPolja)-2)
                {
                    Desno();
                    Lijevo();
                    SveGore();
                    Kraj(sender, e);
                    return brojZatvorenihPolja;
                }
                if (ime % Math.Sqrt(Form1.brojPolja) == 0 && ime != (Form1.brojPolja- Math.Sqrt(Form1.brojPolja)) && ime != 0)
                {
                    Gore();
                    SveDesno();
                    Dolje();
                    Kraj(sender, e);
                    return brojZatvorenihPolja;
                }
                if (ime >= Form1.brojPolja- Math.Sqrt(Form1.brojPolja)+1 && ime <= Form1.brojPolja-2)
                {
                    Desno();
                    Lijevo();
                    SveDolje();
                    Kraj(sender, e);
                    return brojZatvorenihPolja;
                }
                if ((ime + 1) % Math.Sqrt(Form1.brojPolja) == 0 && ime != Form1.brojPolja-1 && ime != 0 && ime != (Math.Sqrt(Form1.brojPolja)-1))
                {
                    SveLijevo();
                    Gore();
                    Dolje();
                    Kraj(sender, e);
                    return brojZatvorenihPolja;
                }
                if (ime == 0)
                {
                    Desno();
                    Gore();
                    GoreDesno();
                    Kraj(sender, e);
                    return brojZatvorenihPolja;
                }
                if (ime == (Math.Sqrt(Form1.brojPolja)-1))
                {
                    Lijevo();
                    Gore();
                    GoreLijevo();
                    Kraj(sender, e);
                    return brojZatvorenihPolja;
                }
                if (ime == (Form1.brojPolja-Math.Sqrt(Form1.brojPolja)))
                {
                    Desno();
                    Dolje();
                    DoljeDesno();
                    Kraj(sender, e);
                    return brojZatvorenihPolja;
                }
                if (ime ==  Form1.brojPolja-1)
                {
                    Dolje();
                    Lijevo();
                    DoljeLijevo();
                    Kraj(sender, e);
                    return brojZatvorenihPolja;
                }
            }
            return brojZatvorenihPolja ;//vraca broj zatvorenih polja (uvjeti pobjede: ako ima brojPolja-brojMina zatvorenih polja to znaci pobjedu)
        }
        int brojMina;
        private void PostaviBojuFonta()
        {
            switch (brojMina)
            {
                case 1: this.ForeColor = Color.Red; break;
                case 2: this.ForeColor = Color.Blue; break;
                case 3: this.ForeColor = Color.Green; break;
                case 4: this.ForeColor = Color.Yellow; break;
                case 5: this.ForeColor = Color.Orange; break;
                case 6: this.ForeColor = Color.Black; break;
                case 7: this.ForeColor = Color.White; break;
                case 8: this.ForeColor = Color.Teal; break;

            }

            this.Text = brojMina.ToString();
        }



        private void Kraj(object sender, MouseEventArgs e)
        {
            PostaviBojuFonta();
            //var t = Task.Run(async delegate
            //{
            //    await Task.Delay(500);
            //    return 42;
            //});
            //t.Wait();
            ////this.Enabled = false;
            this.BackColor = Color.LightGray;

            if (brojMina == 0)
            {
                this.Text = " ";

                int ime = int.Parse(this.Name);

                if ((ime + 1) % Math.Sqrt(Form1.brojPolja) != 0)//desno
                {
                    if (Form1.listaPolja[ime + 1].Text == "")
                        Form1.listaPolja[ime + 1].Polje_MouseUp(sender, e);
                }
                if (ime % Math.Sqrt(Form1.brojPolja) != 0 && ime != 0)//lijevo
                {
                    if (Form1.listaPolja[ime - 1].Text == "")
                        Form1.listaPolja[ime - 1].Polje_MouseUp(sender, e);
                }
                if (ime >= Math.Sqrt(Form1.brojPolja))//gore
                {
                    if (Form1.listaPolja[ime - int.Parse(Math.Sqrt(Form1.brojPolja).ToString())].Text == "")
                        Form1.listaPolja[ime - int.Parse(Math.Sqrt(Form1.brojPolja).ToString())].Polje_MouseUp(sender, e);
                }
                if (ime <= (Form1.brojPolja - Math.Sqrt(Form1.brojPolja) - 1))//dolje
                {
                    if (Form1.listaPolja[ime + int.Parse(Math.Sqrt(Form1.brojPolja).ToString())].Text == "")
                        Form1.listaPolja[ime + int.Parse(Math.Sqrt(Form1.brojPolja).ToString())].Polje_MouseUp(sender, e);
                }
                if ((ime <= (Form1.brojPolja - Math.Sqrt(Form1.brojPolja) - 2)) && (ime + 1) % Math.Sqrt(Form1.brojPolja) != 0)//dolje desno
                {
                    if (Form1.listaPolja[ime + int.Parse(Math.Sqrt(Form1.brojPolja).ToString()) + 1].Text == "")
                        Form1.listaPolja[ime + int.Parse(Math.Sqrt(Form1.brojPolja).ToString()) + 1].Polje_MouseUp(sender, e);
                }
                if ((ime >= Math.Sqrt(Form1.brojPolja)) && (ime + 1) % Math.Sqrt(Form1.brojPolja) != 0)//gore desno
                {
                    if (Form1.listaPolja[ime - int.Parse(Math.Sqrt(Form1.brojPolja).ToString()) + 1].Text == "")
                        Form1.listaPolja[ime - int.Parse(Math.Sqrt(Form1.brojPolja).ToString()) + 1].Polje_MouseUp(sender, e);
                }
                if (ime >= (Math.Sqrt(Form1.brojPolja) + 1) && ime != 0 && ime % Math.Sqrt(Form1.brojPolja) != 0)//gore lijevo
                {
                    if (Form1.listaPolja[ime - int.Parse(Math.Sqrt(Form1.brojPolja).ToString()) - 1].Text == "")
                        Form1.listaPolja[ime - int.Parse(Math.Sqrt(Form1.brojPolja).ToString()) - 1].Polje_MouseUp(sender, e);
                }
                if (ime <= (Form1.brojPolja - Math.Sqrt(Form1.brojPolja)) && ime % Math.Sqrt(Form1.brojPolja) != 0 && ime != 0)//dolje lijevo
                {
                    if (Form1.listaPolja[ime + int.Parse(Math.Sqrt(Form1.brojPolja).ToString()) - 1].Text == "")
                        Form1.listaPolja[ime + int.Parse(Math.Sqrt(Form1.brojPolja).ToString()) - 1].Polje_MouseUp(sender, e);
                }


            }
        }
        private void Sve()
        {
            Dolje();
            DoljeDesno();
            DoljeLijevo();
            Lijevo();
            Desno();
            GoreLijevo();
            Gore();
            GoreDesno();
        }
        private void SveLijevo()
        {
            Lijevo();
            DoljeLijevo();
            GoreLijevo();
        }
        private void SveDesno()
        {
            Desno();
            GoreDesno();
            DoljeDesno();
        }
        private void SveGore()
        {
            Gore();
            GoreDesno();
            GoreLijevo();
        }
        private void SveDolje()
        {
            Dolje();
            DoljeDesno();
            DoljeLijevo();
        }
        private void DoljeLijevo()
        {
            if (Form1.listaPolja[int.Parse(this.Name) - int.Parse(Math.Sqrt(Form1.brojPolja).ToString())-1].Mina == true)
            {
                brojMina++;
            }
        }
        private void Dolje()
        {
            if (Form1.listaPolja[int.Parse(this.Name) - int.Parse(Math.Sqrt(Form1.brojPolja).ToString())].Mina == true)
            {
                brojMina++;
            }
        }
        private void DoljeDesno()
        {
            if (Form1.listaPolja[int.Parse(this.Name) - int.Parse(Math.Sqrt(Form1.brojPolja).ToString())+1].Mina == true)
            {
                brojMina++;
            }
        }
        private void Lijevo()
        {
            if (Form1.listaPolja[int.Parse(this.Name) - 1].Mina == true)
            {
                brojMina++;
            }
        }
        private void Desno()
        {
            if (Form1.listaPolja[int.Parse(this.Name) + 1].Mina == true)
            {
                brojMina++;
            }
        }
        private void GoreLijevo()
        {
            if (Form1.listaPolja[int.Parse(this.Name) + int.Parse(Math.Sqrt(Form1.brojPolja).ToString())-1].Mina == true)
            {
                brojMina++;
            }
        }
        private void Gore()
        {
            if (Form1.listaPolja[int.Parse(this.Name) + int.Parse(Math.Sqrt(Form1.brojPolja).ToString())].Mina == true)
            {
                brojMina++;
            }
        }
        private void GoreDesno()
        {
            if (Form1.listaPolja[int.Parse(this.Name) + int.Parse(Math.Sqrt(Form1.brojPolja).ToString())+1].Mina == true)
            {
                brojMina++;
            }
        }

        static bool gameOver = false;
        public static bool zabraniClick = false;

        private void GameOver(object sender, MouseEventArgs e)
        {
            gameOver = true; //pocinje prikazivati svaki botun
            foreach (var polje in Form1.listaPolja)
            {
                if (polje.Text == "" || polje.Text == "Z")
                {
                    polje.Polje_MouseUp(sender, e);
                }
            }
            gameOver = false; //prikazao je sve botune
            zabraniClick = true;

        }
    }
}
