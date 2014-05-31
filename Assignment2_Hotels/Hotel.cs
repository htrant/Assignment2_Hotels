using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment2_Hotels
{
    [Serializable]
    public class Hotel : Generator
    {
        [XmlAttribute("hotel_id")]
        public int hotelID {
            get { return this.getId(); }
            set { value = this.getId(); }
        }

        [XmlElement("hotel_name")]
        public string name
        {
            get;
            set;
        }

        public string address;

        public int postalCode;

        public string city;

        public string country;

        [XmlElement("receptionist_phone")]
        public string hotelPhone;
        
        public int ranking;

        public List<EnumRoomType> roomTypes;

        public List<EnumServiceType> services;

        [XmlElement("hotel_manager")]
        public Person person;

        public Hotel()
        {
            this.name = "Unknown Hotel #" + this.hotelID;
            this.address = "";
            this.postalCode = 0;
            this.city = "";
            this.country = "Unknown";
            this.hotelPhone = "";
            this.ranking = 1;
            this.services = null;
            this.roomTypes = null;
            this.person = new Person();
        }

        public Hotel(string name, string address, int postalCode, string city, string country, string hotelPhone, int ranking, List<EnumServiceType> services, List<EnumRoomType> roomTypes, Person person)
        {            
            this.name = name;
            this.address = address;
            this.postalCode = postalCode;
            this.city = city;
            this.country = country;
            this.hotelPhone = hotelPhone;
            this.ranking = ranking;
            this.services = services;
            this.roomTypes = roomTypes;
            this.person = person;
        }
        
        /*
        public override string ToString()
        {
            return name;
        }
        */
    }
}
