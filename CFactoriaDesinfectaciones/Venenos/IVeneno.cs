using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFactoriaDesinfectaciones.Animales;

namespace CFactoriaDesinfectaciones.Venenos
{
    public interface IVeneno
    {
        public IDictionary<Animal, int> CantidadParaMatar { get; set; }
        public string Nombre { get; set; }
        public string UdMedida { get; set; }
        public float CostePorGramo { get; set; }
        public int CompareTo(object obj);
        public string MostrarVenenos();
    }
}
