using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment2_Hotels
{
    [Serializable, XmlType("service")]
    public enum EnumServiceType
    {
        Bar, Gym, Laundry, Parking, Sauna, Wifi
    }
}
