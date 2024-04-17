using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ventas_de_boletos_RECUPERACION
{
    public class Calcular_descuento_cliente
    {
        static void Main(string[] args)
        {
            // Obtener la selección de la ruta y detalles del cliente (como se mostró anteriormente)

            // Calcular precio final
            decimal precioFinal = CalcularPrecioFinal(precioBase, cantidadPersonas, esPromocionColegios, edadCliente);

            // Mostrar el precio final al usuario
            Console.WriteLine($"El precio final de la venta de boletos es: {precioFinal} soles.");
        }

        // Otras funciones necesarias como ObtenerPrecioBase, CalcularDescuentoPorCantidadPersonas, etc.

        static decimal CalcularDescuentoPorTipoCliente(bool esPromocionColegios, int edadCliente)
        {
            decimal descuentoAdicional = 0;

            if (esPromocionColegios)
            {
                descuentoAdicional += 0.07m; // Descuento adicional para promoción de colegios
            }

            if (edadCliente >= 60)
            {
                descuentoAdicional += 0.05m; // Descuento adicional para adultos mayores de 60 años
            }

            return descuentoAdicional;
        }

    }
}