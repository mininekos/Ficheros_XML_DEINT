using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ficheros_XML.Clases
{
    [Serializable]
    public class Banco
    {
        [XmlElement("Cliente")]
        public List<Cliente> ListaCLientes { get; set; }

        public Banco()
        {
        }

        public Banco(List<Cliente> listaCLientes)
        {
            ListaCLientes = listaCLientes;
        }
    }
}
