using CFactoriaDesinfectaciones.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.ListaRecursos
{
    public class ListaRecursos
    {
        IDictionary<string, IRecurso> ListaDeRecursos = new Dictionary<string, IRecurso>();

        public void AddRecurso(IRecurso ElRecurso)
        {
            this.ListaDeRecursos.Add(ElRecurso.NombreRecurso, ElRecurso);
        }
    }
}
