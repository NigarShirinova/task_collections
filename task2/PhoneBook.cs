using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class PhoneBook
    {
        public Dictionary<string,string> Contacts { get; set; }
        public PhoneBook()
        {
            Contacts = new Dictionary<string,string>();
        }
        public void AddContact(string name, string phoneNumber)
        {
            Contacts.Add(name, phoneNumber);
        }

        public void RemoveContact(string name)
        {
            Contacts.Remove(name);
        }

        public void GetAllContacts()
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine($"{contact.Key} - {contact.Value}");
            }
        }

        public void FindContactByName(string name)
        {
            foreach (var contact in Contacts)
            {
                if(contact.Key == name)
                    Console.WriteLine($"{name}'s number is {contact.Value}");
            }
        }
    }
}
