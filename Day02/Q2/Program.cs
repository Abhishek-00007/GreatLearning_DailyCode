using System;

class Book
{
    public string Title;
    public string Author;
    public int Year;

    public Book(string title, string author, int year) {
        Title=title;
        Author=author;
        Year=year;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter book's title:");
        string title=Console.ReadLine();

        Console.WriteLine("Enter book's author:");
        string author=Console.ReadLine();

        Console.WriteLine("Enter book's year:");
        int year = Convert.ToInt32(Console.ReadLine());

        Book book = new Book(title, author, year);

        Console.WriteLine("Book Title: "+book.Title);
        Console.WriteLine("Book Author: "+book.Author);
        Console.WriteLine("Book Year: "+book.Year);
    }
}