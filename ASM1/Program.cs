using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

class Program
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublicationDate { get; set; }
    }

     static List<Book> library = new List<Book>();

    static void AddBook()
    {
        Book newBook = new Book();
        Console.Write("Enter Book ID: ");
        newBook.Id = int.Parse(Console.ReadLine());
        Console.Write("Enter Book Title: ");
        newBook.Title = Console.ReadLine();
        Console.Write("Enter Author: ");
        newBook.Author = Console.ReadLine();
        Console.Write("Enter Publication Date: ");
        newBook.PublicationDate = Console.ReadLine();
        library.Add(newBook);
        Console.WriteLine("Book added successfully!");
    }

    static void DeleteBook()
    {
        Console.Write("Enter ID of the book to delete: ");
        int bookId = int.Parse(Console.ReadLine());

        for (int i = 0; i < library.Count; i++)
        {
            if (library[i].Id == bookId)
            {
                library.RemoveAt(i);
                Console.WriteLine("Book deleted successfully!");
                return;
            }
        }

        Console.WriteLine("Book not found.");
    }

    static void UpdateBook()
    {
        Console.Write("Enter the ID of the book to update: ");
        int bookId = int.Parse(Console.ReadLine());

        for (int i = 0; i < library.Count; i++)
        {
            if (library[i].Id == bookId)
            {
                Console.WriteLine($"Enter new information for book with ID {bookId}:");
                Console.Write("New title: ");
                library[i].Title = Console.ReadLine();
                Console.Write("New author: ");
                library[i].Author = Console.ReadLine();
                Console.Write("New publication date: ");
                library[i].PublicationDate = Console.ReadLine();
                Console.WriteLine("Book information has been updated.");
                return;
            }
        }

        Console.WriteLine("Book not found for updating.");
    }
    static void DisplayBooks()
    {
        if (library.Count == 0)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Console.WriteLine("Books in the library:");
        foreach (var book in library)
        {
            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Publication Date: {book.PublicationDate}");
        }
    }

    // The ToLower() method is used for case-insensitive comparisons while sSearching by book title.
    //
    static void SearchBook()
    {
        Console.Write("Enter ID of the book to search: ");
        int bookId = int.Parse(Console.ReadLine());

        foreach (var book in library)
        {
            if (book.Id == bookId)
            {
                Console.WriteLine("Book found:");
                Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Publication Date: {book.PublicationDate}");
                return;
            }
        }

        Console.WriteLine("Book not found.");
    }

    static void Main(string[] args)
    {
        int choice;

        while (true)
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Update Book");
            Console.WriteLine("3. View All Books");
            Console.WriteLine("4. Search Book");
            Console.WriteLine("5. Remove Book");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    UpdateBook();
                    break;
                case 3:
                    DisplayBooks();
                    break;
                case 4:
                    SearchBook();
                    break;
                case 5:
                    DeleteBook();
                    break;
                case 6:
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}
