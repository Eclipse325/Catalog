using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BookCatalog.FileService;
using BookCatalog.Model;
using BookCatalog.ViewModel;
using Microsoft.Win32;

namespace BookCatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            this.DataContext = new BookCatalogViewModel(new DialogService());
        }

        #region FileSelection
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.bmp;*.jpg;*.jpeg;*.png";
            //dialog.FilterIndex = 1;

            if (dialog.ShowDialog() == true)
            {
                string fileName = dialog.FileName;
                newBookBtn.Content = fileName;
            }
        }

        private void selectedBookBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.bmp;*.jpg;*.jpeg;*.png";
            //dialog.FilterIndex = 1;

            if (dialog.ShowDialog() == true)
            {
                string fileName = dialog.FileName;
                selectedBookBtn.Content = fileName;
            }
        }
        #endregion
    }
}
