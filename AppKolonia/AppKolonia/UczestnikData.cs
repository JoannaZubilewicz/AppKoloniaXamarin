using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace AppKolonia
{
    class UczestnikData
    {
        private SQLiteConnection database;
        private static object collisionLock = new object();

        public ObservableCollection<Uczestnik> Uczestnicy { get; set; }

        public UczestnikData()
        {
            database = DependencyService.Get<IDatabaseConnection>().DbConnection();

            database?.CreateTable<Uczestnik>();

            Uczestnicy = new ObservableCollection<Uczestnik>(database.Table<Uczestnik>());



            //if (database.Table<Uczestnik>().Count()==0) //jezeli pusto - dodaj
            //{
            //    AddUczestnik(new Uczestnik()
            //    {
            //        Imie = "asd",
            //        Nazwisko = "dsa"
            //    });
            //}
        }

        public void AddUczestnik(Uczestnik u)
        {
            lock (collisionLock)//aby nie zachodzily dwa  procesy na raz w bazie danych....xd
            {
                if (u.Id != 0)
                {
                    database.Update(u);
                }
                else
                {
                    database.Insert(u);
                }
            }
            Uczestnicy.Add(u);
        }

        public void Usuwanie_Listy()
        {
            database.DropTable<Uczestnik>();
            Uczestnicy.Clear();
        }
    }
}
