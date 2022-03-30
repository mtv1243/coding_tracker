using System;

using System.Data.SQLite;
using System.IO;

namespace coding_tracker
{
    class DbController
    {
        public DbController()
        {
            if (!File.Exists("coding_tracker.sqlite"))
            {
                Console.WriteLine("No DB file found");
                SQLiteConnection.CreateFile("coding_tracker.sqlite");

                SQLiteConnection initConnection = new("Data Source=coding_tracker.sqlite;Version=3");

                string sql = "CREATE TABLE coding_tracker (id INTEGER PRIMARY KEY, date STRING, startTime STRING, endTime STRING, duration STRING)";
                SQLiteCommand createTable = new(sql, initConnection);

            }
        }
    }
}
