using System;
namespace Laboratorio1_LucasLavín
{
    public class Person
    {
        //Atributos
        private string nombre;
        private string apellido;
        private string lanzar;
        private int randomNumber;
        public Person(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellido()
        {
            return apellido;
        }
        public void Lanzar(string lanzar, int randomNumber)
        {
            int randomNumber = new Random().Next(0, 3);
            if (randomNumber == 0)
            {
                lanzar = "piedra";
                this.lanzar = lanzar;
                return lanzar;
            }
            else if (randomNumber == 1)
            {
                lanzar = "papel";
                this.lanzar = lanzar;
                return lanzar;
            }
            else if (randomNumber == 2)
            {
                lanzar = "tijera";
                this.lanzar = lanzar;
                return lanzar;
            }
        }
    }
	
}