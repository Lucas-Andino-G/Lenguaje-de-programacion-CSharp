using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco2024
{
    class Cliente
    {
        private string nombre;
        private int monto;

        public void Depositar(int importeDeposito)
        {
            monto += importeDeposito;
        }

        public void Extraccion (int importeExtaccion)
        {
            monto -= importeExtaccion;
        }

        public int RetornarMonto()
        { 
            return monto; 
        }
    }

    class Banco
    {
        Cliente cliente1 = new Cliente();
        Cliente cliente2 = new Cliente();
        Cliente cliente3 = new Cliente();

        public void Operar()
        {
            //Deposito
            cliente1.Depositar(1000);
            cliente2.Depositar(500);
            cliente3.Depositar(5000);
            //Extracción
            cliente1.Extraccion(500);
            cliente2.Extraccion(3000);
        }

        public int DepositoTotal()
        {
            Console.WriteLine("El cliente1 tiene: " + cliente1.RetornarMonto());
            Console.WriteLine("El cliente2 tiene: " + cliente2.RetornarMonto());
            Console.WriteLine("El cliente3 tiene: " + cliente3.RetornarMonto());
            return cliente1.RetornarMonto() + cliente2.RetornarMonto() + cliente3.RetornarMonto();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.Operar();
            Console.WriteLine("El saldo en el banco es: " + banco.DepositoTotal() + "Gs");

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
