﻿using CFactoriaDesinfectaciones.ListaAnimales;
using CFactoriaDesinfectaciones.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.ListaRecursos
{
    public class ListaDeRecursos
    {
        IDictionary<string, IRecurso> ListaRecurso = new Dictionary<string, IRecurso>();

        public void AddRecurso(IRecurso ElRecurso)
        {
            this.ListaRecurso.Add(ElRecurso.NombreRecurso, ElRecurso);
        }
        public string MostrarListaRecursos()
        {
            string Recursos = "";
            foreach (var Recurso in ListaRecurso)
            {
                Recursos += "\n" + Recurso.Value.MostrarRecursos();
            }
            return $"Lista de recursos y su información: {Recursos}";
        }
    }
}
