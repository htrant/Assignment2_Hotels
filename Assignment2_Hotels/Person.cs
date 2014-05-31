using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment2_Hotels
{
    [Serializable]
    public class Person : Generator
    {
        [XmlAttribute("person_id")]
        public int personID {
            get { return this.getId(); }
            set { value = this.getId(); }
        }

        public string fullName;

        [XmlElement("date_of_birth")]
        public DateTime birthday;

        public string phoneNumber;

        [XmlElement("email_address")]
        public string email;

        public Person() {
            this.fullName = "Unknown Person #" + this.personID;            
            this.birthday = DateTime.Now;
            this.phoneNumber = "";
            this.email = "";
        }

        public Person(string fullName, DateTime birthday, string phoneNumber, string email)
        {
            this.fullName = fullName;
            this.birthday = birthday;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }


    }
}
