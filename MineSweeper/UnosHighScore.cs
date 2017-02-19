using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class UnosHighScore : Form
    {
        public UnosHighScore(string minute,string sekunde,string razina)
        {
            high.Minute = minute;
            high.Sekunde = sekunde;
            high.Razina = razina;
            InitializeComponent();
        }

        private void Odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        HighScore high = new HighScore();

        private void Unesi_Click(object sender, EventArgs e)
        {
           high.Ime = textBox1.Text;
           high.UnesiHighScore();
           this.Close();

        }

        private void UnosHighScore_Load(object sender, EventArgs e)
        {

        }
    }
}
