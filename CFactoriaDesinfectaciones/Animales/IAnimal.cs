using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.Animales
{
    public interface IAnimal
    {
        public string Nombre { get; set; }
        public string MostrarAnimal();
    }
}
