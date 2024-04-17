using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ventas_de_boletos_RECUPERACION
{
    public class Calcular_precio_final
    {
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
                    return 0; // Ruta no válida
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

        static decimal CalcularDescuentoPorTipoCliente(bool esPromocionColegios, int edadCliente)
        {
            if (esPromocionColegios)
            {
                return 0.07m;
            }
            else if (edadCliente >= 60)
            {
                return 0.05m;
            }
            else
            {
                return 0; // No hay descuento por tipo de cliente
            }
        }

        static decimal CalcularPrecioFinal(decimal precioBase, int cantidadPersonas, decimal descuentoPorCantidadPersonas, decimal descuentoPorTipoCliente)
        {
            decimal precioAntesDescuento = precioBase * cantidadPersonas;
            decimal descuentoTotal = precioAntesDescuento * (descuentoPorCantidadPersonas + descuentoPorTipoCliente);
            return precioAntesDescuento - descuentoTotal;
        }

    }
}