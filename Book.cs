
// See https://aka.ms/new-console-template for more information

public class Book : Product
{
    private int isbn;
    private int pages;
    public Book(int isbn, int pages, string title, int year, string category, bool isBorrowed, int shelfCode, string author) : base(title, year, category, isBorrowed, shelfCode, author)
    {
        this.isbn = isbn;
        this.pages = pages;
    }
}
