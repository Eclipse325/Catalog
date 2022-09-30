using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using BookCatalog.Model;
using BookCatalog.ViewModel;
using BookCatalog.FileService;

namespace BookCatalog
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {

        }

        private void OnStartup(object s, StartupEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.DataContext = new BookCatalogViewModel(new DialogService());
            mainWindow.Show();
        }
    }
}
