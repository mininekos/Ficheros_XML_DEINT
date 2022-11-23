using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros_XML.Clases
{
    [Serializable]
    public class Cliente
    {

        public String DNI { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public Int64 Edad { get; set; }
        public Int64 Telefono { get; set; }
        public Int64 NumCuenta { get; set; }

        public Cliente()
        {
        }

        public Cliente(string dNI, string nombre, string direccion, long edad, long telefono, long numCuenta)
        {
            DNI = dNI;
            Nombre = nombre;
            Direccion = direccion;
            Edad = edad;
            Telefono = telefono;
            NumCuenta = numCuenta;
        }

        public Cliente(string dNI)
        {
            DNI = dNI;
        }

        public override bool Equals(object obj)
        {
            return obj is Cliente cliente &&
                   DNI == cliente.DNI;
        }

        public override int GetHashCode()
        {
            return 1533321978 + EqualityComparer<string>.Default.GetHashCode(DNI);
        }
    }
}
