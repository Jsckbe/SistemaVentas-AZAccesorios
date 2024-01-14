using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para DetallexFacturaWindow.xaml
    /// </summary>
    public partial class DetallexFacturaWindow : Window
    {
        private NDetallexFactura nDetallexFactura = new NDetallexFactura();
        private NFactura nFactura = new NFactura();
        private NProducto nProducto = new NProducto();
        public DetallexFacturaWindow()
        {
            InitializeComponent();
            MostrarDetallexFacturas(nDetallexFactura.ListarTodo());
            MostrarFacturas(nFactura.ListarTodo());
            MostrarProductos(nProducto.ListarTodo());
        }

        private void MostrarDetallexFacturas(List<DetallesxFactura> detallexFacturas)
        {
            dgDetallexFacturas.ItemsSource = new List<DetallesxFactura>();
            dgDetallexFacturas.ItemsSource = detallexFacturas;
        }

        private void MostrarFacturas(List<Factura> facturas)
        {
            cbFactura.ItemsSource = new List<Factura>();
            cbFactura.ItemsSource = facturas;
            cbFactura.DisplayMemberPath = "numero_factura";
            cbFactura.SelectedValuePath = "id_factura";
        }

        private void MostrarProductos(List<Productos> productos)
        {
            cbProducto.ItemsSource = new List<Productos>();
            cbProducto.ItemsSource = productos;
            cbProducto.DisplayMemberPath = "nombre_producto";
            cbProducto.SelectedValuePath = "id_producto";
        }

        private void btnAsignar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (cbFactura.Text == "" || cbProducto.Text == "" || tbCantidad.Text == "" || tbPrecio.Text == "" || tbImporte.Text == "" || tbMontoTotal.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            DetallesxFactura detallexFactura = new DetallesxFactura
            {
                Factura_id_factura = (int)cbFactura.SelectedValue,
                Productos_id_producto = (int)cbProducto.SelectedValue,
                cantidad_producto_factura = int.Parse(tbCantidad.Text),
                precio_unitario = int.Parse(tbPrecio.Text),
                importe_producto_factura = int.Parse(tbImporte.Text),
                monto_total = int.Parse(tbMontoTotal.Text)
            };

            // Asignar el objeto
            String mensaje = nDetallexFactura.Asignar(detallexFactura);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarDetallexFacturas(nDetallexFactura.ListarTodo());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
