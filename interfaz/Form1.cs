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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                // Obtener los datos ingresados por el usuario
                int opcionRuta = ObtenerOpcionRutaSeleccionada();
                int cantidadPersonas = Convert.ToInt32(txtCantidadPersonas.Text);
                bool esPromocionColegios = chkPromocionColegios.Checked;
                int edadCliente = Convert.ToInt32(txtEdadCliente.Text);

                // Calcular el precio final utilizando la lógica de cálculo de precios
                decimal precioFinal = CalcularPrecioFinal(opcionRuta, cantidadPersonas, esPromocionColegios, edadCliente);

                // Mostrar el precio final en un control de texto o etiqueta
                lblPrecioFinal.Text = precioFinal.ToString("C");
            }

            // Método para obtener la opción de ruta seleccionada en un control ComboBox
            private int ObtenerOpcionRutaSeleccionada()
            {
                // Aquí debes implementar la lógica para obtener la opción de ruta seleccionada
                // por ejemplo: return Convert.ToInt32(cmbRuta.SelectedValue);
            }
        }
    }
}
