using UserRegistration;
Console.WriteLine("Welcome to the User Registration Problem!");

User user = new User();
Console.WriteLine("\nEnter The First Name: ");
string firstName = Console.ReadLine();
user.FirstName(firstName);

Console.WriteLine("\nEnter The Last Name: ");
string lastname = Console.ReadLine();
user.LastName(lastname);

Console.WriteLine("\nEnter The Email: ");
string email = Console.ReadLine();
user.Email(email);

Console.WriteLine("\nEnter The Phone Number: ");
string phonenumber = Console.ReadLine();
user.PhoneNumber(phonenumber);

Console.WriteLine("\nEnter Password having Minimum 8 Characters: ");
string password = Console.ReadLine();
user.Password(password);

Console.WriteLine("\nEnter Password having atleast one Upper Case: ");
string passwordcapital = Console.ReadLine();
user.PasswordCapital(passwordcapital);

Console.WriteLine("\nEnter Password having atleast one Numeric Value: ");
string passwordnumeric = Console.ReadLine();
user.PasswordNumeric(passwordnumeric);