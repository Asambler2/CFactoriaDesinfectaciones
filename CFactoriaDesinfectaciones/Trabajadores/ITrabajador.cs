using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.Trabajadores
{
    public interface ITrabajador
    {
        public string Nombre { get; set; }
        public float IngresoPorServicio {  get; set; }
        public string MostrarTrabajador();
    }
}
