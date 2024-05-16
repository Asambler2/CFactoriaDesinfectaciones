using CFactoriaDesinfectaciones.Animales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.FabricaAlnimales
{
    public interface IFactoriaAnimales
    {
        public Animal DameAnimal(string nombre);
    }
}
