using Bibliotekarz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekarz.Services
{
    internal class BookService
    {
        public BookService()
        {

        }


        public List<Book> GetBooks()
        {
            return GetFakeBooks();
        }

        private List<Book> GetFakeBooks()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book 
            {
                Id = 1,
                Author = "Leszek Lewandowski",
                Title = "Programowanie w C#",
                PageCount = 456,
                IsBorrowed = true,
                Borrower = new Customer
                {
                    Id = 1,
                    FirstName = "Adam",
                    LastName = "Nowak"
                }
            });            
            
            books.Add(new Book 
            {
                Id = 2,
                Author = "John Sharp",
                Title = "Visual Studio krok po kroku",
                PageCount = 456,
                IsBorrowed = true,
                Borrower = new Customer
                {
                    Id = 2,
                    FirstName = "Jan",
                    LastName = "Kowalski"
                }
            });          
            
            books.Add(new Book 
            {
                Id = 3,
                Author = "Roy Osherove",
                Title = "Testy jednostkowe",
                PageCount = 456,
                IsBorrowed = false
            });



            Book book = books[0];
            books.Remove(book);

            Dictionary<int, Book> bookDictionary = new Dictionary<int, Book>();
            bookDictionary.Add(1, new Book
            {
                Id = 1,
                Author = "Leszek Lewandowski",
                Title = "Programowanie w C#",
                PageCount = 456,
                IsBorrowed = true,
                Borrower = new Customer
                {
                    Id = 1,
                    FirstName = "Adam",
                    LastName = "Nowak"
                }
            });

            Book book2 = bookDictionary[1];
            bookDictionary.Remove(1);

            Queue<Book> bookQueue = new Queue<Book>();
            bookQueue.Enqueue(book);
            bookQueue.Enqueue(book);
            bookQueue.Enqueue(book);

            Book book3 = bookQueue.Dequeue();
            Book book4 = bookQueue.Peek();

            Stack<Book> stackBooks = new Stack<Book>();
            stackBooks.Push(book3);
            Book book5 =  stackBooks.Pop();
            Book book6 =  stackBooks.Peek();

            return books;
        }
    }
}
