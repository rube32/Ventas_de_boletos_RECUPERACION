using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ventas_de_boletos_RECUPERACION
{
    class Cliente
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool EsPromocionColegios { get; set; }
        public Cliente(string nombre, int edad, bool esPromocionColegios)
        {
            Nombre = nombre;
            Edad = edad;
            EsPromocionColegios = esPromocionColegios;
        }
    }
}