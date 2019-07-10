using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppKolonia
{
    [Table("Uczestnicy")]
    public class Uczestnik: INotifyPropertyChanged
    {

        private int _id;
        [PrimaryKey, AutoIncrement]

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _imie;

        public string Imie
        {
            get
            {
                return _imie;
            }
            set
            {
                this._imie = value;
                OnPropertyChanged(nameof(Imie));
            }
        }

        private string _nazwisko;

        public string Nazwisko
        {
            get
            {
                return _nazwisko;
            }
            set
            {
                this._nazwisko = value;
                OnPropertyChanged(nameof(Nazwisko));
            }
        }

        private string _adres;

        public string Adres
        {
            get
            {
                return _adres;
            }
            set
            {
                this._adres = value;
                OnPropertyChanged(nameof(Adres));
            }
        }

        private string _urodziny;

        public string Urodziny
        {
            get
            {
                return _urodziny;
            }
            set
            {
                this._urodziny = value;
                OnPropertyChanged(nameof(Urodziny));
            }
        }

        private string _tel;

        public string Tel
        {
            get
            {
                return _tel;
            }
            set
            {
                this._tel = value;
                OnPropertyChanged(nameof(Tel));
            }
        }

        private string _email;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                this._email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
