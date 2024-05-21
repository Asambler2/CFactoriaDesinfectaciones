using CFactoriaDesinfectaciones.Animales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.FabricaAlnimales
{
    public class FactoriaAnimales : IFactoriaAnimales
    {
        public Animal DameAnimal()
        {
            string Nombre = "";
            Console.WriteLine("Introduce el nombre del animal");
            Nombre = Console.ReadLine();
            return new Animal(Nombre);
        }
    }
}
