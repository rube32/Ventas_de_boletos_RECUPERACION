using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ventas_de_boletos_RECUPERACION
{
    public class CalculadoraPrecios
    {
        static void Main(string[] args)
        {
            // Obtener la selección de la ruta y detalles del cliente (como se mostró anteriormente)

            // Calcular el precio base de la ruta seleccionada
            decimal precioBase = ObtenerPrecioBase(opcionRuta);

            // Aplicar descuentos según la cantidad de personas y el tipo de cliente
            decimal descuentoPorCantidadPersonas = CalcularDescuentoPorCantidadPersonas(cantidadPersonas);
            decimal descuentoPorTipoCliente = 0;
            if (esPromocionColegios)
            {
                descuentoPorTipoCliente += 0.07m;
            }
            else if (edadCliente >= 60)
            {
                descuentoPorTipoCliente += 0.05m;
            }

            // Calcular el precio total de la venta de boletos
            decimal precioTotal = CalcularPrecioTotal(precioBase, cantidadPersonas, descuentoPorCantidadPersonas, descuentoPorTipoCliente);

            // Mostrar el precio total al usuario
            Console.WriteLine($"El precio total de la venta de boletos es: {precioTotal} soles.");
        }

        static decimal ObtenerPrecioBase(int opcionRuta)
        {
            switch (opcionRuta)
            {
                case 1:
                    return 100;
                case 2:
                    return 120;
                case 3:
                    return 150;
                default:
                    return 0; // Precio base desconocido
            }
        }

        static decimal CalcularDescuentoPorCantidadPersonas(int cantidadPersonas)
        {
            if (cantidadPersonas >= 2 && cantidadPersonas <= 7)
            {
                return 0.08m;
            }
            else if (cantidadPersonas >= 8 && cantidadPersonas <= 16)
            {
                return 0.13m;
            }
            else if (cantidadPersonas >= 17)
            {
                return 0.15m;
            }
            else
            {
                return 0; // No hay descuento por cantidad de personas
            }
        }

        static decimal CalcularPrecioTotal(decimal precioBase, int cantidadPersonas, decimal descuentoPorCantidadPersonas, decimal descuentoPorTipoCliente)
        {
            decimal precioAntesDescuento = precioBase * cantidadPersonas;
            decimal descuentoTotal = precioAntesDescuento * (descuentoPorCantidadPersonas + descuentoPorTipoCliente);
            return precioAntesDescuento - descuentoTotal;
        }
    }
}