
// See https://aka.ms/new-console-template for more information


Console.WriteLine("Inserisci il tuo nome");
string newName = Console.ReadLine();

Console.WriteLine("Inserisci il tuo cognome");
string newLastname = Console.ReadLine();

Console.WriteLine("Inserisci la tua email");
string newEmail = Console.ReadLine();

Console.WriteLine("Inserisci la tua password");
string newPassword = Console.ReadLine();

Console.WriteLine("Inserisci il tuo numero di cellulare");
string newPhoneNumber = Console.ReadLine();

User newUser = new User(newName, newLastname, newEmail, newPassword, newPhoneNumber);
