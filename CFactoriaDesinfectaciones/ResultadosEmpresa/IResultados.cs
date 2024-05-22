using CFactoriaDesinfectaciones.Animales;
using CFactoriaDesinfectaciones.Recursos;
using CFactoriaDesinfectaciones.Servicio;
using CFactoriaDesinfectaciones.Trabajadores;
using CFactoriaDesinfectaciones.Venenos;
using CFactoriaDesinfectaciones.ListaEquipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFactoriaDesinfectaciones.ListaRecursos;
using CFactoriaDesinfectaciones.ListaVenenos;

namespace CFactoriaDesinfectaciones.ResultadosEmpresa
{
    public interface IResultados
    {
        public IDictionary<string, IServicio> Servicios { get; set; }
        public ListaDeVenenos ListaLosVenenos { get; set; }
        public ListaDeRecursos ListaLosRecursos { get; set; }
        public ListaDeEquipos ListaLosEquipos { get; set; }

        public Gerente ElGerente { get; set; }
        public float GastoTotalEmpresa { get; set; }
        public float IngresoTotalEmpresa { get; set; }

        public void AddServicio(IServicio servicio);
    }
}
