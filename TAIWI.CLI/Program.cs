

using System;
using TAIWI.BLL.CasosDeUso;
using TAIWI.BLL.Modelos;

namespace TAIWI.CLI
{
    internal class Program
    {
        static readonly RepositorioDeProductos _repoProductos = new RepositorioDeProductos();
        static readonly RepositorioDeVentas _repoVentas = new RepositorioDeVentas();
        static void Main(string[] args)
        {

            Venta venta = new Venta();
            
            venta.DetalleVenta.Add(new ItemDeVenta
            {
                Producto = _repoProductos.ObtenerLaListaDeProductos()[1],
                Cantidad = 2,
                

            });
            venta.DetalleVenta.Add(new ItemDeVenta
            {
                Producto = _repoProductos.ObtenerLaListaDeProductos()[0],
                Cantidad = 5,


            });
            venta.DetalleVenta.Add(new ItemDeVenta
            {
                Producto = _repoProductos.ObtenerLaListaDeProductos()[4],
                Cantidad = 2,


            });

            venta.CalcularTotales();

            Console.WriteLine(venta.ToString());


                
            
        }
    }
}
