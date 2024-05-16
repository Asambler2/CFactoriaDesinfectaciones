using CFactoriaDesinfectaciones.Animales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.Venenos
{
    public class Veneno : IVeneno
    {
        public string Nombre { get; set; }
        public string UdMedida { get; set; }
        public float CostePorGramo { get; set; }

        public IDictionary<Animal, int> CantidadParaMatar { get; set; }  = new Dictionary<Animal, int>();

        public Veneno(string nombre, string udMedida, float costePorGramo)
        {
            Nombre = nombre;
            UdMedida = udMedida;
            CostePorGramo = costePorGramo;
        }

        public void AddParAnimalCantidadVeneno(int cantidad, Animal ElAnimal)
        {
            CantidadParaMatar.Add(ElAnimal, cantidad);
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Veneno VenenoAComparar = obj as Veneno;
            if (VenenoAComparar != null)
                return this.Nombre.CompareTo(VenenoAComparar.Nombre);
            else
                throw new ArgumentException("El objeto comparado no es un Veneno");
        }

        public string MostrarVenenos()
        {
            string Animales = "";
            foreach(var AnimalEnLista in CantidadParaMatar)
            {
                Animales += $"Nombre animal: {AnimalEnLista.Key.MostrarAnimal()}, Cantidad de venenos: {AnimalEnLista.Value}";
            }
            return $"Nombre veneno: {this.Nombre}, Unidad de medida: {this.UdMedida}, Coste por gramo: {this.CostePorGramo} \nAnimales que puede matar y cantidad de veneno necesaria: {this.CostePorGramo}";
        }
    }
}
