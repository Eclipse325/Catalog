using BookCatalog.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;


namespace BookCatalog.ViewModel 
{
    public class BooksCollection : ViewModelBase
    {
        public class BookWithPicture : ViewModelBase
        {
            string pictureUri;
            Book book;
            public Book Book
            {
                get { return book; }
                set
                {
                    book = value;
                    OnPropertyChanged("Book");
                }
            }
            public string PictureUri
            {
                get { return pictureUri; }
                set
                {
                    pictureUri = value;
                    OnPropertyChanged("PictureUri");
                }
            }

            public BookWithPicture(Book book)
            {
                Book = book;
                PictureUri = book.Picture;
            }

            public BookWithPicture()
            {
                Book = new Book();
                PictureUri = string.Empty;
            }
        }

        public ObservableCollection<BookWithPicture> books;

        public BooksCollection(List<Book> list)
        {
            books = new ObservableCollection<BookWithPicture>();
            foreach(var book in list)
            {
                books.Add(new BookWithPicture(book));
            }
        }

        public void Refresh(List<Book> list)
        {
            books = new ObservableCollection<BookWithPicture>();
            foreach (var book in list)
            {
                books.Add(new BookWithPicture(book));
            }
        }
    }
}
