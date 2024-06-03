using System;

public interface IBorrowable
{
    void BorrowItem();
    void ReturnItem();
}

public abstract class LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }

    protected bool isAvailable;
    protected int numberOfPages;
    protected string genre;

    public LibraryItem()
    {
        Title = "Unknown";
        Author = "Unknown";
        PublicationYear = 0;
        isAvailable = true;
        numberOfPages = 0;
        genre = "Unknown";
    }

    public LibraryItem(string title, string author, int publicationYear)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
        isAvailable = true;
        numberOfPages = 0;
        genre = "Unknown";
    }

    public LibraryItem(string title, string author, int publicationYear, bool isAvailable, int numberOfPages, string genre)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
        this.isAvailable = isAvailable;
        this.numberOfPages = numberOfPages;
        this.genre = genre;
    }

    public abstract void DisplayItemInfo();
}

public class Book : LibraryItem, IBorrowable
{
    public Book() : base() { }

    public Book(string title, string author, int publicationYear)
        : base(title, author, publicationYear) { }

    public Book(string title, string author, int publicationYear, bool isAvailable, int numberOfPages, string genre)
        : base(title, author, publicationYear, isAvailable, numberOfPages, genre) { }

    public void BorrowItem()
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

    public void ReturnItem()
    {
        isAvailable = true;
        Console.WriteLine("Thank you for returning the book.");
    }

    public override void DisplayItemInfo()
    {
        Console.WriteLine($"Book - Title: {Title}, Author: {Author}, Publication Year: {PublicationYear}, Pages: {numberOfPages}, Genre: {genre}");
    }
}

public class Magazine : LibraryItem, IBorrowable
{
    public int IssueNumber { get; set; }

    public Magazine() : base()
    {
        IssueNumber = 0;
    }

    public Magazine(string title, string author, int publicationYear, int issueNumber)
        : base(title, author, publicationYear)
    {
        IssueNumber = issueNumber;
    }

    public Magazine(string title, string author, int publicationYear, bool isAvailable, int numberOfPages, string genre, int issueNumber)
        : base(title, author, publicationYear, isAvailable, numberOfPages, genre)
    {
        IssueNumber = issueNumber;
    }

    public void BorrowItem()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine("You've borrowed the magazine. Please return it on time.");
        }
        else
        {
            Console.WriteLine("Sorry, the magazine is currently not available.");
        }
    }

    public void ReturnItem()
    {
        isAvailable = true;
        Console.WriteLine("Thank you for returning the magazine.");
    }

    public override void DisplayItemInfo()
    {
        Console.WriteLine($"Magazine - Title: {Title}, Author: {Author}, Publication Year: {PublicationYear}, Issue Number: {IssueNumber}, Pages: {numberOfPages}, Genre: {genre}");
    }
}

public class Journal : LibraryItem, IBorrowable
{
    public string Editor { get; set; }

    public Journal() : base()
    {
        Editor = "Unknown";
    }

    public Journal(string title, string author, int publicationYear, string editor)
        : base(title, author, publicationYear)
    {
        Editor = editor;
    }

    public Journal(string title, string author, int publicationYear, bool isAvailable, int numberOfPages, string genre, string editor)
        : base(title, author, publicationYear, isAvailable, numberOfPages, genre)
    {
        Editor = editor;
    }

    public void BorrowItem()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine("You've borrowed the journal. Please return it on time.");
        }
        else
        {
            Console.WriteLine("Sorry, the journal is currently not available.");
        }
    }

    public void ReturnItem()
    {
        isAvailable = true;
        Console.WriteLine("Thank you for returning the journal.");
    }

    public override void DisplayItemInfo()
    {
        Console.WriteLine($"Journal - Title: {Title}, Author: {Author}, Publication Year: {PublicationYear}, Editor: {Editor}, Pages: {numberOfPages}, Genre: {genre}");
    }
}

public class DigitalMedia : LibraryItem, IBorrowable
{
    public double FileSize { get; set; } 
    public DigitalMedia() : base()
    {
        FileSize = 0.0;
    }

    public DigitalMedia(string title, string author, int publicationYear, double fileSize)
        : base(title, author, publicationYear)
    {
        FileSize = fileSize;
    }

    public DigitalMedia(string title, string author, int publicationYear, bool isAvailable, int numberOfPages, string genre, double fileSize)
        : base(title, author, publicationYear, isAvailable, numberOfPages, genre)
    {
        FileSize = fileSize;
    }

    public void BorrowItem()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine("You've borrowed the digital media. Enjoy your reading!");
        }
        else
        {
            Console.WriteLine("Sorry, the digital media is currently not available.");
        }
    }

    public void ReturnItem()
    {
        isAvailable = true;
        Console.WriteLine("Thank you for returning the digital media.");
    }

    public override void DisplayItemInfo()
    {
        Console.WriteLine($"Digital Media - Title: {Title}, Author: {Author}, Publication Year: {PublicationYear}, File Size: {FileSize}MB, Pages: {numberOfPages}, Genre: {genre}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("One Piece", "Eiichiro Oda", 1997, true, 1045, "Manga");
        Magazine magazine1 = new Magazine("National Geographic", "Various Authors", 2020, true, 120, "Science", 500);
        Journal journal1 = new Journal("Nature", "Various Authors", 2021, true, 95, "Science", "John Smith");
        DigitalMedia digitalMedia1 = new DigitalMedia("E-book: C# Programming", "Microsoft", 2019, true, 0, "Education", 150.5);

        book1.DisplayItemInfo();
        magazine1.DisplayItemInfo();
        journal1.DisplayItemInfo();
        digitalMedia1.DisplayItemInfo();

        book1.BorrowItem();
        book1.ReturnItem();

        magazine1.BorrowItem();
        magazine1.ReturnItem();

        journal1.BorrowItem();
        journal1.ReturnItem();

        digitalMedia1.BorrowItem();
        digitalMedia1.ReturnItem();
    }
}
