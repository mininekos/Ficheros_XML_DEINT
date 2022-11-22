using Ficheros_XML.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Ficheros_XML.Servicio
{
    internal class Servicio
    {
        Banco banco;
        List<Cliente> clientes;
        public Servicio()
        {
            clientes = new List<Cliente>();
            banco= new Banco(clientes);
        }
        

        public int agregarCliente(Cliente cliente) {

            if (banco.ListaCLientes.Contains(cliente)==false) { 
                banco.ListaCLientes.Add(cliente);
                return 1;
            }

            return 0;
        }

        public int eliminarCliente(Cliente cliente)
        {

            if (banco.ListaCLientes.Contains(cliente))
            {
                banco.ListaCLientes.Remove(cliente);
                return 1;
            }

            return 0;
        }

        public void escribirXML() {
            
            XmlSerializer serializer = new XmlSerializer(typeof(Banco));

            using (var stream = new FileStream("banco.xml", FileMode.Create)) {
                foreach (var cliente in banco.ListaCLientes)
                {
                    serializer.Serialize(stream, cliente);

                }
            }
        }

        public void removerClienteXML(Cliente cliente) {
            XDocument doc = XDocument.Load("banco.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Banco));

            using (var stream = new FileStream("banco.xml", FileMode.Open))
            {
                foreach (var clientetes in banco.ListaCLientes)
                {
                    
                }
            }
        }
    }
}
