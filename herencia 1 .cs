using System;

namespace profesor
{
    class Program
    {
        static void Main(string[] args)
        {
            persona persona1 = new persona();
            persona1.nombre = "wilfredo";
            persona1.apellido = "reyes";
            persona1.cedula = 001-589654747-4;
            persona1.edad = 48;

            profesor profesor1 = new profesor();

            profesor1.sueldo = 5800000;

            Console.WriteLine(persona1.nombre);
            Console.WriteLine(persona1.apellido);
            Console.WriteLine(persona1.cedula);
            Console.WriteLine(persona1.edad);
            Console.WriteLine(profesor1.sueldo);
        }
    }
}
