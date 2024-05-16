using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.ValidadorCosteVeneno
{
    public class ValidarCoste : IValidadorCoste
    {
        public bool ValidadorCosteVeneno(float Coste)
        {
            return Coste <= 2;
        }
    }
}
