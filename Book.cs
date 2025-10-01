using System;

namespace USFLibraryMgmtSystem
{
	public class Book
	{
		// Properties
		public string Title { get; set; }
		public string Author { get; set; }
		public string ISBN { get; set; }
		public int AvailableCopies { get; set; }

		// Constructor
		public Book(string title, string author, string isbn, int availableCopies)
		{
			Title = title;
			Author = author;
			ISBN = isbn;
			AvailableCopies = availableCopies;
		}

		// Method to borrow a book
		public bool BorrowBook()
		{
			if (AvailableCopies > 0)
			{
				AvailableCopies--;
				return true; // Borrow successful
			}
			else
			{
				Console.WriteLine($"'{Title}' is not available right now.");
				return false; // Borrow failed
			}
		}

		// Method to return a book
		public void ReturnBook()
		{
			AvailableCopies++;
		}

		// Method to display book details
		public void DisplayBook()
		{
			Console.WriteLine($"Title: {Title}, Author: {Author}, Available Copies: {AvailableCopies}");
		}
	}
}

