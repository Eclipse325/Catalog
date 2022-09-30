using System;
using System.Collections.Generic;
using System.Text;

namespace BookCatalog.FileService
{
    using Microsoft.Win32;
    using System.Windows;

    public class DialogService : IDialogService
    {
        public string FilePath { get; set; }

        public string OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.bmp;*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
                return FilePath;
            }
            return string.Empty;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }

}
