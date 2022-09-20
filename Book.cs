
// See https://aka.ms/new-console-template for more information

public class Book : Product
{
    private string isbn;
    private int pages;
    public Book(string isbn, int pages, string title, int year, string category, bool isBorrowed, int shelfCode, string author) : base(title, year, category, isBorrowed, shelfCode, author)
    {
        this.isbn = isbn;
        this.pages = pages;
    }
}
