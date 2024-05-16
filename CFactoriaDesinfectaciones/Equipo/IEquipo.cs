using CFactoriaDesinfectaciones.Trabajadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.Equipo
{
    public interface IEquipo
    {
        public JefeDeEquipo Jefe { get; set; }
        public float GastoSalariosTotalEquipo { get; set; }

        public string MostrarEquipo();
    }
}
