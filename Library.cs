
// See https://aka.ms/new-console-template for more information

public class Library
{
    private string name;
    private List<string> books;
    private List<string> dvd;

    public Library(string name)
    {
        this.name = name;
    }

    public List<string> Books
    {
        get { return books; }
        set { books = value; }
    }

    public List<string> Dvd
    {
        get { return dvd; }
        set { dvd = value; }
    }
    
}