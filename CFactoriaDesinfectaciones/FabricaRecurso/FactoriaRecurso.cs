using CFactoriaDesinfectaciones.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.FabricaRecurso
{
    public class FactoriaRecurso : IFactoriaRecurso
    {
        public IRecurso DameRecurso(string NombreRecurso, float GastoRecurso)
        {
            return new Recurso(NombreRecurso, GastoRecurso);
        }
    }
}
