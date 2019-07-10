using System;
using System.Collections.Generic;
using System.Text;

namespace AppKolonia
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
