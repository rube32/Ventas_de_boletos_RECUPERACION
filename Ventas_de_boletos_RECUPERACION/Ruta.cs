using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ventas_de_boletos_RECUPERACION
{
    class Ruta
    {
        public string Nombre { get; set; }
        public decimal PrecioBase { get; set; }
        public Ruta(string nombre, decimal precioBase)
        {
            Nombre = nombre;
            PrecioBase = precioBase;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}