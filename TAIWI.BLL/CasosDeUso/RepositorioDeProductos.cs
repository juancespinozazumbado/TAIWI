
using System;
using System.Collections.Generic;
using TAIWI.BLL.Modelos;

namespace TAIWI.BLL.CasosDeUso
{
    public class RepositorioDeProductos
    {

        private readonly List<Producto> ListaDeProductos;

        public RepositorioDeProductos() 
        {
            this.ListaDeProductos = CargarDatos();
        }

        private List<Producto> CargarDatos()
        {

            var ListaDeProductos = new List<Producto>
          {

             new Producto{
                 Id = 100 +new Random().Next(1, 99) +00,
                Nombre = "CoCa-Cola 1 L",
                Precio = 1200

            },
              new Producto{
                 Id = 100 +new Random().Next(1, 99) +00,
                Nombre = "Pilsen 500 mL",
                Precio = 1000

            },  new Producto{
                Id = 2,
                Nombre = "Pepsi 1.5 L",
                Precio = 1200

            },  new Producto
            {
                Id = 100 +new Random().Next(1, 99) +00,
                Nombre = "Pepsi 2.5 mL",
                Precio = 800

            }, new Producto
            {
                Id = 100 +new Random().Next(1, 99) +00,
                Nombre = "Cacique 1 L",
                Precio = 7000

            },


        };
            return ListaDeProductos;        

        }
 
        public List<Producto> ObtenerLaListaDeProductos()
        {
            return this.ListaDeProductos;   
        }

        public Producto ObtenerPorIndice(int indice)
        {
            return ListaDeProductos[indice];
        }

    }
}
