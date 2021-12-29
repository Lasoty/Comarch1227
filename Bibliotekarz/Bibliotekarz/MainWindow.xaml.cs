using Bibliotekarz.Model;
using Bibliotekarz.Services;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Bibliotekarz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly BookService bookService = new BookService();

        public ObservableCollection<Book> BookList { get; set; }
            = new ObservableCollection<Book>();

        public MainWindow()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            BookList.Clear();
            foreach (var item in bookService.GetBooks())
            {
                BookList.Add(item);
            }

            dgBooks.ItemsSource = BookList;
        }

        private void OnPlikZamknijClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void OnNewItemClick(object sender, RoutedEventArgs e)
        {
            BookWindow bookWindow = new BookWindow();
            if (bookWindow.ShowDialog() == true)
            {
                BookList.Add(bookWindow.BookProperty);
            }
        }

        private void OnExportDataClick(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV documents (.csv)|*.csv|Text documents (.txt)|*.txt";

            if (sfd.ShowDialog() == true)
            {
                bookService.SaveDataInFile(sfd.FileName, BookList);
            }

        }
    }
}
