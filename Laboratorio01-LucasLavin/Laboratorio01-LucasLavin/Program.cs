using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01_LucasLavin
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Bob", "Kunga");

            Console.WriteLine(p1.GetNombre());
            Console.WriteLine(p1.GetApellido());
            Console.WriteLine("Llamando a Lanzar");
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            Console.WriteLine(p1.Lanzar(randomNumber));
            Console.ReadKey();

        }
    }
}
