using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        Contact contact = new Contact();
        List<Contact> addressBook = new List<Contact>();
        public void addContact()
        {
            Console.WriteLine("Welcome To Address Book Program");
            Console.WriteLine("Enter Your First Name : ");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name : ");
            contact.lastName = Console.ReadLine();
            Console.WriteLine("Enter Your Address : ");
            contact.address = Console.ReadLine();
            Console.WriteLine("Enter Your City : ");
            contact.city = Console.ReadLine();
            Console.WriteLine("Enter Your State : ");
            contact.state = Console.ReadLine();
            Console.WriteLine("Enter Your Zip Code : ");
            contact.zipcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Phone No : ");
            contact.phoneNo = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Your Email : ");
            contact.email = Console.ReadLine();
            addressBook.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in addressBook)
            {
                Console.WriteLine("First Name : " + contact.firstName + "\nLast Name :" + contact.lastName + "\n Adderess : " + contact.address + "\n City :" + contact.city + "\n State :" + contact.state + "\n ZipCode :" + contact.zipcode + "\n PhoneNo :" + contact.phoneNo + "\n email :" + contact.email);
            }
        }
    }
}


