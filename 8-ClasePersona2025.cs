//Esta linea se importa espacios de nombre "System" que contiene clases que se utilizan en varios lenguajes. Ejemplo: Console
using System;

//Aca defino la clase "Persona" con la palabra clase "public" para que sea accesible desde todas partes del programa
public class Persona
{
    //Defino las propiedades "Nombre" y "Apellido" de tipo "String"
    //Las propiedades tienen un metodo de acceso "get" y "set" lo que permiten leer y modificarlos
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    //Esta linea es un constructor de la "clase persona", se llama cuando se crea una instancia de "Persona"
    //Toma dos parametros: nombre y apellido
    public Persona(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
    }

    //Aca se crea un metodo que no devuelve ningun valor (void), se usa para mostrar mensajes en la pantalla de consola
    public void MostrarInformacion()
    {
        //Se utiliza la clase "Console" para escribir en la consola
        //Y ($"...") para añadir directamente los parametros "nombre" "apellido"
        Console.WriteLine($"Nombre: {Nombre}, Apellido: {Apellido}");
    }
}

//Aca defino la clase "Program" que se utiliza como clase principal para programar en C#
public class Program
{
    //El metodo "Main" es un metodo de entrada, cuando se ejecuta el programa, el sistema llama a este metodo
    //Sirve para recibir argumentos de lineas de comando, aunque en este caso no se utiliza
    public static void Main(string[] args)
    {
        //Aca se crea una instancia para la clase persona, se llama y se le da los valores a "nombre y apellido" ("Lucas", "Andino") respectivamente
        Persona persona = new Persona("Lucas", "Andino");

        //Se llama a la variable persona para imprimir la informacion en pantalla
        persona.MostrarInformacion();
    }
}
