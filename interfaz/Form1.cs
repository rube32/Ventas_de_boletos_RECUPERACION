using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            static void Main(string[] args)
            {
                // Obtener la selección de la ruta
                Console.WriteLine("Seleccione una ruta:");
                MostrarRutas();
                int opcionRuta = int.Parse(Console.ReadLine());

                // Obtener detalles del cliente
                Console.WriteLine("Ingrese el nombre del cliente:");
                string nombreCliente = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del cliente:");
                int edadCliente = int.Parse(Console.ReadLine());
                Console.WriteLine("¿Es promoción de colegios? (S/N):");
                bool esPromocionColegios = Console.ReadLine().ToUpper() == "S";

                // Obtener cantidad de personas
                Console.WriteLine("Ingrese la cantidad de personas:");
                int cantidadPersonas = int.Parse(Console.ReadLine());

                // Mostrar resumen de la compra
                Console.WriteLine("\nResumen de la compra:");
                Console.WriteLine($"Ruta seleccionada: {ObtenerNombreRuta(opcionRuta)}");
                Console.WriteLine($"Cliente: {nombreCliente}");
                Console.WriteLine($"Edad: {edadCliente}");
                Console.WriteLine($"Promoción de colegios: {(esPromocionColegios ? "Sí" : "No")}");
                Console.WriteLine($"Cantidad de personas: {cantidadPersonas}");

                // Aquí puedes continuar con la lógica para calcular el precio total y registrar la venta
            }

            static void MostrarRutas()
            {
                var rutas = new string[] {
            "1. Sacsayhuaman - Puka Pukara - Tambomachay (S/. 100)",
            "2. Tipon - Lucre - Piquillaqta (S/. 120)",
            "3. Ollantaytambo - Machupicchu (S/. 150)"
        };
                foreach (var ruta in rutas)
                {
                    Console.WriteLine(ruta);
                }
            }

            static string ObtenerNombreRuta(int opcionRuta)
            {
                switch (opcionRuta)
                {
                    case 1:
                        return "Sacsayhuaman - Puka Pukara - Tambomachay";
                    case 2:
                        return "Tipon - Lucre - Piquillaqta";
                    case 3:
                        return "Ollantaytambo - Machupicchu";
                    default:
                        return "Ruta desconocida";
                }
    }
}
