using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    class HighScore
    {
        public string Ime { get; set; }
        public string Minute { get; set; }
        public string Sekunde { get; set; }
        public string Vrijeme { get; set; }
        public string Razina { get; set; }

        SQLiteConnection Connection;

        public HighScore()
        {
            Connection = new SQLiteConnection("Data Source=HighScore.sqlite;Version=3;");
            Connection.Open();


        }

        public void UnesiHighScore()
        {
            string ins = "insert into highscores values ('"+Ime+"', '"+Minute+"','"+Sekunde+"','"+Razina+"')";
            SQLiteCommand command = new SQLiteCommand(ins, Connection);
            command.ExecuteNonQuery();
        }

        public List<HighScore> dohvatiHighscore(string razina)
        {
            List<HighScore> lista = new List<HighScore>();
            string sql = "select * from highscores WHERE Razina = '"+razina+"' order by Minute,Sekunde";
            SQLiteCommand command = new SQLiteCommand(sql, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                HighScore highscore = new HighScore();
                highscore.Ime = reader["Ime"].ToString();
                highscore.Minute = reader["Minute"].ToString();
                highscore.Sekunde = reader["Sekunde"].ToString();
                highscore.Razina = reader["Razina"].ToString();
                highscore.Vrijeme = highscore.Minute + ":" + highscore.Sekunde;
                lista.Add(highscore);
            }
            return lista;
        }


    }
}
