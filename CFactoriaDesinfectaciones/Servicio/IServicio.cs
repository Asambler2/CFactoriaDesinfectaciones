using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFactoriaDesinfectaciones.Recursos;
using CFactoriaDesinfectaciones.Equipo;
using CFactoriaDesinfectaciones.Venenos;
using CFactoriaDesinfectaciones.ResultadosEmpresa;

namespace CFactoriaDesinfectaciones.Servicio
{
    public interface IServicio
    {
        public string NombreServicio { get; set; }
        public IDictionary<string, IRecurso> Recursos { get; set; }
        public IDictionary<string, int> LosVenenos { get; set; }
        public IEquipo ElEquipo { get; set; }
        public float GastoTotalServicio { get; set; }
        public float IngresoTotalServicio { get; set; }
        public void AddRecursos(IRecurso ElRecurso);
        public void AddLosVenenos(int Cantidad, float CostePorGramo, string NombreVeneno);
        public string MostrarServicio();
        public string MostrarListaRecursosServicio();
        public string MostrarListaVenenosServicio(IResultados Empresa);
    }
}
