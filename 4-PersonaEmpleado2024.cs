using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaEmpleado2024
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void Imprimir()
        {
            Console.WriteLine(Nombre + " tiene " + Edad + " años ");
        }
    }

    class Empleado : Persona
    {
        public int Sueldo { get; set; }
        public void ImprimirSueldo()
        {
            Console.WriteLine("El sueldo de " + Nombre + " es " + Sueldo + "Gs.");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Persona persona = new Persona();
            persona.Nombre = "Silvana Rios";
            persona.Edad = 20;
            persona.Imprimir();
            */

            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Silvana Rios";
            empleado1.Edad = 20;
            empleado1.Sueldo = 3000000;
            empleado1.Imprimir();
            empleado1.ImprimirSueldo();

            //Se crea otro empleado
            Empleado empleado2 = new Empleado();
            empleado2.Nombre = "Ruben Benitez";
            empleado2.Edad = 19;
            empleado2.Sueldo = 1600000;
            empleado2.Imprimir();
            empleado2.ImprimirSueldo();


            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadLine();
        }
    }
}
