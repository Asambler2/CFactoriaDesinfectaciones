using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.Animales
{
    public class Animal : IAnimal
    {
        public string Nombre { get; set; }

        public Animal(string nombre)
        {
            this.Nombre = nombre;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Animal AnimalAComparar = obj as Animal;
            if (AnimalAComparar != null)
                return this.Nombre.CompareTo(AnimalAComparar.Nombre);
            else
                throw new ArgumentException("El objeto comparado no es un Animal");
        }

        public string MostrarAnimal() 
        { 
            return this.Nombre; 
        }

    }
}
