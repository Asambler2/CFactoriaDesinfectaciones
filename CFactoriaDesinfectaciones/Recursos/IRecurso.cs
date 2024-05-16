using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.Recursos
{
    public interface IRecurso
    {
        public string NombreRecurso { get; set; }
        public float GastoPorServivio { get; set; }
        public string MostrarRecursos();
    }
}
