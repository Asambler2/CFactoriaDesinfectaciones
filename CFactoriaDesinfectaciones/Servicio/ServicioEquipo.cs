using CFactoriaDesinfectaciones.Cliente;
using CFactoriaDesinfectaciones.Equipo;
using CFactoriaDesinfectaciones.Recursos;
using CFactoriaDesinfectaciones.ResultadosEmpresa;
using CFactoriaDesinfectaciones.Venenos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.Servicio
{
    public class ServicioEquipo : IServicio
    {
        public string NombreServicio { get; set; }
        public ICliente ElCliente { get; set; }
        public IDictionary<string, IRecurso> Recursos { get; set; } = new Dictionary<string, IRecurso>();
        public IEquipo ElEquipo { get; set; }

        public IDictionary<string, int> LosVenenos { get; set; } = new Dictionary<string, int>();

        public float GastoTotalServicio { get; set; } = 0;
        public float IngresoTotalServicio { get; set; } = 0;

        public ServicioEquipo(string Nombre, IEquipo ElEquipo, ICliente ElCliente)
        {
            this.NombreServicio = Nombre;
            this.ElEquipo = ElEquipo;
            this.ElCliente = ElCliente;
            GastoTotalServicio += ElEquipo.GastoSalariosTotalEquipo;
            IngresoTotalServicio = (float)(GastoTotalServicio * 1.20);
        }

        public void AddRecursos(IRecurso ElRecurso)
        {
            Recursos.Add(ElRecurso.NombreRecurso, ElRecurso);
            GastoTotalServicio += ElRecurso.GastoPorServivio;
            IngresoTotalServicio = (float)(GastoTotalServicio * 1.20);
        }
        public void AddLosVenenos(int Cantidad, float CostePorGramo, string NombreVeneno)
        {
            LosVenenos.Add(NombreVeneno, Cantidad);
            GastoTotalServicio += CostePorGramo * Cantidad;
            IngresoTotalServicio = (float)(GastoTotalServicio * 1.20);
        }

        public string MostrarServicio()
        {
            return $"Nombre del servicio: {this.NombreServicio}, Gasto del Servicio: {this.GastoTotalServicio}, Ingresoso del servicio: {this.IngresoTotalServicio}";
        }

        public string MostrarListaRecursosServicio()
        {
            string LosRecursos = "Recursos del servicio: ";
            foreach(var ElRecurso in Recursos)
            {
                LosRecursos += "\n" + ElRecurso.Value.MostrarRecursos();
            }
            return  LosRecursos;
        }

        public string MostrarListaVenenosServicio(IResultados Empresa)
        {
            string Venenos = "Venenos del servicio: ";
            foreach (var ElVeneno in LosVenenos)
            {
                Venenos += "\n" + ElVeneno.Key + ", Cantidad utilizada: " + ElVeneno.Value + ", Gasto en el servicio: " + Math.Round(Empresa.ListaLosVenenos.ListaVeneno[ElVeneno.Key].CostePorGramo * ElVeneno.Value, 2);
            }
            return Venenos;
        }
    }
}
