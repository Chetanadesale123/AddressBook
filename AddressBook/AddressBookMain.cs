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
        public void EditContact()
        {
            Console.WriteLine("Edit a contact list enter first name");
            string name = Console.ReadLine();
            if (contact.firstName.Equals(name))
            {
                Console.WriteLine("Edit a Contact\n 1.lastName\n 2.Address\n 3.City\n 4.State\n 5.Zip\n 6.phone no\n 7.email");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        string lastName = Console.ReadLine();
                        contact.lastName = lastName;
                        break;
                    case 2:
                        string address = Console.ReadLine();
                        contact.address = address;
                        break;
                    case 3:
                        string city = Console.ReadLine();
                        contact.city = city;
                        break;
                    case 4:
                        string state = Console.ReadLine();
                        contact.state = state;
                        break;
                    case 5:
                        string zipcode = Console.ReadLine();
                        contact.zipcode = Convert.ToInt32(zipcode);
                        break;
                    case 6:
                        string phoneNo = Console.ReadLine();
                        contact.phoneNo = Convert.ToInt64(phoneNo);
                        break;
                    case 7:
                        string email = Console.ReadLine();
                        contact.email = email;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Name is not Exist");
            }
        }
    }
}



