using CFactoriaDesinfectaciones.Trabajadores;
using CFactoriaDesinfectaciones.FabricaTrabajadores;
using CFactoriaDesinfectaciones.ValidadorSueldo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFactoriaDesinfectaciones.ResultadosEmpresa;

namespace CFactoriaDesinfectaciones.Menu
{
    public class MenuDesinsectacines
    {
        public IFactoriaTrabajadores FactroriaDeTrabajadores = new FactoriaTrabajadores();
        public IResultados Empresa;

        public void EjecutaMenu()
        {
            int Comando = 0;
            Console.WriteLine("Introduce el Gerente de la empresa:");

            ITrabajador ElGerente = FactroriaDeTrabajadores.DameTrabajador(3, new ValidadorParaSueldo());
            this.Empresa = new Resultado(ElGerente as Gerente);
        }

        public int OpcionesEmpresa() 
        {
            Console.WriteLine("Pulse 0 para salir del menu:");
            Console.WriteLine("Pulse 1 para mostrar el Gerente:");
            Console.WriteLine("Pulse 2 para introducir un animal:");
            Console.WriteLine("Pulse 3 para introducir un veneno:");
            Console.WriteLine("Pulse 4 para introducir un recurso:");
            Console.WriteLine("Pulse 5 para introducir un :");

        }
    }
}
