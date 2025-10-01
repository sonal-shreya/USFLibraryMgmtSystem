using System;

using System.Collections.Generic;

namespace USFLibraryMgmtSystem

{

    internal class Library

    {

        // Collections to store books and patrons

        public List<Book> Books { get; set; }

        public List<Person> Patrons { get; set; }

        // Constructor

        public Library()

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

                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");

            }

            Console.WriteLine();

        }

        // Display all patrons in the library

        public void DisplayPatrons()

        {

            Console.WriteLine("\nPatrons in Library:");

            foreach (var patron in Patrons)

            {

                Console.WriteLine($"Name: {patron.Name}, ID: {patron.id}");

            }

            Console.WriteLine();

        }

        // Borrow a book for a patron

        public void BorrowBook(string patronName, string bookTitle)

        {

            Person patron = Patrons.Find(p => p.Name.Equals(patronName, StringComparison.OrdinalIgnoreCase));

            Book book = Books.Find(b => b.Title.Equals(bookTitle, StringComparison.OrdinalIgnoreCase));

            if (patron != null && book != null && book.BorrowBook())

            {

                Console.WriteLine($"{patron.Name} borrowed '{book.Title}'");

            }

            else

            {

                Console.WriteLine($"{patronName} could not borrow '{bookTitle}' (not available).");

            }

        }

        // Return a book for a patron

        public void ReturnBook(string patronName, string bookTitle)

        {

            Person patron = Patrons.Find(p => p.Name.Equals(patronName, StringComparison.OrdinalIgnoreCase));

            Book book = Books.Find(b => b.Title.Equals(bookTitle, StringComparison.OrdinalIgnoreCase));

            if (patron != null && book != null)

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

