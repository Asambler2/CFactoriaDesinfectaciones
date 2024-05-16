using CFactoriaDesinfectaciones.Trabajadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.Equipo
{
    public class EquipoServicio : IEquipo
    {
        public JefeDeEquipo Jefe { get; set; }
        public float GastoSalariosTotalEquipo { get; set; } = 0;

        public string MostrarEquipo()
        {
            this.GastoSalariosTotalEquipo = this.Jefe.GastoPorTrabajadores;
            return $"Nombre Jefe: {this.Jefe.MostrarTrabajador()} \nPeones del Equipo: {this.Jefe.MostrarPeonesEquipo()}\nGasto del equipo: {this.GastoSalariosTotalEquipo}";
        }
    }
}
