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

        public string MostrarAnimal() 
        { 
            return this.Nombre; 
        }

    }
}
