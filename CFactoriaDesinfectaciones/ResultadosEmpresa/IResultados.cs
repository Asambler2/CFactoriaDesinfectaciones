using CFactoriaDesinfectaciones.Animales;
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
    public interface IResultados
    {
        public IDictionary<string, IServicio> Servicios { get; set; }
        public IDictionary<string, IAnimal> ListaDeAnimales { get; set; }
        public IDictionary<string, IVeneno> ListaDeVenenos { get; set; }
        public IDictionary<string, IRecurso> ListaDeRecursos { get; set; }

        public Gerente ElGerente { get; set; }
        public float GastoTotalEmpresa { get; set; }
        public float IngresoTotalEmpresa { get; set; }

        public void AddServicio(IServicio servicio);
    }
}
