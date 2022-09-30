using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using BookCatalog.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookCatalog.Commands;
using System.Windows.Media.Imaging;
using BookCatalog.FileService;

namespace BookCatalog.ViewModel
{
    public class BookCatalogViewModel : ViewModelBase
    {
        IDialogService dialogService;
        ServiceProvider serviceProvider;
        CatalogModel catalog;
        ObservableCollection<Book> booksList;
        BooksCollection bookCollection;
        Book selectedBook;
        Book newBook;

        public BitmapImage Image { get; set; }

        string str;
        public string Str { get { return str; } set { str = value; OnPropertyChanged("Str"); } }

        RelayCommand addButtonClick;
        RelayCommand updateButtonClick;
        RelayCommand deleteButtonClick;
        RelayCommand openCommand;
        

        #region Properties

        public ObservableCollection<Book> BooksList
        {
            get { return booksList; }
            set
            {
                booksList = value;
                OnPropertyChanged("BooksList");
            }
        }

        public BooksCollection BookCollection
        {
            get { return bookCollection; }
            set
            {
                bookCollection = value;
                OnPropertyChanged("BookCollection");
            }
        }

        public Book SelectedBook
        {
            get { return selectedBook; }
            set
            {
                selectedBook = value;
                OnPropertyChanged("SelectedBook");
            }
        }
        BooksCollection.BookWithPicture selectedBookWP;
        public BooksCollection.BookWithPicture SelectedBookWP
        {
            get { return selectedBookWP; }
            set
            {
                selectedBookWP = value;
                OnPropertyChanged("SelectedBookWP");
            }
        }

        public Book NewBook
        {
            get { return newBook; }
            set
            {
                newBook = value;
                OnPropertyChanged("NewBook");
            }
        }
        #endregion

        #region Constuctor

        public BookCatalogViewModel(IDialogService dialogService)
        {
            this.dialogService = dialogService;
            ServiceCollection services = new ServiceCollection();
            services.AddDbContext<BookDbContext>(option =>
            {
                option.UseSqlite("Data Source = Book.db");
            });

            services.AddSingleton<CatalogModel>();
            serviceProvider = services.BuildServiceProvider();

            catalog = serviceProvider.GetService<CatalogModel>();
            BooksList = new ObservableCollection<Book>(catalog.GetBooks());
            /*foreach(var item in BooksList)
            {
                item.OnPropertyChanged("Picture");
            }*/
            Str = @"C:\testpic.jpg";
            newBook = new Book();
            SelectedBook = new Book();
            //SelectedBookWP = new BooksCollection.BookWithPicture();
        }
        #endregion

        #region Public Methods


        #endregion

        #region Private Methods

        private void Add()
        {
            catalog.Add(newBook);
            BooksList = new ObservableCollection<Book>(catalog.GetBooks());
            /*foreach (var item in BooksList)
            {
                item.OnPropertyChanged("Picture");
            }*/
            newBook = new Book();
            OnPropertyChanged("NewBook");
        }
        private void Update()
        {
            catalog.Update(SelectedBook);
            BooksList = new ObservableCollection<Book>(catalog.GetBooks());
            /*foreach (var item in BooksList)
            {
                item.OnPropertyChanged("Picture");
            }*/
        }
        private void Delete()
        {
            catalog.Delete(SelectedBook);
            BooksList = new ObservableCollection<Book>(catalog.GetBooks());
            foreach (var item in BooksList)
            {
                item.OnPropertyChanged("Picture");
            }
        }
        #endregion

        #region Comamnds

        public RelayCommand AddButtonClick
        {
            get
            {
                return addButtonClick ??
                  (addButtonClick = new RelayCommand(obj =>
                  {
                      Add();
                  }));
            }
        }

        public RelayCommand UpdateButtonClick
        {
            get
            {
                return updateButtonClick ??
                  (updateButtonClick = new RelayCommand(obj =>
                  {
                      Update();
                  }));
            }
        }

        public RelayCommand DeleteButtonClick
        {
            get
            {
                return deleteButtonClick ??
                  (deleteButtonClick = new RelayCommand(param =>
                  {
                      Delete();
                  }));
            }
        }

        public RelayCommand OpenCommand
        {
            get
            {
                return openCommand ??
                  (openCommand = new RelayCommand(obj =>
                  {
                      if ((obj as string) == "selected")
                      {
                          SelectedBook.Picture = dialogService.OpenFileDialog();
                      }
                      else if ((obj as string) == "new")
                      {
                          NewBook.Picture = dialogService.OpenFileDialog();
                      }
                  }));
            }
        }

        #endregion

    }
}
