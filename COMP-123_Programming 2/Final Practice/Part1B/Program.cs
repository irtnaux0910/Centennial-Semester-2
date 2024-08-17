using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactBook contactBook = new ContactBook();

            contactBook.AddContact("John", "Doe", "123-456-7890");
            contactBook.AddContact("Jane", "Smith", "987-654-3210");

            string searchName = "John";
            Contact foundContact = contactBook.SearchContact(searchName);
            if (foundContact != null)
            {
                Console.WriteLine($"Contact found: {foundContact.FirstName} {foundContact.LastName}, Phone: {foundContact.PhoneNumber}");
            }
            else
            {
                Console.WriteLine($"Contact '{searchName}' not found.");
            }

            contactBook.DisplayContacts();

            Console.ReadKey();
        }
    }
}
