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


            actualizarDatos();
            ActualizarDataSource();


        }


        public void actualizarDatos()
        {
            FechaLabelTxt.Text = ""+DateTime.Now.Day+"/"+DateTime.Now.Month +"/"+DateTime.Now.Year;
            ClienteLabelText.Text = Venta.Cliente != null || Venta.Cliente != "" ? Venta.Cliente : "Cliente";
            VentaIdLabelText.Text = Venta.Id.ToString();

            SubTotalLabelText.Text=Venta.SubTotal.ToString();   
            ImpuestoLabelText.Text= Venta.Impuesto.ToString();  
            TotalLabelText.Text =Venta.Total.ToString();    
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
                        Imp = i.Impuesto,
                        PrecioVenta = i.ToTal
                    }).ToList();

            DetalleVentaDataGrid.DataSource = DetallesDataSource;
        }

      
    }
}
