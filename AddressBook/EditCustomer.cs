using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class EditCustomer
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string state { get; set; }
        public int pin { get; set; }
        public long num { get; set; }
        public string Email { get; set; }
        public static void EditContact()
        {
            Console.WriteLine("enter the edit of first name ");
            string firstName=Console.ReadLine();
            Console.WriteLine("enter the edit of last name ");
            string lastName = Console.ReadLine();
            Console.WriteLine("enter the edit of address");
            string address = Console.ReadLine();
            Console.WriteLine("enter the edit of city ");
            string city = Console.ReadLine();
            Console.WriteLine("enter the pincode to edit");
            int pinCode=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number to edit");
            long phoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the edit of email ");
            string email = Console.ReadLine();
            Console.WriteLine("after editing of contact details");
            Console.WriteLine("firstName= "  +firstName);
            Console.WriteLine("LastName= " + lastName);
            Console.WriteLine("Address= " + address);
            Console.WriteLine(" City " + city);
            Console.WriteLine(" PinCode= " + pinCode);
            Console.WriteLine("PhoneNumber= " + phoneNumber);
            Console.WriteLine("Email = " + email);






        }






    }
}
