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
    /// Lógica de interacción para ProductoWindow.xaml
    /// </summary>
    public partial class ProductoWindow : Window
    {
        private NProducto nProducto = new NProducto();
        private NProveedor nProveedor = new NProveedor();
        private NEmpleado nEmpleado = new NEmpleado();
        Productos productoSeleccionado = null;
        public ProductoWindow()
        {
            InitializeComponent();
            MostrarProductos(nProducto.ListarTodo());
            MostrarProveedores(nProveedor.ListarTodo());
            MostrarEmpleados(nEmpleado.ListarTodo());
        }

        private void MostrarProductos(List<Productos> productos)
        {
            dgProductos.ItemsSource = new List<Productos>();
            dgProductos.ItemsSource = productos;
        }

        private void MostrarProveedores(List<Proveedores> proveedores)
        {
            cbProveedor.ItemsSource = new List<Proveedores>();
            cbProveedor.ItemsSource = proveedores;
            cbProveedor.DisplayMemberPath = "nombre_proveedor";
            cbProveedor.SelectedValuePath = "id_proveedor";
        }

        private void MostrarEmpleados(List<Empleados> empleados)
        {
            cbEmpleado.ItemsSource = new List<Empleados>();
            cbEmpleado.ItemsSource = empleados;
            cbEmpleado.DisplayMemberPath = "nombre_empleado";
            cbEmpleado.SelectedValuePath = "id_empleados";
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbPrecio.Text == "" || cbEmpleado.Text == "" || cbProveedor.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Productos producto = new Productos
            {
                codigo_producto = int.Parse(tbCodigo.Text),
                nombre_producto = tbNombre.Text,
                precio = int.Parse(tbPrecio.Text),
                Empleados_id_empleados = (int)cbEmpleado.SelectedValue,
                Proveedores_id_proveedor = (int)cbProveedor.SelectedValue
            };

            // Registrar el objeto
            String mensaje = nProducto.Registrar(producto);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarProductos(nProducto.ListarTodo());
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbPrecio.Text == "" || cbEmpleado.Text == "" || cbProveedor.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de selección
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            // Creación del objeto
            Productos producto = new Productos
            {
                id_producto=productoSeleccionado.id_producto,
                codigo_producto = int.Parse(tbCodigo.Text),
                nombre_producto = tbNombre.Text,
                precio = int.Parse(tbPrecio.Text),
                Empleados_id_empleados = (int)cbEmpleado.SelectedValue,
                Proveedores_id_proveedor = (int)cbProveedor.SelectedValue
            };

            // Registrar el objeto
            String mensaje = nProducto.Modificar(producto);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarProductos(nProducto.ListarTodo());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de selección
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            // Eliminar
            String mensaje = nProducto.Eliminar(productoSeleccionado.id_producto);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarProductos(nProducto.ListarTodo());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            productoSeleccionado = dgProductos.SelectedItem as Productos;
        }

        private void btnProdxCod_Click(object sender, RoutedEventArgs e)
        {
            if (tbCodigo.Text == "")
            {
                MessageBox.Show("Ingrese codigo de producto");
                return;
            }

            // Mostrar en el DataGrid
            MostrarProductos(nProducto.ListarProductoxCod(int.Parse(tbCodigo.Text)));
        }

        private void btnMostrarProductos_Click(object sender, RoutedEventArgs e)
        {
            // Mostrar en el DataGrid
            MostrarProductos(nProducto.ListarTodo());
        }
    }
}
