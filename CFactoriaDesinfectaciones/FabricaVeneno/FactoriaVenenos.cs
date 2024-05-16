using CFactoriaDesinfectaciones.ValidadorCosteVeneno;
using CFactoriaDesinfectaciones.Venenos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.FabricaVeneno
{
    public class FactoriaVenenos : IFactoriaVeneno
    {
        public IVeneno DameVeneno(string nombre, string udMedida, float costePorGramo, IValidadorCoste ValidadorCoste)
        {
            if(ValidadorCoste.ValidadorCosteVeneno(costePorGramo)) return new Veneno(nombre, udMedida, costePorGramo);
            return null;
        }
    }
}
