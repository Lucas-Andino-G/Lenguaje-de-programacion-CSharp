using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puntajes_2024
{
    class AlumnoPuntajes
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Puntaje { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<AlumnoPuntajes> alumnos = new List<AlumnoPuntajes>();
            AlumnoPuntajes alumnoPuntajes = new AlumnoPuntajes();
            alumnoPuntajes.Apellido = "Riveros";
            alumnoPuntajes.Nombre = "Cesar";
            alumnoPuntajes.Puntaje = 90;
            alumnos.Add( alumnoPuntajes );

            alumnoPuntajes = new AlumnoPuntajes();
            alumnoPuntajes.Apellido = "Alcaraz";
            alumnoPuntajes.Nombre = "Ruth";
            alumnoPuntajes.Puntaje = 80;
            alumnos.Add(alumnoPuntajes);

            Console.Clear();

            foreach (AlumnoPuntajes alumPunt in alumnos)
            {
                Console.WriteLine(alumPunt.Apellido + " " + alumPunt.Nombre + " : " + alumPunt.Puntaje);
            }

            Console.WriteLine("Presione cualquier boton para salir...");
            Console.ReadKey();
        }
    }
}
