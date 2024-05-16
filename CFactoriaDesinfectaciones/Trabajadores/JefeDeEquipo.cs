using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.Trabajadores
{
    public class JefeDeEquipo : ITrabajador, IJefe
    {
        public string Nombre { get; set; }
        public float IngresoPorServicio { get; set; }
        public float GastoPorTrabajadores { get; set; }
        public List<ITrabajador> Trabajadores { get; set; }

        public JefeDeEquipo(string Nombre, float IngresoPorServicio) {
            this.Nombre = Nombre;
            this.IngresoPorServicio = IngresoPorServicio;
            this.GastoPorTrabajadores += IngresoPorServicio;
        }

        public void AddTrabajador(Trabajador ElTrabajador)
        {
            Trabajadores.Add(ElTrabajador);
            this.GastoPorTrabajadores += ElTrabajador.IngresoPorServicio;
        }
        public string MostrarTrabajador()
        {
            return $"Nombre Jefe: {this.Nombre} Ingresa {this.IngresoPorServicio} ";
        }
        public string MostrarPeonesEquipo()
        {
            string Peones = "";
            foreach(Trabajador ElTrabajador in Trabajadores)
            {
                Peones += "\n" +ElTrabajador.MostrarTrabajador();
            }
            return Peones;
        }
    }
}
