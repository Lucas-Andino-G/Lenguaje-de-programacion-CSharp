using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_Resta
{
    class Operacion
    {
        public int valor1 { get; set; }
        public int valor2 { get; set; }
        public int Resultado { get; set; }
    }

    class Suma : Operacion
    {
        public int RetornarResultado()
        {
            Resultado = valor1 + valor2;
            return Resultado;
        }
    }

    class Resta : Operacion
    {
        public int RetornarResultado()
        {
            Resultado = valor1 - valor2;
            return Resultado;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Suma suma = new Suma();
            suma.valor1 = 5;
            suma.valor2 = 8;
            Console.WriteLine("El resultado de " + suma.valor1 + " + " + suma.valor2 + " es: " + suma.RetornarResultado());
            
            Resta resta = new Resta();
            resta.valor1 = 10;
            resta.valor2 = 6;
            Console.WriteLine("El resultado de " + resta.valor1 + " - " + resta.valor2 + " es: " + resta.RetornarResultado());

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
