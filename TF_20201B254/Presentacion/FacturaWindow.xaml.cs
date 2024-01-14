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
    /// Lógica de interacción para FacturaWindow.xaml
    /// </summary>
    public partial class FacturaWindow : Window
    {
        private NFactura nFactura = new NFactura();
        private NProveedor nProveedor = new NProveedor();
        Factura facturaSeleccionada = null;
        public FacturaWindow()
        {
            InitializeComponent();
            MostrarFacturas(nFactura.ListarTodo());
            MostrarProveedores(nProveedor.ListarTodo());
        }

        private void MostrarFacturas(List<Factura> facturas)
        {
            dgFacturas.ItemsSource = new List<Factura>();
            dgFacturas.ItemsSource = facturas;
        }

        private void MostrarProveedores(List<Proveedores> proveedores)
        {
            cbProveedor.ItemsSource = new List<Proveedores>();
            cbProveedor.ItemsSource = proveedores;
            cbProveedor.DisplayMemberPath = "nombre_proveedor";
            cbProveedor.SelectedValuePath = "id_proveedor";
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbNumero.Text == "" || tbFecha.Text == "" || cbProveedor.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Factura factura = new Factura
            {
                numero_factura = tbNumero.Text,
                fecha = int.Parse(tbFecha.Text),
                Proveedores_id_proveedor = (int)cbProveedor.SelectedValue,
            };

            // Registrar el objeto
            String mensaje = nFactura.Registrar(factura);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarFacturas(nFactura.ListarTodo());
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbNumero.Text == "" || tbFecha.Text == "" || cbProveedor.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de selección
            if (facturaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una factura");
                return;
            }

            // Creación del objeto
            Factura factura = new Factura
            {
                id_factura=facturaSeleccionada.id_factura,
                numero_factura = tbNumero.Text,
                fecha = int.Parse(tbFecha.Text),
                Proveedores_id_proveedor = (int)cbProveedor.SelectedValue,
            };

            // Registrar el objeto
            String mensaje = nFactura.Modificar(factura);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarFacturas(nFactura.ListarTodo());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de selección
            if (facturaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una factura");
                return;
            }

            // Eliminar
            String mensaje = nFactura.Eliminar(facturaSeleccionada.id_factura);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarFacturas(nFactura.ListarTodo());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgFacturas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            facturaSeleccionada = dgFacturas.SelectedItem as Factura;
        }
    }
}
