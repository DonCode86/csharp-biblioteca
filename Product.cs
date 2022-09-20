
// See https://aka.ms/new-console-template for more information

public class Product
{
    protected string title;
    protected int year;
    protected string category;
    protected bool isBorrowed;
    protected int shelfCode;
    protected string author;
    protected string serialNumber;

    public Product (string title, int year, string category, bool isBorrowed, int shelfCode, string author, string serialNumber)
    {
        this.title = title;
        this.year = year;
        this.category = category;
        this.isBorrowed = isBorrowed;
        this.shelfCode = shelfCode;
        this.author = author;
        this.serialNumber = serialNumber;
    }

    public string Title
    {
        get { return title; }
        
    }

    public bool IsBorrowed
    {
        get { return isBorrowed; }
        set { isBorrowed = value; }
    }

    public string SerialNumber
    {
        get
        {
            return this.serialNumber;
        }
    }
}