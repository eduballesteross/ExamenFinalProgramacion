using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EbalrezFinal.Servicios
{
    /// <summary>
    /// Listado de los métodos relacinados con el ménu
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra y recoge la seleccion del menú principal.
        /// <author>ebp - 300424</author>
        /// </summary>
         /// <returns></returns>
        public int mostrarMenuPrincipal();

        /// <summary>
        /// Método que muestra y recoge el menu consulta
        /// <author>ebp-300424</author>
        /// </summary>
        public void mostrarMenuConsulta();
    }
}
