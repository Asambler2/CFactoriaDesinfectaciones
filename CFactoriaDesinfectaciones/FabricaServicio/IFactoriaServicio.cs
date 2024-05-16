using CFactoriaDesinfectaciones.Equipo;
using CFactoriaDesinfectaciones.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.FabricaServicio
{
    public interface IFactoriaServicio
    {
        public IServicio DameServicio(string Nombre, EquipoServicio ElEquipo);
    }
}
