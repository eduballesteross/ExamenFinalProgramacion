using EbalrezFinal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbalrezFinal.Servicios
{
    /// <summary>
    /// Listados de métodos relacionados con el uso de ficheros
    /// <author> ebp - 30/04/2024</author>
    /// </summary>
    internal interface FicherosInterfaz
    {
        public void leerFichero(List<PacienteDto> listaPaciente);
    }
}
