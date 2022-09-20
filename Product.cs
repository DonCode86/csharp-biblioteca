
// See https://aka.ms/new-console-template for more information

public class Product
{
    private string title;
    private int year;
    private string category;
    private bool isBorrowed;
    private int shelfCode;
    private string author;

    public Product (string title, int year, string category, bool isBorrowed, int shelfCode, string author)
    {
        this.title = title;
        this.year = year;
        this.category = category;
        this.isBorrowed = isBorrowed;
        this.shelfCode = shelfCode;
        this.author = author;
    }
}