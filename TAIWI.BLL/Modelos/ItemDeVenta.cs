using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAIWI.BLL.Modelos
{
    public class ItemDeVenta
    {
        public long Id { get; set; }     

        public Producto Producto {  get; set; } 

        public int Cantidad { get; set; }   

        public double Impuesto { get; set; } 
        
        public double MontoImpuesto { get; set; }   

        public double Subtotal { get; set; }    

        public double ToTal { get; set; }


        public void  CalcularTotales() 
        {
            Id = 100 + new Random().Next(1, 99);
            Subtotal = Cantidad * Producto.Precio;
            calculoImpuesto();
            MontoImpuesto = Subtotal * Impuesto;
            ToTal = Subtotal - MontoImpuesto;

        }  
        
        private void calculoImpuesto()
        {
            if(Producto.Precio <= 1000)
                Impuesto = 0.08;
            if (Producto.Precio > 1000 && Producto.Precio < 5000)
                Impuesto = 0.1;
            if (Producto.Precio >= 5000)
                Impuesto = 0.13;

        }

    }

}
