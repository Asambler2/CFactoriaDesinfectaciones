using CFactoriaDesinfectaciones.Animales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.ListaAnimales
{
    public class ListaDeAnimales
    {
        IDictionary<string, IAnimal> ListaAnimal = new Dictionary<string, IAnimal>();

        public void AddAnimal(IAnimal ElAnimal)
        {
            this.ListaAnimal.Add(ElAnimal.Nombre, ElAnimal);
        }

        public string MostrarListaAnimales()
        {
            string Animales = "";
            foreach(var Animal in ListaAnimal)
            {
                Animales += "\n" + Animal.Value.MostrarAnimal();
            }
            return $"Lista de animales y su información: {Animales}";
        }
    }
}
