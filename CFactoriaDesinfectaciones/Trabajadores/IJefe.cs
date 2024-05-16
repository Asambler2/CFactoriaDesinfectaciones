using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.Trabajadores
{
    public interface IJefe
    {
        public IDictionary<string, ITrabajador> Trabajadores { get; set; }
        public float GastoPorTrabajadores { get; set; }
        public void AddTrabajador(Trabajador ElTrabajador);
        public string MostrarPeonesEquipo();
    }
}
