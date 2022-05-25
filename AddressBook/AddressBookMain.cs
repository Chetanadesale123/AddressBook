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
        Dictionary<string, List<Contact>> dictionary123 = new Dictionary<string, List<Contact>>();
        public AddressBookMain()
        {
            Contact contact1 = new Contact()
            {
                firstName = "reena",
                lastName = "sharma",
                address = "Hinjewadi",
                city = "Pune",
                state = "maharashtra",
                email = "reenasharma1999@gmail.com",
                zipcode = 424008,
                phoneNo = 8757729815,
                
            };
            Contact contact2 = new Contact()
            {
                firstName = "rocky",
                lastName = "sharma",
                address = "deopur dhule",
                city = "dhule",
                state = "madhy Pradesh",
                email = "rockysharma1999@gmail.com",
                zipcode = 424002,
                phoneNo = 8942297246,
                
            };
            Console.WriteLine("Enter the \n 1.FirstName\n 2.LastName\n 3.Address\n 4.City\n 5.State\n 6.Email\n 7.postalCode\n 8.Phone Number\n");
            Contact contact3 = new Contact()
            {
                firstName = Console.ReadLine(),
                lastName = Console.ReadLine(),
                address = Console.ReadLine(),
                city = Console.ReadLine(),
                state = Console.ReadLine(),
                email = Console.ReadLine(),
                zipcode = Convert.ToInt32(Console.ReadLine()),
                phoneNo = Convert.ToInt64(Console.ReadLine())
            };
            addressBook.Add(contact1);
            addressBook.Add(contact2);
            addressBook.Add(contact3);
        }
        public void AddContactToAddressBook(Contact contact)
        {
            addressBook.Add(contact);
            Display();
        }
        public void Display()
        {
            foreach (var contact in addressBook)
            {
                Console.WriteLine("First Name : " + contact.firstName + "\nLast Name :" + contact.lastName + "\n Adderess : " + contact.address + "\n City :" + contact.city + "\n State :" + contact.state + "\n ZipCode :" + contact.zipcode + "\n PhoneNo :" + contact.phoneNo + "\n email :" + contact.email);
            }
        }
        public void EditContactInAddressBook(string name)
        {
            foreach (var contact in addressBook)
            {
                if (contact.firstName.Equals(name))
                {
                    Console.WriteLine("Enter the Option To Update");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the FirstName to Update");
                            contact.firstName = Console.ReadLine(); break;
                        case 2:
                            Console.WriteLine("Enter the LastName to Update");
                            contact.lastName = Console.ReadLine(); break;
                        case 3:
                            Console.WriteLine("Enter the Address to Update");
                            contact.address = Console.ReadLine(); break;
                        case 4:
                            Console.WriteLine("Enter the City to Update");
                            contact.city = Console.ReadLine(); break;
                        case 5:
                            Console.WriteLine("Enter the State to Update");
                            contact.state = Console.ReadLine(); break;
                        case 6:
                            Console.WriteLine("Enter the Email to Update");
                            contact.email = Console.ReadLine(); break;
                        case 7:
                            Console.WriteLine("Enter the Postal to Update");
                            contact.zipcode = Convert.ToInt32(Console.ReadLine()); break;
                        case 8:
                            Console.WriteLine("Enter the MobileNumber to Update");
                            contact.phoneNo = Convert.ToInt64(Console.ReadLine()); break;
                    }
                }
            }
        }
        public void DeletingContactINAddressBook(string name)
        {
            Contact delete = new Contact();
            foreach (var contact in addressBook)
            {
                if (contact.firstName.Equals(name))
                {
                    delete = contact;
                }
            }
            addressBook.Remove(delete);
            Display();
        }
        public void AddDictionary(string name)
        {
            if (dictionary123 == null)
            {
                dictionary123.Add(name, addressBook);
            }
            if (NameExists(name) == false)
            {
                dictionary123.Add(name, addressBook);
            }
            Console.WriteLine(dictionary123);
        }
        public void EditingDictionary(string name, string contactName)
        {
            foreach (var data in dictionary123)
            {
                if (dictionary123.Keys.Equals(name))
                {
                    addressBook = data.Value;
                    EditContactInAddressBook(contactName);
                }
            }
        }
        public bool NameExists(string name)
        {
            foreach (var data in dictionary123.Keys)
            {
                if (data.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
        public void DeleteDictionaryData(string name)
        {
            foreach (var data in dictionary123)
            {
                if (data.Key.Equals(name))
                {
                    addressBook = data.Value;
                    DeletingContactINAddressBook(name);
                }
            }
            dictionary123.Remove(name);
        }
        public void displayDictionaryData(string name)
        {
            foreach (var data in dictionary123)
            {
                if (dictionary123.Keys.Equals(name))
                {
                    addressBook = data.Value;
                }
                Console.WriteLine(dictionary123);
            }
        }

    }
}
    






