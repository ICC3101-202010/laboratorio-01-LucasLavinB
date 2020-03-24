using System;

namespace Laboratorio1_LucasLavín
{
    class Program
    {
        public class Persona
        {
            private string nombre;
            private string apellido;
            private int lanzar;
            private string v1;
            private string v2;

            public Persona(string nombre, string apellido, int lanzar)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.lanzar = lanzar;

            }

            public Persona(string v1, string v2)
            {
                this.v1 = v1;
                this.v2 = v2;
            }

            public int Lanzar(int randomNumber)
            {

                return lanzar;
            }
            
            public string GetNombre()
            {
                return nombre;
            }
            public string GetApellido()
            {
                return apellido;
            }
        }
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Bob", "Kunga", randomNumber);

            Console.WriteLine(p1.GetNombre());
            Console.WriteLine(p1.GetApellido());
            Console.WriteLine("Llamando a Lanzar");
            var randomNumber = new Random().Next(0, 4);
            p1.Lanzar(randomNumber);
            Console.WriteLine(p1.GetNombre());
            Console.WriteLine(p1.GetApellido());
            Console.WriteLine(p1.Lanzar());

        }
    }
}
