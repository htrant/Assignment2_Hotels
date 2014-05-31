using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment2_Hotels
{
    [Serializable, XmlType("room")]
    public enum EnumRoomType
    {
        Single, Double, Triple, Family
    }
}
