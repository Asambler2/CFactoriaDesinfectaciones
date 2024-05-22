using CFactoriaDesinfectaciones.Animales;
using CFactoriaDesinfectaciones.Trabajadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.ListaEquipos
{
    public class ListaDeEquipos
    {
        public IDictionary<string, IJefe> ListaEquipos { get; set; } = new Dictionary<string, IJefe>();

        public ListaDeEquipos(IDictionary<string, IJefe> ListaEquipos) 
        {
            this.ListaEquipos = ListaEquipos;
        }

        public void AddEquipo(IJefe ElJefe)
        {
            this.ListaEquipos.Add((ElJefe as ITrabajador).Nombre, ElJefe);
        }

        public string MostrarListaEquipos()
        {
            string Equipos = "";
            foreach (var Equipo in ListaEquipos)
            {
                Equipos += "\n" + Equipo.Value.MostrarAnimal();
            }
            return $"Lista de Equipos y su información: {Equipos}";
        }
    }
}
