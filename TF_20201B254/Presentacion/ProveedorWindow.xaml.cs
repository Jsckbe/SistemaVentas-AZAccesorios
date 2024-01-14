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
    /// Lógica de interacción para ProveedorWindow.xaml
    /// </summary>
    public partial class ProveedorWindow : Window
    {
        private NProveedor nProveedor = new NProveedor();
        private NEmpleado nEmpleado = new NEmpleado();
        Proveedores proveedorSeleccionado = null;
        public ProveedorWindow()
        {
            InitializeComponent();
            MostrarProveedores(nProveedor.ListarTodo());
            MostrarEmpleados(nEmpleado.ListarTodo());
        }

        private void MostrarProveedores(List<Proveedores> proveedores)
        {
            dgProveedor.ItemsSource = new List<Proveedores>();
            dgProveedor.ItemsSource = proveedores;
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
            if (tbNombre.Text == "" || tbProducto.Text == "" || tbDireccion.Text == "" || tbTelefono.Text == "" || tbRUC.Text == "" || cbEmpleado.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            if (int.Parse(tbTelefono.Text) <= 99999999 || int.Parse(tbTelefono.Text) >= 1000000000)
            {
                MessageBox.Show("Telefono invalido");
                return;
            }

            if (int.Parse(tbRUC.Text) <= 9999999 || int.Parse(tbRUC.Text) >= 100000000)
            {
                MessageBox.Show("RUC invalido");
                return;
            }

            // Creación del objeto
            Proveedores proveedor = new Proveedores
            {
                nombre_proveedor = tbNombre.Text,
                productos_vender = tbProducto.Text,
                direccion_proveedor = tbDireccion.Text,
                telefono_proveedor = int.Parse(tbTelefono.Text),
                ruc_proveedor = int.Parse(tbRUC.Text),
                Empleados_id_empleados = (int)cbEmpleado.SelectedValue
            };

            // Registrar el objeto
            String mensaje = nProveedor.Registrar(proveedor);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarProveedores(nProveedor.ListarTodo());
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbNombre.Text == "" || tbProducto.Text == "" || tbDireccion.Text == "" || tbTelefono.Text == "" || tbRUC.Text == "" || cbEmpleado.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de selección
            if (proveedorSeleccionado == null)
            {
                MessageBox.Show("Seleccione un proveedor");
                return;
            }

            // Creación del objeto
            Proveedores proveedor = new Proveedores
            {
                id_proveedor=proveedorSeleccionado.id_proveedor,
                nombre_proveedor = tbNombre.Text,
                productos_vender = tbProducto.Text,
                direccion_proveedor = tbDireccion.Text,
                telefono_proveedor = int.Parse(tbTelefono.Text),
                ruc_proveedor = int.Parse(tbRUC.Text),
                Empleados_id_empleados = (int)cbEmpleado.SelectedValue
            };

            // Registrar el objeto
            String mensaje = nProveedor.Modificar(proveedor);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarProveedores(nProveedor.ListarTodo());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de selección
            if (proveedorSeleccionado == null)
            {
                MessageBox.Show("Seleccione un proveedor");
                return;
            }

            // Eliminar
            String mensaje = nProveedor.Eliminar(proveedorSeleccionado.id_proveedor);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarProveedores(nProveedor.ListarTodo());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgProveedor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            proveedorSeleccionado = dgProveedor.SelectedItem as Proveedores;
        }
    }
}
