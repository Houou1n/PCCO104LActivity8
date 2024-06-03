using System;

public class Book
{

    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }


    private bool isAvailable;
    private int numberOfPages;
    private string genre;


    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        PublicationYear = 0;
        isAvailable = true;
        numberOfPages = 0;
        genre = "Unknown";
    }


    public Book(string title, string author, int publicationYear)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
        isAvailable = true;
        numberOfPages = 0;
        genre = "Unknown";
    }


    public Book(string title, string author, int publicationYear, bool isAvailable, int numberOfPages, string genre)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
        this.isAvailable = isAvailable;
        this.numberOfPages = numberOfPages;
        this.genre = genre;
    }


    public void BorrowBook()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine("You've borrowed the book. Please return it on time.");
        }
        else
        {
            Console.WriteLine("Sorry, the book is currently not available.");
        }
    }

    public void ReturnBook()
    {
        isAvailable = true;
        Console.WriteLine("Thank you for returning the book.");
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Publication Year: {PublicationYear}");
    }
}

public class Program
{
    static void Main(string[] args)
    {

        Book book1 = new Book("One Piece", "Eiichiro Oda", 1997);
        Book book2 = new Book("1984", "George Orwell", 1949);
        Book book3 = new Book("To Kill a Mockingbird", "Harper Lee", 1960, true, 281, "Fiction");


        book1.DisplayBookInfo();
        book2.DisplayBookInfo();
        book3.DisplayBookInfo();
    }
}