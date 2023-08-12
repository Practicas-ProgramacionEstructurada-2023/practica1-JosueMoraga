using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declaracion de variables
            string? Nombre;
            int edad;
            string? direccion;
            int telefono;
            string? universidad;
            string? carrera;
            string? facultad;
            int ciclo;
            
            Console.WriteLine("\n**********Practica 1 - Programacion estructurada**********");
            Console.WriteLine("\n");
            
            Console.WriteLine("Ingrese su nombre completo");//obtener datos
            Nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese su edad");//obtener datos
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese su direccion");//obtener datos
            direccion = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese su numero de telefono");//obtener datos
            telefono = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese el nombre de la universidad en la que estudia");//obtener datos
            universidad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese el nombre de su carrera");//obtener datos
            carrera = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese el nombre de su facultad");//obtener datos
            facultad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese el ciclo en el que se encuentra");//obtener datos
            ciclo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            //imprimiendo datos
            




        }
    }
}