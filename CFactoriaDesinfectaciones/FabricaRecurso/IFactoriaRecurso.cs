using CFactoriaDesinfectaciones.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.FabricaRecurso
{
    public interface IFactoriaRecurso
    {
        public IRecurso DameRecurso(string NombreRecurso, float GastoRecurso);
    }
}
