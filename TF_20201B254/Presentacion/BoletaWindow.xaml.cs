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
    /// Lógica de interacción para BoletaWindow.xaml
    /// </summary>
    public partial class BoletaWindow : Window
    {
        private NBoleta nBoleta = new NBoleta();
        private NCliente nCliente = new NCliente();
        Boleta boletaSeleccionada = null;
        public BoletaWindow()
        {
            InitializeComponent();
            MostrarBoletas(nBoleta.ListarTodo());
            MostrarClientes(nCliente.ListarTodo());
        }

        private void MostrarBoletas(List<Boleta> boletas)
        {
            dgBoletas.ItemsSource = new List<Boleta>();
            dgBoletas.ItemsSource = boletas;
        }

        private void MostrarClientes(List<Clientes> clientes)
        {
            cbClientes.ItemsSource = new List<Clientes>();
            cbClientes.ItemsSource = clientes;
            cbClientes.DisplayMemberPath = "nombre_cliente";
            cbClientes.SelectedValuePath = "id_cliente";
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbNumero.Text == "" || tbFecha.Text == "" || cbClientes.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Boleta boleta = new Boleta
            {
                numero_boleta = tbNumero.Text,
                fecha = int.Parse(tbFecha.Text),
                Clientes_id_cliente = (int)cbClientes.SelectedValue
            };

            // Registrar el objeto
            String mensaje = nBoleta.Registrar(boleta);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarBoletas(nBoleta.ListarTodo());
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbNumero.Text == "" || tbFecha.Text == "" || cbClientes.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de selección
            if (boletaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una boleta");
                return;
            }

            // Creación del objeto
            Boleta boleta = new Boleta
            {
                id_boleta=boletaSeleccionada.id_boleta,
                numero_boleta = tbNumero.Text,
                fecha = int.Parse(tbFecha.Text),
                Clientes_id_cliente = (int)cbClientes.SelectedValue
            };

            // Registrar el objeto
            String mensaje = nBoleta.Modificar(boleta);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarBoletas(nBoleta.ListarTodo());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de selección
            if (boletaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una boleta");
                return;
            }

            // Eliminar
            String mensaje = nBoleta.Eliminar(boletaSeleccionada.id_boleta);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarBoletas(nBoleta.ListarTodo());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgBoletas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            boletaSeleccionada = dgBoletas.SelectedItem as Boleta;
        }

        private void btnBuscarClientesMasBoletasRealizadas_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (cbClientes.Text == "")
            {
                MessageBox.Show("Ingrese cliente");
                return;
            }

            // Mostrar en el DataGrid
            MostrarBoletas(nBoleta.ListarTodoPorCliente(cbClientes.Text));
        }

        private void btnBuscarPorNumero_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (tbNumero.Text == "")
            {
                MessageBox.Show("Ingrese Numero");
                return;
            }

            // Mostrar en el DataGrid
            MostrarBoletas(nBoleta.ListarTodoPorNumero(tbNumero.Text));
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            // Mostrar en el DataGrid
            MostrarBoletas(nBoleta.ListarTodo());
            MostrarClientes(nCliente.ListarTodo());
        }
    }
}
