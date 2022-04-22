using System;
namespace AddressBook;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Welcome To Address Book Program");
        AddressBookMain addContact = new AddressBookMain();
        bool end = true;
        while (true)
        {
            Console.WriteLine("Select Option\n 1.add Contact \n 2.Display \n3.Edit Contact \n 4.end");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    addContact.addContact();
                    break;
                case 2:
                    addContact.Display();
                    break;
                case 3:
                    addContact.EditContact();
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

