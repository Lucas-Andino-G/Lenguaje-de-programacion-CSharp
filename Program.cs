using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puntajes
{
    class AlumnosPuntaje
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Puntaje { get; set; }
    }
    
    internal class Program
    {
        /*
        List<AlumnosPuntaje> alumnos = new List<AlumnosPuntaje> {
                new AlumnosPuntaje {Apellido = "MELGAREJO", Nombre = "IVAN", Puntaje = 75},
                new AlumnosPuntaje {Apellido = "RIVEROS", Nombre = "CESAR", Puntaje = 90},
                new AlumnosPuntaje {Apellido = "ALCARAZ", Nombre = "RUTH", Puntaje = 80},
                new AlumnosPuntaje {Apellido = "RIOS", Nombre = "SILVANA", Puntaje = 70},
                new AlumnosPuntaje {Apellido = "MELGAREJO", Nombre = "HORACIO", Puntaje = 60}
            };
        */

        static List<AlumnosPuntaje> alumnos = new List<AlumnosPuntaje>();

        static void mostrarPlanilla()
        {
            var alumnosConsulta = from alumno in alumnos
                                  where alumno.Puntaje >= 60
                                  orderby alumno.Puntaje descending
                                  select alumno;

            Console.Clear();
            Console.WriteLine("+----------------------------------------+----------------------------------------+-------+");
            Console.WriteLine("|APELLIDO                                |NOMBRE                                  |PUNTAJE|");
            Console.WriteLine("+----------------------------------------+----------------------------------------+-------+");
            foreach (var alumno in alumnosConsulta)
            {
                Console.WriteLine("|" + alumno.Apellido.PadRight(40) + "|" + alumno.Nombre.PadRight(40) + "|" + alumno.Puntaje.ToString().PadLeft(7) + "|");
            }
            Console.WriteLine("+----------------------------------------+----------------------------------------+-------+");

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }

        static void ingresarDatos()
        {
            AlumnosPuntaje alumnosPuntaje = new AlumnosPuntaje();
            Console.Write("Ingrese el apellido: ");
            alumnosPuntaje.Apellido = Console.ReadLine();
            Console.Write("Ingrese el nombre: ");
            alumnosPuntaje.Nombre = Console.ReadLine();
            Console.Write("Ingrese el puntaje: ");
            alumnosPuntaje.Puntaje = int.Parse(Console.ReadLine());

            alumnos.Add(alumnosPuntaje);
            
            Console.WriteLine("");
            Console.WriteLine("Se han ingresado los datos a la planilla.");
            Console.WriteLine("Presione cualquier tecla para regresar...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            string opcion = "";
            do
            {
                Console.Clear();
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("");
                Console.WriteLine("1. Cargar Datos");
                Console.WriteLine("");
                Console.WriteLine("2. Mostrar Planilla");
                Console.WriteLine("");
                Console.WriteLine("3. Salir");
                Console.WriteLine("");
                Console.Write("Teclee una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ingresarDatos();
                        break;
                    case "2":
                        mostrarPlanilla();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Opción no válida...");
                        break;
                }
            } while (opcion != "3");


        }
    }
}
