using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USFLibraryMgmtSystem
{
    internal class Library
    {
        public class library
        {
            // Collections to store books and patrons
            public List<Book> Books { get; set; }
            public List<Person> Patrons { get; set; }

            // Constructor
            public library()
            {
                Books = new List<Book>();
                Patrons = new List<Person>();
            }

            // Add a book to the library
            public void AddBook(Book book)
            {
                Books.Add(book);
            }

            // Add a patron (student/staff) to the library
            public void AddPatron(Person patron)
            {
                Patrons.Add(patron);
            }

            // Display all books in the library
            public void DisplayBooks()
            {
                Console.WriteLine("\nBooks in Library:");
                foreach (var book in Books)
                {
                    book.DisplayBook();
                }
            }

            // Display all patrons in the library
            public void DisplayPatrons()
            {
                Console.WriteLine("\nPatrons in Library:");
                foreach (var patron in Patrons)
                {
                    Console.WriteLine($"Name: {patron.Name}, ID: {patron.ID}");
                }
            }

            // Borrow a book for a patron
            public void BorrowBook(Person patron, string bookTitle)
            {
                Book book = Books.Find(b => b.Title.Equals(bookTitle, StringComparison.OrdinalIgnoreCase));

                if (book != null && book.BorrowBook())
                {
                    Console.WriteLine($"{patron.Name} borrowed '{book.Title}'");
                }
                else
                {
                    Console.WriteLine($"{patron.Name} could not borrow '{bookTitle}' (not available).");
                }
            }

            // Return a book for a patron
            public void ReturnBook(Person patron, string bookTitle)
            {
                Book book = Books.Find(b => b.Title.Equals(bookTitle, StringComparison.OrdinalIgnoreCase));

                if (book != null)
                {
                    book.ReturnBook();
                    Console.WriteLine($"{patron.Name} returned '{book.Title}'");
                }
                else
                {
                    Console.WriteLine($"'{bookTitle}' does not belong to this library.");
                }
            }
        }
    }
}
