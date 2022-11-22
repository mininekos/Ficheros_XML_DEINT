﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros_XML.Clases
{
    internal class Cliente
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


    }
}