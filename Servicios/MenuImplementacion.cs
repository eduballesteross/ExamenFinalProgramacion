using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbalrezFinal.Servicios
{
    /// <summary>
    /// Implementacion de los métodos de MenuInterfaz
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarMenuConsulta()
        {
            int opcion;

            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                opcion = recogerMenuConsulta();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("\nHas introducido la opción de volver al menu");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("\nMostrar Consultas");

                        break;

                    case 2:
                        Console.WriteLine("\nImprimir consultas");
                        break;

                    default:
                        break;
                }
            }
        }

        public int mostrarMenuPrincipal()
        {
            int opcion;

            Console.WriteLine("\n######################");
            Console.WriteLine("\n 0 - Cerrar Aplicación ");
            Console.WriteLine("\n 1 - Registro de llegada");
            Console.WriteLine("\n 2 - Listado de consultas");
            Console.WriteLine("\n######################");
          
            opcion = Convert.ToInt32(Console.ReadLine());   

            return opcion;  
        }
        /// <summary>
        /// Método privado que sirve para recoger la seleccion del menu
        /// <auhor>ebp-300424</auhor>
        /// </summary>
        /// <returns></returns>
        private int recogerMenuConsulta()
        {
            int opcion;

            Console.WriteLine("\n######################");
            Console.WriteLine("\n 0 - Cerrar Aplicación ");
            Console.WriteLine("\n 1 - Mostrar Consultas");
            Console.WriteLine("\n 2 - Imprimir Consultas");
            Console.WriteLine("\n######################");

            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }
    }
}
