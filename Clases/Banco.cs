using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros_XML.Clases
{
    internal class Banco
    {
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
