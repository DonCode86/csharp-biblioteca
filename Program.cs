
// See https://aka.ms/new-console-template for more information
Library myLibrary = new Library("Biblioteca Ciccarelli");

Book BookOne = new Book("123456", 152, "Ciao", 1986, "Horror", 25, "Ciccarelli", 123456);
//Console.WriteLine(BookOne.Title);


//LOGIN UTENTE
//Console.WriteLine("Inserisci il tuo nome");
//string newName = Console.ReadLine();

//Console.WriteLine("Inserisci il tuo cognome");
//string newLastname = Console.ReadLine();

//Console.WriteLine("Inserisci la tua email");
//string newEmail = Console.ReadLine();

//Console.WriteLine("Inserisci la tua password");
//string newPassword = Console.ReadLine();

//Console.WriteLine("Inserisci il tuo numero di cellulare");
//string newPhoneNumber = Console.ReadLine();

//User newUser = new User(newName, newLastname, newEmail, newPassword, newPhoneNumber);


Console.WriteLine("Inserisci il titolo o il numero seriale del libro che vuoi cercare!");
string UserInputSearch = Console.ReadLine();


if (UserInputSearch == )
{
    Console.WriteLine("Libro non trovato");
} else
{
    Console.WriteLine("Il libro che hai cercato e' disponibile!");
}