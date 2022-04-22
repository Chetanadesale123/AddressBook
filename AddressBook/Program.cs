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
            Console.WriteLine("Select Option \n 1.Display \n 2.Edit Contact \n 3.Delete Contact\n4.Add data in dictionary\n 5.Edit data in Dictionary\n 6.Delete Data in Dictionary\n 7.end");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    addContact.Display();
                    break;
                case 2:
                    Console.WriteLine("Enter the Name for Edit the Contact In AddressBook");
                    string name = Console.ReadLine();
                    addContact.EditContactInAddressBook(name);
                    addContact.Display();
                    break;
                case 3:
                    Console.WriteLine("Enter the Name for Delete the data");
                    string name1 = Console.ReadLine();
                    addContact.DeletingContactINAddressBook(name1);
                    break;
                case 4:
                    Console.WriteLine("Enter the Name for Adding data in Dictionary ");
                    string dictionaryName = Console.ReadLine();
                    addContact.AddDictionary(dictionaryName); break;
                case 5:
                    Console.WriteLine("Enter the Name for Editing data in Dictionary ");
                    string dictName = Console.ReadLine();
                    string contactName = Console.ReadLine();
                    addContact.EditingDictionary(dictName, contactName); break;
                case 6:
                    Console.WriteLine("Enter the Name for Deleting data in Dictionary ");
                    string deleteName = Console.ReadLine();
                    addContact.DeleteDictionaryData(deleteName); break;
                case 7:
                    end = false;
                    break;
                default:
                    Console.WriteLine("Incorrect Option");
                    break;
            }
        }
    }
}

