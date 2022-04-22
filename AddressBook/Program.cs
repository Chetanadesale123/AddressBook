using System;
namespace AddressBook;

class Program
{
    static void Main(String[] args)
    {
        Contact contact = new Contact();
        AddressBookMain addContact = new AddressBookMain();
        addContact.CreatContact();
    }
}
