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
            Console.WriteLine("1.create a contact in address book\n2.Add Contact in address book\n3.Edit contacts in a address book\n4.Delete contacts in address book");
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
                 case 3:
                    List<EditCustomer> p = new List<EditCustomer>();
                    EditCustomer EditContact = new EditCustomer { name = "pallavi", lastname = "ediga", Address = "shivmogga", City = "bangalore", state = "karnataka", pin = 560001, num = 6361419518, Email = "pallavig1997@gmail.com" };

                    p.Add(EditContact);
                    
                    foreach (EditCustomer details in p)
                    {
                        Console.WriteLine("name=" + details.name);

                        Console.WriteLine("lastname=" + details.lastname);
                        Console.WriteLine("address=" + details.Address);
                        Console.WriteLine("city=" + details.City);
                        Console.WriteLine("state=" + details.state);
                        Console.WriteLine("pin" + details.pin);
                        Console.WriteLine("phonenumber=" + details.num);
                        Console.WriteLine("email=" + details.Email);
                        EditCustomer.EditContact();
                    }

                    break;
                  case 4:
                    List<Customer> a = new List<Customer>();
                    Customer k = new Customer { name = "jayaprakash", lastname = "Mudigonda", Address = "warangal", City = "hanamkonda", state = "Telangana", pin = 506342, num = 7337545935, Email = "jayaprakashjp187@gmail.com" };
                    Customer s = new Customer { name = "pallavi", lastname = "ediga", Address = "shivmogga", City = "bangalore", state = "karnataka", pin = 560001, num = 6361419518, Email = "pallavig1997@gmail.com" };

                    a.Add(k);
                    a.Remove(s); //deleting s data
                    Console.WriteLine("after deleting s variable");
                    foreach (Customer details in a)
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