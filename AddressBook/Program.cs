using System;
using System.Collections.Generic;

namespace AddressBook;
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Welcome To Address Book Program");
        AddressBookMain addressBookMain = new AddressBookMain();
        bool end = true;
        while (end == true)
        {
            Console.WriteLine("Select Option \n 1.Display \n 2.DublicateEntryCheck \n 3.Edit Contact \n 4.Delete Contact\n 5.Add data in dictionary\n 6.Edit data in Dictionary\n 7.Delete Data in Dictionary\n 8.Search City Or State Name \n  9.end");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    addressBookMain.Display();
                    break;
                case 2:
                    string name2 = Console.ReadLine();
                    bool existName = addressBookMain.DuplicateEntryCheck(name2);
                    if (existName)
                    {
                        Console.WriteLine("This contact already exist please add new entry");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter the Name for Edit the Contact In AddressBook");
                    string name = Console.ReadLine();
                    addressBookMain.EditContactInAddressBook(name);
                    addressBookMain.Display();
                    break;
                case 4:
                    Console.WriteLine("Enter the Name for Delete the data");
                    string name1 = Console.ReadLine();
                    addressBookMain.DeletingContactINAddressBook(name1);
                    break;
                case 5:
                    Console.WriteLine("Enter the Name for Adding data in Dictionary ");
                    string dictionaryName = Console.ReadLine();
                    addressBookMain.AddDictionary(dictionaryName); break;
                case 6:
                    Console.WriteLine("Enter the Name for Editing data in Dictionary ");
                    string dictName = Console.ReadLine();
                    string contactName = Console.ReadLine();
                    addressBookMain.EditingDictionary(dictName, contactName);
                    addressBookMain.displayDictionaryData(dictName);
                   break;
                case 7:
                    Console.WriteLine("Enter the Name for Deleting data in Dictionary ");
                    string deleteName = Console.ReadLine();
                    addressBookMain.DeleteDictionaryData(deleteName); break;
                case 8:
                    //Console.WriteLine("Enter the CityStateName");
                   // string CityStateName = Console.ReadLine();
                    //List<Contact> personDetails = new List<Contact>();
                  
                    addressBookMain.SearchbyCityorState();
                    break;
                case 9:
                    end = false;
                    break;
                default:
                    Console.WriteLine("Incorrect Option");
                    break;
            }
        }
    }
}

