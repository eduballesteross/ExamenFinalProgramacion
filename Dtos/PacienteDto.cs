using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbalrezFinal.Dtos
{
    /// <summary>
    /// Entidad Paciente
    /// <author>ebp - 30/04/2024</author>
    /// </summary>
    internal class PacienteDto
    {
        //Atributos

        long  idPaciente;
        string dniPaciente = "aaaaaaaaa";
        string nombre = "aaaaaaa";
        string apellidos = "aaaaaaa";
        string especialidad = "aaaaaaaa";
        DateTime fechacita;
        string asistenciaCita = "aaaaaaaa";
        bool esValidadoDni= false;

        public long IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string DniPaciente { get => dniPaciente; set => dniPaciente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime Fechacita { get => fechacita; set => fechacita = value; }
        public string AsistenciaCita { get => asistenciaCita; set => asistenciaCita = value; }
        public bool EsValidadoDni { get => esValidadoDni; set => esValidadoDni = value; }

        public PacienteDto(long idPaciente, string dniPaciente, string nombre, string apellidos, string especialidad, DateTime fechacita, string asistenciaCita, bool esValidadoDni)
        {
            this.idPaciente = idPaciente;
            this.dniPaciente = dniPaciente;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.especialidad = especialidad;
            this.fechacita = fechacita;
            this.asistenciaCita = asistenciaCita;
            this.esValidadoDni = esValidadoDni;
        }

        public PacienteDto() { }    



        public override string ToString()
        {
            string contenido = "\nID: " + this.IdPaciente +
                               "\nDNI:" + this.DniPaciente +
                               "\nNombre: " + this.Nombre +
                               "\nApellidos:" + this.Apellidos +
                               "\nEspecialidad: " + this.Especialidad +
                               "\nFecha Cita: " + this.Fechacita;
            return contenido;
        }
    }   
}
