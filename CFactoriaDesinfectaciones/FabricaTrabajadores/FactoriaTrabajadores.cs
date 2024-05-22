using CFactoriaDesinfectaciones.Trabajadores;
using CFactoriaDesinfectaciones.ValidadorSueldo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.FabricaTrabajadores
{
    public class FactoriaTrabajadores : IFactoriaTrabajadores
    {
        public ITrabajador DameTrabajador(int Codigo, IValidarSueldo ValidadorSueldo)
        {
            string Nombre = "";
            float Coste = 0;
            string Categoria = "";
            switch (Codigo)
            {
                case 1: Categoria = "Peon";
                        break;
                case 2: Categoria = "Jefe de equipo";
                        break;
                case 3: Categoria = "Gerente";
                        break;
            }
            Console.WriteLine($"Introduce el nombre de el Trabajador:");
            Nombre = Console.ReadLine();
            Console.WriteLine($"Introduce el sueldo de el Trabajador:");
            Coste = float.Parse(Console.ReadLine());
            if (!ValidadorSueldo.ValidadorDelSueldo(Coste)) Codigo = 0;
            switch(Codigo)
            {
                case 1: return new Trabajador(Nombre, Coste);
                case 2: return new JefeDeEquipo(Nombre, Coste);
                case 3: return new Gerente(Nombre, Coste);
                default: return null;
            }
        }
    }
}
