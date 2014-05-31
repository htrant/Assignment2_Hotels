using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment2_Hotels
{
    public class Serializer
    {
        private string path = null;
        private string fileName = "hotelbook.xml";
        private string xmlFile;
        private XmlSerializer xmlSerializerObj;

        public Serializer() {
            path = Directory.GetCurrentDirectory() + "/";
            xmlFile = path + fileName;
            if (!File.Exists(xmlFile))
            {
                File.Create(xmlFile).Close();
            }
        }

        public void persist(Object obj) {            
            xmlSerializerObj = new XmlSerializer(obj.GetType());
            var stream = new FileStream(xmlFile, FileMode.Create);
            xmlSerializerObj.Serialize(stream, obj);
            stream.Close();
        }

        public Object read(Object obj) {
            xmlSerializerObj = new XmlSerializer(obj.GetType());
            var stream = new FileStream(xmlFile,FileMode.Open,FileAccess.Read,FileShare.Read);
            Object loadedObj = (Object)xmlSerializerObj.Deserialize(stream);
            stream.Close();
            return loadedObj;
        }

    }
}
