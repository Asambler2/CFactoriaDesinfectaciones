using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.Trabajadores
{
    public class Gerente : ITrabajador
    {
        public string Nombre { get; set; }
        public float IngresoPorServicio { get; set; }

        public Gerente(string Nombre, float IngresoPorServivio) { 

            this.Nombre = Nombre;
            this.IngresoPorServicio = IngresoPorServicio;
        }
        public string MostrarTrabajador()
        {
            return $"Nombre Gerente: { this.Nombre } Ingresa {this.IngresoPorServicio} ";
        }
    }
}
