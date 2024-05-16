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

        public string MostrarRecursos()
        {
            return $"Nombre Recurso: {this.NombreRecurso}, Coste por servicio: {this.GastoPorServivio}";
        }
    }
}
