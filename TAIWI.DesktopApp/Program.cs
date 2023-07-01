using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAIWI.BLL.CasosDeUso;

namespace TAIWI.DesktopApp
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RepositorioDeProductos _repopositiriodeProductos = new RepositorioDeProductos();
            RepositorioDeVentas _repositorioDeVentas = new RepositorioDeVentas();   


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TAIWI(_repopositiriodeProductos,_repositorioDeVentas ));
        }
    }
}
