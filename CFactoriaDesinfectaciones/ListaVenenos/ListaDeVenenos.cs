﻿using CFactoriaDesinfectaciones.ListaAnimales;
using CFactoriaDesinfectaciones.Venenos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.ListaVenenos
{
    public class ListaDeVenenos
    {
        IDictionary<string, IVeneno> ListaVeneno { get; set; }

        public ListaDeVenenos(Dictionary<string, IVeneno> ListaVeneno)
        {
            this.ListaVeneno = ListaVeneno;
        }


        public void AddVeneno(IVeneno ElVeneno)
        {
            this.ListaVeneno.Add(ElVeneno.Nombre, ElVeneno);
        }
        public string MostrarListaVenenos()
        {
            string Venenos = "";
            foreach (var Veneno in ListaVeneno)
            {
                Venenos += "\n" + Veneno.Value.MostrarVenenos();
            }
            return $"Lista de animales y su información: {Venenos}";
        }
    }
}
