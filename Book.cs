
// See https://aka.ms/new-console-template for more information

public class Book : Product
{
    protected int isbn;
    protected int pages;
    public Book(int isbn, int pages, string title, int year, string category, bool isBorrowed, int shelfCode, string author, string serialNumber) : base(title, year, category, isBorrowed, shelfCode, author, serialNumber)
    {
        this.isbn = isbn;
        this.pages = pages;
    }
}
