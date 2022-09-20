
// See https://aka.ms/new-console-template for more information

public class Dvd : Product
{
    private int serialNumber;
    private int duration;
    public Dvd(int serialNumber, int duration, string title, int year, string category, bool isBorrowed, int shelfCode, string author) : base(title, year, category, isBorrowed, shelfCode, author)
    {
        this.serialNumber = serialNumber;
        this.duration = duration;
    }
}