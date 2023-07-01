using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAIWI.BLL.Modelos;

namespace TAIWI.BLL.CasosDeUso
{
    public class RepositorioDeVentas
    {
        private readonly List<Venta> ListaDeVentas;

        public RepositorioDeVentas()
        { 
            this.ListaDeVentas = new List<Venta>(); 
        }
        
        public List<Venta> ObtenerTodasLasVentas()
        {
            return this.ListaDeVentas;  
        }

        public void agregarUnaVenta(Venta venta)
        {
            ListaDeVentas.Add(venta);   
        }



    }

}
