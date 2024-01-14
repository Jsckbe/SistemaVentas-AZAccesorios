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
    /// Lógica de interacción para DetallexBoletaWindow.xaml
    /// </summary>
    public partial class DetallexBoletaWindow : Window
    {
        private NDetallexBoleta nDetallexBoleta = new NDetallexBoleta();
        private NBoleta nBoleta = new NBoleta();
        private NProducto nProducto = new NProducto();
        public DetallexBoletaWindow()
        {
            InitializeComponent();
            MostrarDetallexBoleta(nDetallexBoleta.ListarTodo());
            MostrarBoletas(nBoleta.ListarTodo());
            MostrarProductos(nProducto.ListarTodo());
        }

        private void MostrarDetallexBoleta(List<DetallesxBoleta> detallexBoletas)
        {
            dgDetallexBoletas.ItemsSource = new List<DetallesxBoleta>();
            dgDetallexBoletas.ItemsSource = detallexBoletas;
        }

        private void MostrarBoletas(List<Boleta> boletas)
        {
            cbBoleta.ItemsSource = new List<Boleta>();
            cbBoleta.ItemsSource = boletas;
            cbBoleta.DisplayMemberPath = "numero_boleta";
            cbBoleta.SelectedValuePath = "id_boleta";
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
            if (cbBoleta.Text == "" || cbProducto.Text == "" || tbCantidad.Text == "" || tbPrecio.Text=="" || tbImporte.Text=="" || tbMontoTotal.Text=="")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            DetallesxBoleta detallexBoleta = new DetallesxBoleta
            {
                Boleta_id_boleta = (int)cbBoleta.SelectedValue,
                Productos_id_producto = (int)cbProducto.SelectedValue,
                cantidad_producto_boleta = int.Parse(tbCantidad.Text),
                precio_unitario = int.Parse(tbPrecio.Text),
                importe_producto_boleta = int.Parse(tbImporte.Text),
                monto_total = int.Parse(tbMontoTotal.Text)
            };

            // Asignar el objeto
            String mensaje = nDetallexBoleta.Asignar(detallexBoleta);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarDetallexBoleta(nDetallexBoleta.ListarTodo());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
