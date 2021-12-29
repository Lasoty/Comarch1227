using Bibliotekarz.Model;
using Bibliotekarz.Services;
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

namespace Bibliotekarz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly BookService bookService = new BookService();

        public List<Book> BookList { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            BookList = bookService.GetBooks();
            dgBooks.ItemsSource = BookList;
        }

        private void OnPlikZamknijClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
