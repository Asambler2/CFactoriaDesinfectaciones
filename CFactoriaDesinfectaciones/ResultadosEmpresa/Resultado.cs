using CFactoriaDesinfectaciones.Animales;
using CFactoriaDesinfectaciones.ListaEquipos;
using CFactoriaDesinfectaciones.ListaRecursos;
using CFactoriaDesinfectaciones.ListaVenenos;
using CFactoriaDesinfectaciones.Recursos;
using CFactoriaDesinfectaciones.Servicio;
using CFactoriaDesinfectaciones.Trabajadores;
using CFactoriaDesinfectaciones.Venenos;
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
        public ListaDeVenenos ListaLosVenenos { get; set; } = new ListaDeVenenos(new Dictionary<string, IVeneno>());
        public ListaDeRecursos ListaLosRecursos { get; set; } = new ListaDeRecursos(new Dictionary<string, IRecurso>());
        public ListaDeEquipos ListaLosEquipos { get; set; } = new ListaDeEquipos(new Dictionary<string, IJefe>());
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
