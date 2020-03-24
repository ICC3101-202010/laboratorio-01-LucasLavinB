using System;

namespace Laboratorio1_LucasLavín
{
    class MainClass
    {
        
        static void Main(string[] args)
        {
            Person p1 = new Person("Bob", "Kunga");

            Console.WriteLine(p1.GetNombre());
            Console.WriteLine(p1.GetApellido());
            Console.WriteLine("Llamando a Lanzar");
            Console.WriteLine(p1.Lanzar());        

        }
    }
}
