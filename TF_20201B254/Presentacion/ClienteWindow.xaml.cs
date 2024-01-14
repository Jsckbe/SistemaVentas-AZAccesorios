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
    /// Lógica de interacción para ClienteWindow.xaml
    /// </summary>
    public partial class ClienteWindow : Window
    {
        private NCliente nCliente = new NCliente();
        private NEmpleado nEmpleado = new NEmpleado();
        Clientes clienteSeleccionado = null;
        public ClienteWindow()
        {
            InitializeComponent();
            MostrarClientes(nCliente.ListarTodo());
            MostrarEmpleados(nEmpleado.ListarTodo());
        }

        private void MostrarClientes(List<Clientes> clientes)
        {
            dgClientes.ItemsSource = new List<Clientes>();
            dgClientes.ItemsSource = clientes;
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
            if (tbNombre.Text == "" || tbDNI.Text == "" || tbTelefono.Text == "" || tbDireccion.Text == "" || cbEmpleado.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            if (int.Parse(tbDNI.Text) <= 9999999 || int.Parse(tbDNI.Text) >= 100000000)
            {
                MessageBox.Show("DNI invalido");
                return;
            }

            if (int.Parse(tbTelefono.Text) <= 99999999 || int.Parse(tbTelefono.Text) >= 1000000000)
            {
                MessageBox.Show("Telefono invalido");
                return;
            }

            // Creación del objeto
            Clientes cliente = new Clientes
            {
                nombre_cliente = tbNombre.Text,
                dni_cliente = int.Parse(tbDNI.Text),
                telefono = tbTelefono.Text,
                direccion = tbDireccion.Text,
                Empleados_id_empleados = (int)cbEmpleado.SelectedValue,
            };

            // Registrar el objeto
            String mensaje = nCliente.Registrar(cliente);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarClientes(nCliente.ListarTodo());
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbNombre.Text == "" || tbDNI.Text == "" || tbTelefono.Text == "" || tbDireccion.Text == "" || cbEmpleado.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de selección
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }

            // Creación del objeto
            Clientes cliente = new Clientes
            {
                id_cliente=clienteSeleccionado.id_cliente,
                nombre_cliente = tbNombre.Text,
                dni_cliente = int.Parse(tbDNI.Text),
                telefono = tbTelefono.Text,
                direccion = tbDireccion.Text,
                Empleados_id_empleados = (int)cbEmpleado.SelectedValue,
            };

            // Registrar el objeto
            String mensaje = nCliente.Registrar(cliente);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarClientes(nCliente.ListarTodo());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de selección
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }

            // Eliminar
            String mensaje = nCliente.Eliminar(clienteSeleccionado.id_cliente);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarClientes(nCliente.ListarTodo());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            clienteSeleccionado = dgClientes.SelectedItem as Clientes;
        }

        private void btnBuscarPorDNI_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbDNI.Text == "")
            {
                MessageBox.Show("Ingrese DNI");
                return;
            }

            // Mostrar en el DataGrid
            MostrarClientes(nCliente.ListarTodoPorDNI(int.Parse(tbDNI.Text)));
        }

        private void btnMostrarCliente_Click(object sender, RoutedEventArgs e)
        {
            // Mostrar en el DataGrid
            MostrarClientes(nCliente.ListarTodo());
        }
    }
}
