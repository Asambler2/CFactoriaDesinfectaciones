using CFactoriaDesinfectaciones.Servicio;
using CFactoriaDesinfectaciones.Trabajadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.ResultadosEmpresa
{
    public interface IResultados
    {
        public IDictionary<string, ServicioEquipo> Servicios { get; set; }
        public Gerente ElGerente { get; set; }
        public float GastoTotalEmpresa { get; set; }
        public float IngresoTotalEmpresa { get; set; }

        public void AddServicio(ServicioEquipo servicio);
    }
}
