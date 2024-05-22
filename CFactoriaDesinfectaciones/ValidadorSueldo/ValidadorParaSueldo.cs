using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.ValidadorSueldo
{
    public class ValidadorParaSueldo : IValidarSueldo
    {
        public bool ValidadorDelSueldo(float sueldo)
        {
            return sueldo <= 50;
        }
    }
}
