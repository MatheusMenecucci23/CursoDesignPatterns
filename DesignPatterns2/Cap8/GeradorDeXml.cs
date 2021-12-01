using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatterns2.Cap8
{
    public class GeradorDeXml
    {
        public String GeraXml(object o)
        {
            XmlSerializer serializer = new XmlSerializer(o.GetType());
            StringWriter Writer = new StringWriter();
            serializer.Serialize(Writer, o);
            return Writer.ToString();

        }
    }
}
