using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1B
{
    public class ContactBook
    {
        private List<Contact> contacts = new List<Contact>();
        public ContactBook()
        {
            contacts = new List<Contact>();
        }
        public void AddContact(string firstName, string lastName, string phoneNumber)
        {
            try
            {
                Contact contact = new Contact(firstName, lastName, phoneNumber);
                contacts.Add(contact);
                Console.WriteLine("Contact added successfully.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Contact SearchContact(string firstName)
        {
            foreach (Contact contact in contacts)
            {
                return contact;
            }
            return null;
        }
        public void DisplayContacts()
        {
            Console.WriteLine("Contact List:");
            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}, Phone: {contact.PhoneNumber}");
            }
        }
    }
}
