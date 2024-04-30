using EbalrezFinal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbalrezFinal.Servicios
{
    internal class FicherosImplementacion : FicherosInterfaz
    {
        public void leerFichero(List<PacienteDto>listaPaciente)
        {
            string rutafichero = "citas.txt";

            try
            {
                string[] lineas = File.ReadAllLines(rutafichero);

                foreach (string line in lineas)
                {
                    
                    string[] pacientes = line.Split(';');

                    PacienteDto paciente = new PacienteDto();

                    paciente.DniPaciente = pacientes[0];
                    paciente.Nombre = pacientes[1];
                    paciente.Apellidos = pacientes[2];
                    paciente.Especialidad = pacientes[3];
                    paciente.Fechacita = Convert.ToDateTime(pacientes[4]);
                    paciente.AsistenciaCita = pacientes[5];

                    listaPaciente.Add(paciente);


                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("No ha sido posible leer el fichero.");
            }
            
        }
    }
}
