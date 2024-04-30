using EbalrezFinal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbalrezFinal.Servicios
{

    /// <summary>
    /// Implementacion de métodos relacionados con las distintas funciones de la aplicacion
    /// <auhor>ebp -300424</auhor>
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void mostrarConsulta(List<PacienteDto> listaPaciente)
        {
            int opcion;

            bool cerrarMenu = false;

            while (!cerrarMenu)
            {


                opcion = recogerSeleccionConsulta();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("\nHas introducido la opción de cerrar la aplicación");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("Introduce una fecha (dd-MM-yyyy");
                        DateTime fechaAux =Convert.ToDateTime(Console.ReadLine());  

                        foreach(PacienteDto paciente in listaPaciente)
                        {
                            if (fechaAux.Date.Equals(paciente.Fechacita.Date)&&paciente.Especialidad=="Psicología")
                            {
                                Console.WriteLine("Nombre Completo: "+paciente.Nombre + " " + paciente.Apellidos + " Hora" +paciente.Fechacita);
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("Introduce una fecha (dd-MM-yyyy");
                        DateTime fechaAuxii = Convert.ToDateTime(Console.ReadLine());

                        foreach (PacienteDto paciente in listaPaciente)
                        {
                            if (fechaAuxii.Date.Equals(paciente.Fechacita.Date) && paciente.Especialidad == "Traumatología")
                            {
                                Console.WriteLine("Nombre Completo: " + paciente.Nombre + " " + paciente.Apellidos + " Hora" + paciente.Fechacita);
                            }
                        }
                       
                        break;

                    case 3:
                        Console.WriteLine("Introduce una fecha (dd-MM-yyyy");
                        DateTime fechaAuxiii = Convert.ToDateTime(Console.ReadLine());

                        foreach (PacienteDto paciente in listaPaciente)
                        {
                            if (fechaAuxiii.Date.Equals(paciente.Fechacita.Date) && paciente.Especialidad == "Fisioterapia")
                            {
                                Console.WriteLine("Nombre Completo: " + paciente.Nombre + " " + paciente.Apellidos + " Hora" + paciente.Fechacita);
                            }
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        public void registroLLegada(List<PacienteDto> listapaciente)
        {
            Console.WriteLine("Introduzca su DNI: ");
            string auxDni = Console.ReadLine();

            DateTime fechaAux = DateTime.Now; 

            foreach (PacienteDto paciente in listapaciente) 
            {
                if (auxDni.Equals(paciente.DniPaciente) && fechaAux.Date.Equals(paciente.Fechacita.Date))
                {
                    Console.WriteLine("Espere su turno para la consulta de " + paciente.Especialidad + " en la sala de espera. Su especialista le avisará.");
                }
                else
                {
                    Console.WriteLine("No dispone de cita previa para hoy");
                   break;
                }
            }

        }

        public void validarDNI(List<PacienteDto> listapaciente)
        {
            foreach (PacienteDto paciente in listapaciente)
            {
                if (paciente.EsValidadoDni = false)
                {
                    paciente.DniPaciente=
                }
            }
        }

        private int  recogerSeleccionConsulta()
        {
                int opcion;

                Console.WriteLine("\n######################");
                Console.WriteLine("\n 0 - Psícologia ");
                Console.WriteLine("\n 1 - Traumatología");
                Console.WriteLine("\n 2 - Fisioterapía");
                Console.WriteLine("\n######################");

                opcion = Convert.ToInt32(Console.ReadLine());

                return opcion;

        }
    }
}