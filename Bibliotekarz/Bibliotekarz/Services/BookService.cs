using Bibliotekarz.Data;
using Bibliotekarz.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
            //return GetFakeBooks();
            List<Book> results;
            using(ApplicationDataContext dbContext = new ApplicationDataContext())
            {
                results = dbContext.Books
                    .Where(book => book.PageCount > 0)
                    .Include(book => book.Borrower)
                    .OrderByDescending(book => book.Title)
                    .ThenBy(book => book.Author)
                    .ToList();
            }
            return results;
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
            //Book book6 =  stackBooks.Peek();

            return books;
        }

        internal void AddBook(Book book)
        {
            using(ApplicationDataContext dbContext = new ApplicationDataContext())
            {
                dbContext.Books.Add(book);
                dbContext.SaveChanges();
            }

        }

        internal void EditBook(Book book)
        {
            using (ApplicationDataContext dbContext = new ApplicationDataContext())
            {
                Book entity = dbContext.Books.FirstOrDefault(x => x.Id == book.Id);
                if (entity != null)
                {
                    entity.Title = book.Title;
                    entity.Author = book.Author;
                    entity.PageCount = book.PageCount;
                    entity.IsBorrowed = book.IsBorrowed;

                    dbContext.Books.Update(entity);
                    dbContext.SaveChanges();
                }
            }
        }

        internal void SaveDataInFile(string fileName, ICollection<Book> bookList)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{nameof(Book.Id)};{nameof(Book.Title)};{nameof(Book.Author)};{nameof(Book.PageCount)};{nameof(Book.IsBorrowed)};{nameof(Customer.Id)};{nameof(Customer.FirstName)};{nameof(Customer.LastName)}");

            foreach (Book item in bookList)
            {
                stringBuilder.Append(item.Id).Append(";");
                stringBuilder.Append(item.Title).Append(";");
                stringBuilder.Append(item.Author).Append(";");
                stringBuilder.Append(item.PageCount).Append(";");
                stringBuilder.Append(item.IsBorrowed).Append(";");

                if (item.Borrower != null)
                {
                    stringBuilder.Append(item.Borrower.Id).Append(";");
                    stringBuilder.Append(item.Borrower.FirstName).Append(";");
                    stringBuilder.Append(item.Borrower.LastName);
                }
                else
                {
                    stringBuilder.Append(";;");
                }
                stringBuilder.AppendLine();
            }

            File.WriteAllText(fileName, stringBuilder.ToString());
        }
    }
}
