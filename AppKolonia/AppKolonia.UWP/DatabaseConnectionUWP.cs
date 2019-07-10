using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Windows.Storage;

namespace AppKolonia.UWP
{
    class DatabaseConnectionUWP : IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "Uczestnicy.db3";

            var path = Path.Combine(ApplicationData.Current.LocalFolder.Path, dbName);

            return new SQLiteConnection(path);
        }
    }
}
