using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TAIWI.BLL.CasosDeUso;
using TAIWI.BLL.Modelos;

namespace TAIWI.DesktopApp
{
    public partial class TAIWI : Form
    {
        private readonly RepositorioDeProductos _repositorioDeProductos;
        private readonly RepositorioDeVentas _repositorioDeVentas;
        private Venta ventaActual;
        public TAIWI(RepositorioDeProductos Productos, RepositorioDeVentas Ventas)
        {
            this._repositorioDeVentas = Ventas; 
            this._repositorioDeProductos = Productos;  
            
            ventaActual = new Venta();

            InitializeComponent();

            var productos = _repositorioDeProductos.ObtenerLaListaDeProductos();

            this.ProductosComboBox.DataSource = productos.Select(i => i.Nombre).ToList();

            actualizarDataGrid();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // logica 
                if (CantTextBox.Text != "" || CantTextBox.Text != null)
                {
                    var indice = ProductosComboBox.SelectedIndex;
                    var producto = _repositorioDeProductos.ObtenerPorIndice(indice);
                    int cantidad = int.Parse(CantTextBox.Text);
                    ventaActual.DetalleVenta.Add(new ItemDeVenta
                    {
                        Cantidad = cantidad,
                        Producto = producto
                    });
                    ventaActual.CalcularTotales();

                    actualizarDataGrid();
                    limpiarCuadrosDeTexto();
                    ActualizarLabelsTotalesDeVenta();

                }

            }
            catch(Exception ex) { 
                Console.WriteLine(ex.ToString());
            }
        }

        private void ProductosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indice = ProductosComboBox.SelectedIndex;
            var producto = _repositorioDeProductos.ObtenerPorIndice(indice);
            PrecioTextBox.Text = producto.Precio.ToString();
        }

        private void actualizarDataGrid()
        {
            var DetallesDataSource = ventaActual.DetalleVenta.Select(
                    i=> new
                    {
                      Detalle = i.Producto.Nombre,
                      Cantidad = i.Cantidad,
                      Precio = i.Producto.Precio,
                      SubTotal = i.Subtotal,
                      Impuesto = i.Impuesto,    
                      MontoImuesto = i.MontoImpuesto,
                      PrecioVenta = i.ToTal
                    }).ToList();

            DetalleVentaDataGrid.DataSource = DetallesDataSource;
        }

        private void ActualizarLabelsTotalesDeVenta()
        {
            SubtotalLabelText.Text = ventaActual.SubTotal.ToString();
            ImpuestosLabelText.Text = ventaActual.Impuesto.ToString();
            TotalLabelText.Text = ventaActual.Total.ToString(); 
        }

        private void limpiarCuadrosDeTexto()
        {
            ProductosComboBox.SelectedIndex = 0;
            PrecioTextBox.Text = "";
            CantTextBox.Text = "";
        }

        private void TerminarVentaBtn_Click(object sender, EventArgs e)
        {

            _repositorioDeVentas.agregarUnaVenta(ventaActual);
            ventaActual = new Venta();

            SubtotalLabelText.Text = "0";
            TotalLabelText.Text = "0";
            ImpuestosLabelText.Text = "0";
            limpiarCuadrosDeTexto();
            ActualizarLabelsTotalesDeVenta();
            actualizarDataGrid();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ImprimirVentaBtn_Click(object sender, EventArgs e)
        {
            Baucher baucher = new Baucher(ventaActual);
            baucher.Activate();
            baucher.Show();
        }
    }
}
