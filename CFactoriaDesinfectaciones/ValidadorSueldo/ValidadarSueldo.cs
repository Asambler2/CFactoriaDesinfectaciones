using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.ValidadorSueldo
{
    public class ValidadarSueldo : IValidarSueldo
    {
        public bool ValidadorSueldo(float sueldo)
        {
            return sueldo <= 50;
        }
    }
}
