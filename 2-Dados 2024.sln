using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados2024
{
    class Dado
    {
        int valor;

        public void Tirar(int valor)
        {
            this.valor = valor;
        }


        public void Imprimir()
        {
            Console.WriteLine("El dado tiene el valor: " +  valor);
        }

        public int RetornarValor()
        {
            return valor;
        }
    }

    class JuegoDeDados
    {
        Dado dado1 = new Dado();
        Dado dado2 = new Dado();
        Dado dado3 = new Dado();

        public void Jugar()
        {
            ConsoleKeyInfo tecla;
            do
            {
                Random rnd = new Random();

                Console.Clear();
                
                dado1.Tirar(rnd.Next(1, 7));
                dado1.Imprimir();
                dado2.Tirar(rnd.Next(1, 7));
                dado2.Imprimir();
                dado3.Tirar(rnd.Next(1, 7));
                dado3.Imprimir();
                Console.WriteLine("");

                if (dado1.RetornarValor() == dado2.RetornarValor() && dado1.RetornarValor() == dado3.RetornarValor())
                {
                    Console.WriteLine("USTED GANO!!!");
                }
                else
                {
                    Console.WriteLine("USTED PERDIO!!!");
                }

                Console.WriteLine("");
                Console.Write("Presione cualquier tecla para volver a jugar, Escape para salir...");
                tecla = Console.ReadKey();
            } while (tecla.Key != ConsoleKey.Escape);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            JuegoDeDados juego = new JuegoDeDados();
            juego.Jugar();
        }
    }
}
