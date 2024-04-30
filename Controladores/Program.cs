using EbalrezFinal.Dtos;
using EbalrezFinal.Servicios;

namespace EbalrezFinal.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// <author>ebp - 300424</author>
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// <author>ebp - 30042024</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            FicherosInterfaz ficheroI = new FicherosImplementacion();
            MenuInterfaz menuI = new MenuImplementacion();
            OperativaInterfaz operaI = new OperativaImplementacion();   

            List<PacienteDto> listaPaciente = new List<PacienteDto>();  

            int opcion;

            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                ficheroI.leerFichero(listaPaciente);

                opcion = menuI.mostrarMenuPrincipal();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("\nHas introducido la opción de cerrar la aplicación");
                        cerrarMenu = true; 
                        break;

                    case 1:
                        operaI.registroLLegada(listaPaciente);  
                        break;

                    case 2:
                        operaI.mostrarMenuConsulta(listaPaciente);  
                        break;  

                    default:
                        break;
                }
            }
        }
    }
}