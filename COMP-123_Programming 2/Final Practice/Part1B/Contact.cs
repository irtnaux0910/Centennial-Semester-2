using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1B
{
    public class Contact
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;
        public Contact (string firstName, string lastName, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public string PhoneNumber { get { return phoneNumber; } }
    }
}
