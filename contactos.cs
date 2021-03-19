 using System;

namespace contactos
{
    class Program
    {
        static void Main(string[] args)
        {
            contactos contactos1 = new contactos();
            {
                Console.WriteLine("introduzca nombre del contacto");
                contactos1.nombre = (Console.ReadLine());
                Console.WriteLine("introduzca apellido del contacto");
                contactos1.apellido = (Console.ReadLine());
                Console.WriteLine("introduzca direcion del contacto");
                contactos1.direcion = (Console.ReadLine());
                Console.WriteLine("introduzca telefono del contacto");
                contactos1.telefono = Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine("informacion de contacto ");
            Console.WriteLine("hola" +
                contactos1.nombre);
            Console.WriteLine("nombre ");
            Console.WriteLine(contactos1.nombre);
            Console.WriteLine("apellidos ");
            Console.WriteLine(contactos1.apellido);
            Console.WriteLine("direcion ");
            Console.WriteLine(contactos1.direcion);
            Console.WriteLine("telefono ");
            Console.WriteLine(contactos1.telefono);



        }

    }
}