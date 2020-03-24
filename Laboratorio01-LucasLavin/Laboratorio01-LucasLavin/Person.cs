using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01_LucasLavin
{
    public class Person
    {
        //Atributos
        private string nombre;
        private string apellido;

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
        public string Lanzar(int randomNumber)
        {
            if (randomNumber == 0)
            {
                string lanzar = "piedra";
                return lanzar;
            }
            else if (randomNumber == 1)
            {
                string lanzar = "papel";
                return lanzar;
            }
            else
            {
                string lanzar = "tijera";
                return lanzar;
            }
        }
    }

}
