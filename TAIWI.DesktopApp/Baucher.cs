using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAIWI.BLL.Modelos;

namespace TAIWI.DesktopApp
{
    public partial class Baucher : Form
    {
        private Venta Venta;
        public Baucher(Venta venta)
        {
            Venta = venta;  

            InitializeComponent();

         
            ActualizarDataSource();
        }


        private void ActualizarDataSource()
        {
            var DetallesDataSource = Venta.DetalleVenta.Select(
                    i => new
                    {
                        Detalle = i.Producto.Nombre,
                        Cant = i.Cantidad,
                        Precio = i.Producto.Precio,
                        SubTotal = i.Subtotal,
                        Impuesto = i.Impuesto,
                        PrecioVenta = i.ToTal
                    }).ToList();

            DetalleVentaDataGrid.DataSource = DetallesDataSource;
        }



       
    }
}
