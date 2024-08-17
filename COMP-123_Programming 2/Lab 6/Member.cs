using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6
{
    public class Member
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactInfo { get; set; }
        public Member(int id, string firstName, string lastName, string contactInfo)
        {
            MemberID = id;
            FirstName = firstName;
            LastName = lastName;            
            ContactInfo = contactInfo;
        }
        public override string ToString()
        {
            return $"Member ID: {MemberID}\nName: {FirstName} {LastName}\nContact info: {ContactInfo}";
        }

    }
}
