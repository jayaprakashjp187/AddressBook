using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("welcome to the address book program\n2.Add Contact in address book");
            Console.WriteLine("1.create a contact in address book");
            Console.WriteLine("choose what proogram u want");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:

               
                    List<Customer> l = new List<Customer>();
                    Customer customer1 = new Customer { name = "jayaprakash", lastname = "Mudigonda", Address = "warangal", City = "hanamkonda", state = "Telangana", pin = 506342, num = 7337545935, Email = "jayaprakashjp187@gmail.com" };

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

                    break;
                 case 2:
                    List<Customer> j = new List<Customer>();
                    Customer AddContact = new Customer { name = "pallavi", lastname = "ediga", Address = "shivmogga", City = "bangalore", state = "karnataka", pin = 560001, num = 6361419518, Email = "pallavig1997@gmail.com" };

                    j.Add(AddContact);
                    foreach (Customer details in j)
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

                        break;


            } 
               
           
        }
    }
}