# USF Library Management System 

A simple **Object-Oriented Programming (OOP)** project built in C# to simulate a library system for the University of South Florida (USF).  

This project demonstrates the use of **inheritance, encapsulation, and object-oriented design principles**, while also practicing **GitHub collaboration and version control**.

---

## Features
- Manage **Books**, **Students**, and **Staff**
- Borrow and return books with validation
- Display available books and registered patrons
- Track book availability in real-time

---

## Classes Implemented
- **Person** → Base class with `Name`, `Email`, and `ID`
- **Student** → Inherits from `Person`, adds `Major` and `GraduationYear`
- **Staff** → Inherits from `Person`, adds `Position` and `Department`
- **Book** → Represents a book with `Title`, `Author`, `ISBN`, `AvailableCopies`
- **Library** → Manages collections of books and patrons with methods:
  - `AddBook()`
  - `AddPatron()`
  - `DisplayBooks()`
  - `DisplayPatrons()`
  - `BorrowBook()`
  - `ReturnBook()`

---

## Example Scenario
- **Books Added**:  
  - *The Art of Data Strategy* (4 copies)  
  - *Business Insights with AI* (3 copies)  
  - *Analytics in Action* (6 copies)  

- **Patrons Added**:  
  - Student: Akhil  
  - Student: Sandeep  
  - Staff: Grandon Gill  

- **Borrowing**:  
  - Sandeep borrows *Business Insights with AI*  
  - Akhil borrows *Analytics in Action*  
