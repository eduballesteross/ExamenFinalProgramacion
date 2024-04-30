using EbalrezFinal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbalrezFinal.Servicios
{
    /// <summary>
    /// Listado de métodos relacionados con las distintas funciones de la aplicacion
    /// <auhor>ebp -300424</auhor>
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Método que sirve para comprobar la cita a traves del dni
        /// </summary>
        /// <param name="listapaciente"></param>
        public void registroLLegada(List<PacienteDto> listapaciente);

        /// <summary>
        /// /Método que sirve para validar el DNI
        /// </summary>
        /// <param name="listapaciente"></param>
        public void validarDNI(List<PacienteDto> listapaciente);

        public void mostrarMenuConsulta(List<PacienteDto>listaPaciente);
    }
}
