using System;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace USFLibraryMgmtSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Staff staff1 = new Staff
            {
                Name = "Grandon Gill",
                EmailId = "grandon@usf.edu",
                id = "ST001",
                Position = "Librarian",
                Department = "Library Services"
            };

            Student student1 = new Student
            {
                Name = "Akhil",
                EmailId = "akhil@usf.edu",
                id = "S001",
                Major = "Business Analytics",
                GraduationYear = 2026
            };

            Student student2 = new Student
            {
                Name = "Sandeep",
                EmailId = "sandeep@usf.edu",
                id = "S002",
                Major = "Information Systems",
                GraduationYear = 2025
            };

            Book book1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            Book book2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            Book book3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);



            // Create Library
            Library library = new Library();


            // Add Books
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            // Add Patrons
            library.AddPatron(student1);
            library.AddPatron(student2);
            library.AddPatron(staff1);

            // Display Initial Books
            library.DisplayBooks();

            // Display Patrons
            library.DisplayPatrons();

            // Borrow Books
            Console.WriteLine("Borrowing Books...");
            library.BorrowBook("Sandeep", "Business Insights with AI");
            library.BorrowBook("Akhil", "Analytics in Action");
            Console.WriteLine();

            // Display Books After Borrowing
            Console.WriteLine("Books after borrowing:");
            library.DisplayBooks();

        }
    }
}
