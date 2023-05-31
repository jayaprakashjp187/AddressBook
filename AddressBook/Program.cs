using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the address book program");
            List<Customer> l = new List<Customer>();
            Customer customer1 = new Customer { name = "jayaprakash",lastname ="Mudigonda",Address="warangal",City="hanamkonda",state="Telangana", pin = 506342, num = 7337545935,Email="jayaprakashjp187@gmail.com" };
  
            l.Add(customer1);
            foreach (Customer details in l)
            {
                Console.WriteLine("name=" + details.name);

                Console.WriteLine("lastname=" + details.lastname);
                Console.WriteLine("address=" + details.Address);
                Console.WriteLine("city=" + details.City);
                Console.WriteLine("state=" + details.state);
                Console.WriteLine("pin" + details.pin);
                Console.WriteLine("phonenumber=" + details.num);
                Console.WriteLine("email=" + details.Email);
            }
        }
    }
}