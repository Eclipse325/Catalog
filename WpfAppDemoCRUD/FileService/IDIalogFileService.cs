using System;
using System.Collections.Generic;
using System.Text;

namespace BookCatalog.FileService
{
    public interface IDialogService
    {
        void ShowMessage(string message);   // показ сообщения
        string FilePath { get; set; }   // путь к выбранному файлу
        string OpenFileDialog();  // открытие файла
    }
}
