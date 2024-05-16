using CFactoriaDesinfectaciones.Animales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.ListaAnimales
{
    public class ListaAnimales
    {
        IDictionary<string, IAnimal> ListaDeAnimales = new Dictionary<string, IAnimal>();

        public void AddRecurso(IAnimal ElAnimal)
        {
            this.ListaDeAnimales.Add(ElAnimal.Nombre, ElAnimal);
        }

        public string MostrarListaAnimales()
        {
            string Animales = "";
            foreach(var Animal in ListaDeAnimales)
            {
                Animales += "\n" + Animal.Value.MostrarAnimal();
            }
            return $"Lista de animales y su información: {Animales}";
        }
    }
}
