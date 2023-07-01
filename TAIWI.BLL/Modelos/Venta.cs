using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAIWI.BLL.Modelos
{
    public  class Venta
    {
        public long Id { get; set; }    
        public double SubTotal { get; set; }    
        public double Total { get; set; }   

        public double Impuesto { get; set; }

        public List<ItemDeVenta> DetalleVenta { get; set; }   

        public Venta()
        {
            Id = 100 + new Random().Next(1, 99) + 00;
            DetalleVenta = new List<ItemDeVenta>();  
            
        }

        public void CalcularTotales()
        {
            DetalleVenta.ForEach(item => item.CalcularTotales());
            SubTotal = DetalleVenta.Sum(d => d.Subtotal);
            Impuesto = DetalleVenta.Sum(d => d.MontoImpuesto);
            Total = DetalleVenta.Sum(d => d.ToTal);
        }


    }
}
