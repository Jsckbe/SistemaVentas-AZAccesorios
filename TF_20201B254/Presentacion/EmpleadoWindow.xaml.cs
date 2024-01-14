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
    /// Lógica de interacción para EmpleadoWindow.xaml
    /// </summary>
    public partial class EmpleadoWindow : Window
    {
        private NEmpleado nEmpleado = new NEmpleado();
        Empleados empleadoSeleccionado = null;
        public EmpleadoWindow()
        {
            InitializeComponent();
            MostrarEmpleados(nEmpleado.ListarTodo());
        }

        private void MostrarEmpleados(List<Empleados> empleados)
        {
            dgEmpleados.ItemsSource = new List<Empleados>();
            dgEmpleados.ItemsSource = empleados;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbNombre.Text == "" || tbDNI.Text == "" || tbCargo.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            if(int.Parse(tbDNI.Text) <=9999999 || int.Parse(tbDNI.Text) >= 100000000)
            {
                MessageBox.Show("DNI invalido");
                return;
            }

            // Creación del objeto
            Empleados empleado = new Empleados
            {
                nombre_empleado = tbNombre.Text,
                dni_empleado = int.Parse(tbDNI.Text),
                cargo = tbCargo.Text,
            };

            // Registrar el objeto
            String mensaje = nEmpleado.Registrar(empleado);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarEmpleados(nEmpleado.ListarTodo());
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbNombre.Text == "" || tbDNI.Text == "" || tbCargo.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de selección
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado");
                return;
            }

            // Creación del objeto
            Empleados empleado = new Empleados
            {
                id_empleados=empleadoSeleccionado.id_empleados,
                nombre_empleado = tbNombre.Text,
                dni_empleado = int.Parse(tbDNI.Text),
                cargo = tbCargo.Text,
            };

            // Registrar el objeto
            String mensaje = nEmpleado.Modificar(empleado);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarEmpleados(nEmpleado.ListarTodo());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de selección
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado");
                return;
            }

            // Eliminar
            String mensaje = nEmpleado.Eliminar(empleadoSeleccionado.id_empleados);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarEmpleados(nEmpleado.ListarTodo());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgEmpleados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            empleadoSeleccionado = dgEmpleados.SelectedItem as Empleados;
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
            MostrarEmpleados(nEmpleado.ListarTodoPorDNI(int.Parse(tbDNI.Text)));
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            //FF65CBBC
            MostrarEmpleados(nEmpleado.ListarTodo());
        }
    }
}
