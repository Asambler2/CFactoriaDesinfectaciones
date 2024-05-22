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
            Console.WriteLine("Pulse 2 para introducir un animal:");
            Console.WriteLine("Pulse 3 para introducir un veneno:");
            Console.WriteLine("Pulse 4 para introducir un recurso:");
            Console.WriteLine("Pulse 5 para introducir un equipo:");
            Console.WriteLine("Pulse 6 para mostrar los animales registrados en la empresa:");
            Console.WriteLine("Pulse 7 para mostrar los venenos de la empresa:");
            Console.WriteLine("Pulse 8 para mostrar los Recursos de la empresa:");
            Console.WriteLine("Pulse 9 para mostrar los equipos de la empresa:");
            Console.WriteLine("Pulse 10 para mostrar los Servicios de la empresa:");
            Console.WriteLine("Pulse 11 para seleccionar un veneno:");
            Console.WriteLine("Pulse 12 para seleccionar un servicio:");
            Console.WriteLine("Pulse 13 para seleccionar un equipo:");
            Console.WriteLine("Pulse 14 para seleccionar un recurso:");
            return int.Parse(Console.ReadLine());
        }

        public void RespuestaAOpcionesEmpresa(int Comando)
        {
            switch(Comando)
            {
                case 1: Empresa.ElGerente.MostrarTrabajador();
                        break;
                case 2: IFactoriaAnimales FabricaAnimal = new FactoriaAnimales();
                        Empresa.ListaLosAnimales.AddAnimal(FabricaAnimal.DameAnimal());
                        break;
                case 3: IFactoriaVeneno FabricaVeneno = new FactoriaVenenos();
                        Empresa.ListaLosVenenos.AddVeneno(FabricaVeneno.DameVeneno(new ValidarCoste()));
                        break;
            }
        }
    }
}
