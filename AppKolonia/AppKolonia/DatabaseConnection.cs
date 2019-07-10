using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;

namespace AppKolonia
{
    class DatabaseConnection : IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "UczestnicyDB.db3";
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);

            return new SQLiteConnection(path);
        }
    }
}
