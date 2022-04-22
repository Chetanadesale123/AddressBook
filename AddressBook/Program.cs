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
            Console.WriteLine("Select Option\n 1.Add Contact \n 2.Display \n 3.Edit Contact \n 4.Delete Contact\n 5.end");
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
                    addContact.DeleteContact();
                    break;
                case 5:
                    end = false;
                    break;
                default:
                    Console.WriteLine("Incorrect Option");
                    break;
            }
        }
    }
}

