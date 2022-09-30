using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BookCatalog.Model
{
    public class Book : INotifyPropertyChanged
    {
        int id;
        string name;
        string author;
        int year;
        string isbn;
        string picture;
        string description;
        public int Id { get { return id; } set { id = value; OnPropertyChanged("Id"); } }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public string Picture { get { return picture; } set { picture = value; 
                OnPropertyChanged("Picture"); } }
        public string Description { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
