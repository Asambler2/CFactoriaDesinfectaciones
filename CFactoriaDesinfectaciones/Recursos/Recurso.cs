using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.Recursos
{
    public class Recurso : IRecurso
    {
        public string NombreRecurso { get; set; }
        public float GastoPorServivio { get; set; }

        public Recurso(string NombreRecurso, float Gasto) 
        { 
            this.NombreRecurso = NombreRecurso;
            this.GastoPorServivio = Gasto;
        }
        public  int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Recurso RecursoAComparar = obj as Recurso;
            if (RecursoAComparar != null)
                return this.NombreRecurso.CompareTo(RecursoAComparar.NombreRecurso);
            else
                throw new ArgumentException("El objeto comparado no es un recurso");
        }

        public string MostrarRecursos()
        {
            return $"Nombre Recurso: {this.NombreRecurso}, Coste por servicio: {this.GastoPorServivio}";
        }
    }
}
