using CFactoriaDesinfectaciones.Trabajadores;
using CFactoriaDesinfectaciones.FabricaTrabajadores;
using CFactoriaDesinfectaciones.ValidadorSueldo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFactoriaDesinfectaciones.ResultadosEmpresa;
using CFactoriaDesinfectaciones.FabricaAlnimales;
using CFactoriaDesinfectaciones.Animales;
using CFactoriaDesinfectaciones.FabricaVeneno;
using CFactoriaDesinfectaciones.ValidadorCosteVeneno;
using CFactoriaDesinfectaciones.FabricaRecurso;

namespace CFactoriaDesinfectaciones.Menu
{
    public class MenuDesinsectacines
    {
        public IFactoriaTrabajadores FactroriaDeTrabajadores = new FactoriaTrabajadores();
        public IResultados Empresa;

        public void EjecutaMenu()
        {
            Console.WriteLine("Introduce el Gerente de la empresa:");

            ITrabajador ElGerente = FactroriaDeTrabajadores.DameTrabajador(3, new ValidadorParaSueldo());
            this.Empresa = new Resultado(ElGerente as Gerente);
        }

        public void PrimerCuestionario()
        {
            int Comando = 0;
            Comando = OpcionesEmpresa();
        }

        public int OpcionesEmpresa() 
        {
            Console.WriteLine("Pulse 0 para salir del menu:");
            Console.WriteLine("Pulse 1 para mostrar el Gerente:");
            Console.WriteLine("Pulse 3 para introducir un veneno:");
            Console.WriteLine("Pulse 3 para introducir un recurso:");
            Console.WriteLine("Pulse 4 para introducir un equipo:");
            if(Empresa.ListaLosVenenos.ListaVeneno.Count != 0) Console.WriteLine("Pulse 5 para mostrar los venenos de la empresa:");
            if(Empresa.ListaLosRecursos.ListaRecurso.Count != 0)Console.WriteLine("Pulse 6 para mostrar los Recursos de la empresa:");
            if(Empresa.ListaLosEquipos.ListaEquipos.Count != 0)Console.WriteLine("Pulse 7 para mostrar los equipos de la empresa:");
            if(Empresa.Servicios.Count != 0)Console.WriteLine("Pulse 8 para mostrar los Servicios de la empresa:");
            if(Empresa.ListaLosVenenos.ListaVeneno.Count != 0)Console.WriteLine("Pulse 9 para seleccionar un veneno:");
            if(Empresa.Servicios.Count != 0)Console.WriteLine("Pulse 10 para seleccionar un servicio:");
            if(Empresa.ListaLosEquipos.ListaEquipos.Count != 0)Console.WriteLine("Pulse 11 para seleccionar un equipo:");
            if(Empresa.ListaLosRecursos.ListaRecurso.Count != 0)Console.WriteLine("Pulse 12 para seleccionar un recurso:");
            return int.Parse(Console.ReadLine());
        }

        public void RespuestaAOpcionesEmpresa(int Comando)
        {
            switch(Comando)
            {
                case 1: Empresa.ElGerente.MostrarTrabajador();
                        break;
                case 2: IFactoriaVeneno FabricaVeneno = new FactoriaVenenos();
                        Empresa.ListaLosVenenos.AddVeneno(FabricaVeneno.DameVeneno(new ValidarCoste()));
                        break;
                case 3: IFactoriaRecurso FabricaRecurso = new FactoriaRecurso();
                        Empresa.ListaLosRecursos.AddRecurso(FabricaRecurso.DameRecurso());
                        break;
                case 4: 
            }
        }
    }
}
