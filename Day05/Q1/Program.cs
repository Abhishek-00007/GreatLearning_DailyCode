using System;
using System.Collections;

// Step 1: Book class
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    // Constructor
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }
}

// Step 2: Library class
class Library
{
    private List<Book> books = new List<Book>();

    // Add book
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Book added successfully.");
    }

    // Remove book by ISBN
    public void RemoveBook(string isbn)
    {
        Book found = books.Find(b => b.ISBN == isbn);

        if (found != null)
        {
            books.Remove(found);
            Console.WriteLine("Book removed successfully.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    // List all books
    public void ListBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books in library.");
            return;
        }

        Console.WriteLine("\nLibrary Books:");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
        }
    }
}

// Step 3 & 4: Main Program
class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. List Books");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();

                    Console.Write("Enter ISBN: ");
                    string isbn = Console.ReadLine();

                    Book newBook = new Book(title, author, isbn);
                    library.AddBook(newBook);
                    break;

                case 2:
                    Console.Write("Enter ISBN to remove: ");
                    string removeIsbn = Console.ReadLine();
                    library.RemoveBook(removeIsbn);
                    break;

                case 3:
                    library.ListBooks();
                    break;

                case 4:
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}