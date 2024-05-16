using CFactoriaDesinfectaciones.ValidadorCosteVeneno;
using CFactoriaDesinfectaciones.Venenos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.FabricaVeneno
{
    public interface IFactoriaVeneno
    {
        public IVeneno DameVeneno(string nombre, string udMedida, float costePorGramo, IValidadorCoste ValidadorCoste);
    }
}
