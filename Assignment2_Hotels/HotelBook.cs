using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment2_Hotels
{

    [Serializable, XmlRoot("hotelbook")]
    public class HotelBook
    {
        [XmlElement("hotel")]
        public List<Hotel> hotels;

        public HotelBook()
        {
            hotels = new List<Hotel>();
        }

    }


}
