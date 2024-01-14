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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarEmpleados_Click(object sender, RoutedEventArgs e)
        {
            EmpleadoWindow window = new EmpleadoWindow();
            window.Show();
        }

        private void btnAsignarDetalleBoleta_Click(object sender, RoutedEventArgs e)
        {
            DetallexBoletaWindow window= new DetallexBoletaWindow();
            window.Show();
        }

        private void btnRegistrarFactura_Click(object sender, RoutedEventArgs e)
        {
            FacturaWindow window= new FacturaWindow();
            window.Show();
        }

        private void btnAsignarDetalleFactura_Click(object sender, RoutedEventArgs e)
        {
            DetallexFacturaWindow window= new DetallexFacturaWindow();
            window.Show();
        }

        private void btnRegistrarProducto_Click(object sender, RoutedEventArgs e)
        {
            ProductoWindow window = new ProductoWindow();
            window.Show();
        }

        private void btnRegistrarCliente_Click(object sender, RoutedEventArgs e)
        {
            ClienteWindow window = new ClienteWindow();
            window.Show();
        }

        private void btnRegistrarProveedor_Click(object sender, RoutedEventArgs e)
        {
            ProveedorWindow window = new ProveedorWindow();
            window.Show();
        }

        private void btnRegistrarBoleta_Click(object sender, RoutedEventArgs e)
        {
            BoletaWindow window = new BoletaWindow();
            window.Show();
        }
    }
}
