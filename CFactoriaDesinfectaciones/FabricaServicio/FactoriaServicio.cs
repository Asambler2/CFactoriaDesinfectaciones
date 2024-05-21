using CFactoriaDesinfectaciones.Cliente;
using CFactoriaDesinfectaciones.Equipo;
using CFactoriaDesinfectaciones.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.FabricaServicio
{
    public class FactoriaServicio : IFactoriaServicio
    {
        public IServicio DameServicio(IEquipo ElEquipo, ICliente Cliente)
        {
            string Nombre = "";
            Console.WriteLine("Escribe el nombre del servicio:");
            Nombre = Console.ReadLine();
            return new ServicioEquipo(Nombre, ElEquipo, Cliente);
        }
    }
}
