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

            Empleado empleado = new Empleado();
            empleado.Nombre = "Silvana Rios";
            empleado.Edad = 20;
            empleado.Sueldo = 3000000;
            empleado.Imprimir();
            empleado.ImprimirSueldo();

            //Se crea otro empleado
            empleado = new Empleado();
            empleado.Nombre = "Ruben Benitez";
            empleado.Edad = 19;
            empleado.Sueldo = 1600000;
            empleado.Imprimir();
            empleado.ImprimirSueldo();

            empleado = new Empleado();
            empleado.Nombre = "Lucas Andino";
            empleado.Edad = 19;
            empleado.Sueldo = 9600000;
            empleado.Imprimir();
            empleado.ImprimirSueldo();


            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadLine();
        }
    }
}
