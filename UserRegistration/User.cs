using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class User
    {
        //UC 1 - FirstName Start with Cap & has Minimum 3 Characters.
        public const string FIRSTNAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public void FirstName(string firstname)
        {
            Regex regex = new Regex(FIRSTNAME_REGEX);
            bool result = regex.IsMatch(firstname);
            Console.WriteLine("UC-1: Entered First Name is " + result);
        }
        //UC 2 - LastName Start with Cap & has Minimum 3 Characters.
        public const string LASTNAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public void LastName(string lastname)
        {
            Regex regex = new Regex(LASTNAME_REGEX);
            bool result = regex.IsMatch(lastname);
            Console.WriteLine("UC-2: Entered Last Name is " + result);
        }
        //UC 3 Checking for Email Validation
        public const string EMAIL_REGEX = "^[a-z]{3}[.]{1}[0-9a-zA-Z]+[@]{1}[a-z]{2}[.]{1}[a-z]{2}[.]{1}[a-z]{2}$";
        public void Email(string email)
        {
            Regex regex = new Regex(EMAIL_REGEX);
            bool result = regex.IsMatch(email);
            Console.WriteLine("UC-3: Entered Email is " + result);
        }
        //UC 4 Checking for Phone Number Validation
        public const string PHONENUMBER_REGEX = "^[91]*[ ]*[0-9]{10}$";
        public void PhoneNumber(string phonenumber)
        {
            Regex regex = new Regex(PHONENUMBER_REGEX);
            bool result = regex.IsMatch(phonenumber);
            Console.WriteLine("UC-4: Entered Phone Number is " + result);
        }
        //UC 5 Password of Minimum 8 Characters.
        public const string PASSWORD_REGEX = "^[A-Za-z0-9]{8,}$";
        public void Password(string password)
        {
            Regex regex = new Regex(PASSWORD_REGEX);
            bool result = regex.IsMatch(password);
            Console.WriteLine("UC-5: Entered Password is " + result);
        }
        //UC 6 Password Should have atleast 1 Upper case
        public const string PASSWORD_CAPITAL_REGEX = "^[A-Z]{1}[a-z0-9]{7,}$";
        public void PasswordCapital(string passwordcapital)
        {
            Regex regex = new Regex(PASSWORD_CAPITAL_REGEX);
            bool result = regex.IsMatch(passwordcapital);
            Console.WriteLine("UC-6: Entered Password is " + result);
        }
        //UC 7 Password Should have atleast 1 Numeric Value
        public const string PASSWORD_NUMERIC_REGEX = "^[A-Z]{1}[0-9]{1}[a-zA-Z0-9]{6,}$";
        public void PasswordNumeric(string passwordnumeric)
        {
            Regex regex = new Regex(PASSWORD_NUMERIC_REGEX);
            bool result = regex.IsMatch(passwordnumeric);
            Console.WriteLine("UC-7: Entered Password is " + result);
        }
    }
}
