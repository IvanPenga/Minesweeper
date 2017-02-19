using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    class SQLite
    {
        SQLiteConnection Connection;
        public SQLite()
        {
            Connection = new SQLiteConnection("Data Source=HighScore.sqlite;Version=3;");
            Connection.Open();
        }

          
    }
}
