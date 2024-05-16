using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.Trabajadores
{
    public class Trabajador : ITrabajador
    {
        public string Nombre { get; set; }
        public float IngresoPorServicio { get; set; }

        public Trabajador(string Nombre,float IngresoPorServicio) {

            this.Nombre = Nombre;
            this.IngresoPorServicio = IngresoPorServicio;
        }
        public string MostrarTrabajador()
        {
            return $"Nombre Peon: {this.Nombre} Ingresa {this.IngresoPorServicio} ";
        }
    }
}
