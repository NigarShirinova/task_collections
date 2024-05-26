using System;
using task2;

class Program
{
    public static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook();
        phoneBook.AddContact("Nigar", "2678190");
        phoneBook.AddContact("Raksana", "3672819");

        phoneBook.RemoveContact("Raksana");
        phoneBook.FindContactByName("Nigar");
        phoneBook.GetAllContacts();
    }
}