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
        public string NombreEquipo { get; set; }
        public float IngresoPorServicio { get; set; } = 0;
        public float GastoPorTrabajadores { get; set; } = 0;
        public IDictionary<string, ITrabajador> Trabajadores { get; set; } = new Dictionary<string, ITrabajador>();

        public JefeDeEquipo(string NombreEquipo, string Nombre, float IngresoPorServicio) {
            this.NombreEquipo = NombreEquipo;
            this.Nombre = Nombre;
            this.IngresoPorServicio = IngresoPorServicio;
            this.GastoPorTrabajadores += IngresoPorServicio;
        }

        public void AddTrabajador(Trabajador ElTrabajador)
        {
            Trabajadores.Add(ElTrabajador.Nombre, ElTrabajador);
            this.GastoPorTrabajadores += ElTrabajador.IngresoPorServicio;
        }
        public string MostrarTrabajador()
        {
            return $"Nombre Jefe: {this.Nombre} Ingresa {this.IngresoPorServicio} ";
        }
        public string MostrarPeonesEquipo()
        {
            string Peones = "";
            foreach(var ElTrabajador in Trabajadores)
            {
                Peones += "\n" +ElTrabajador.Value.MostrarTrabajador();
            }
            return Peones;
        }
        public string MostrarEquipo()
        {
            return $"El equipo: {NombreEquipo}, con el nombre del jefe: {NombreEquipo} Con el siguiente gasto por servicios: {GastoPorTrabajadores} " +
                $"y ingreso por servicios: {IngresoPorServicio} Con los siguientes trabafadores {MostrarPeonesEquipo()}";
        }
    }
}
