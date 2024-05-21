using CFactoriaDesinfectaciones.Servicio;
using CFactoriaDesinfectaciones.Trabajadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.ResultadosEmpresa
{
    public class Resultado : IResultados
    {
        public IDictionary<string, IServicio> Servicios { get; set; } = new Dictionary<string, IServicio>();
        public Gerente ElGerente { get; set; }
        public float GastoTotalEmpresa { get; set; } = 0;
        public float IngresoTotalEmpresa { get; set; } = 0;

        public Resultado(Gerente ElGerente) { 
            this.ElGerente = ElGerente;
        }

        public void AddServicio(IServicio Servicio)
        {
            Servicios.Add(Servicio.NombreServicio, Servicio);
            GastoTotalEmpresa += Servicio.GastoTotalServicio;
            IngresoTotalEmpresa = (float)(this.GastoTotalEmpresa * 1.20);
        }
    }
}
