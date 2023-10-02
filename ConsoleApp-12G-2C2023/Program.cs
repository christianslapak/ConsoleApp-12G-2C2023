using System;

namespace ConsoleApp_12G_2C2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 20;
            //if ( a + b > 20)
            //{
            //    Console.WriteLine("Es mayor");
            //}
            //else
            //{
            //    Console.WriteLine("Es menor");
            //}


            Persona p = new Persona();
            p.DNI = 12345678;
            p.Apellido = "Martinez";
            p.Nombre = "Manuel";

            Console.WriteLine(p.MostrarDatos());
            Console.ReadKey();

            Alumno a = new Alumno();
            a.DNI = 9876543;
            a.Apellido = "Gonzalez";
            a.Nombre = "Andrea";
            a.Legajo = 7009876;
            a.Materia = "PNT1";

            Console.WriteLine(a.MostrarDatos());
            Console.ReadKey();

        }
    }
}
