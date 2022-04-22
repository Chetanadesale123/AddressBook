using System;
namespace AddressBook;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Welcome To Address Book Program");
        AddressBookMain addContact = new AddressBookMain();
        bool end = true;
        while (end == true)
        {
            Console.WriteLine("Select Option \n 1.Display \n 2.Edit Contact \n 3.Delete Contact\n 4.end");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    addContact.Display();
                    break;
                case 2:
                    Console.WriteLine("Enter the Name for Edit the Information");
                    string name = Console.ReadLine();
                    addContact.EditContactInAddressBook(name);
                    addContact.Display();
                    break;
                case 3:
                    Console.WriteLine("Enter the Name for Delete the Information");
                    string name1 = Console.ReadLine();
                    addContact.DeletingContactINAddressBook(name1);
                    break;
                case 4:
                    end = false;
                    break;
                default:
                    Console.WriteLine("Incorrect Option");
                    break;
            }
        }
    }
}

