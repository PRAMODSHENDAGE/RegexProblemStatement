using UserRegistration;
Console.WriteLine("Welcome to the User Registration Problem!");

User user = new User();
Console.WriteLine("\nEnter The First Name: ");
string firstName = Console.ReadLine();
user.FirstName(firstName);
