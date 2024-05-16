﻿using CFactoriaDesinfectaciones.Equipo;
using CFactoriaDesinfectaciones.Recursos;
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
        public List<IRecurso> Recursos { get; set; }
        public EquipoServicio ElEquipo { get; set; }

        public IDictionary<IVeneno, int> LosVenenos { get; set; }

        public float GastoTotalServicio { get; set; } = 0;
        public float IngresoTotalServicio { get; set; } = 0;

        public ServicioEquipo(string Nombre, EquipoServicio ElEquipo)
        {
            this.NombreServicio = Nombre;
            this.ElEquipo = ElEquipo;
            GastoTotalServicio += ElEquipo.GastoSalariosTotalEquipo;
            IngresoTotalServicio = (float)(GastoTotalServicio * 1.20);
        }

        public void AddRecursos(Recurso ElRecurso)
        {
            Recursos.Add(ElRecurso);
            GastoTotalServicio += ElRecurso.GastoPorServivio;
            IngresoTotalServicio = (float)(GastoTotalServicio * 1.20);
        }
        public void AddLosVenenos(int Cantidad, Veneno ElVeneno)
        {
            LosVenenos.Add(ElVeneno, Cantidad);
            GastoTotalServicio += ElVeneno.CostePorGramo * Cantidad;
            IngresoTotalServicio = (float)(GastoTotalServicio * 1.20);
        }

        public string MostrarServicio()
        {
            return $"Nombre del servicio: {this.NombreServicio}, Gasto del Servicio: {this.GastoTotalServicio}, Ingresoso del servicio: {this.IngresoTotalServicio}";
        }

        public string MostrarListaRecursosServicio()
        {
            string LosRecursos = "Recursos del servicio: ";
            foreach(Recurso ElRecurso in Recursos)
            {
                LosRecursos += "\n" + ElRecurso.MostrarRecursos();
            }
            return  LosRecursos;
        }

        public string MostrarListaVenenosServicio()
        {
            string Venenos = "Venenos del servicio: ";
            foreach (var ElVeneno in LosVenenos)
            {
                Venenos += "\n" + ElVeneno.Key.MostrarVenenos() + ", Cantidad utilizada: " + ElVeneno.Value + ", Gasto en el servicio: " + Math.Round(ElVeneno.Key.CostePorGramo * ElVeneno.Value, 2);
            }
            return Venenos;
        }
    }
}