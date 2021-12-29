using Bibliotekarz.Model;
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
using System.Windows.Shapes;

namespace Bibliotekarz
{
    /// <summary>
    /// Interaction logic for BookWindow.xaml
    /// </summary>
    public partial class BookWindow : Window
    {
        public Book BookProperty { get; set; }

        public BookWindow()
        {
            InitializeComponent();
            BookProperty = new Book
            {
                Borrower = new Customer()
            };
            this.DataContext = BookProperty;
        }

        private void OnSaveClick(object sender, RoutedEventArgs e)
        {
            if (!BookProperty.IsBorrowed)
            {
                BookProperty.Borrower = null;
            }
            this.DialogResult = true;
            this.Hide();
        }
    }
}
