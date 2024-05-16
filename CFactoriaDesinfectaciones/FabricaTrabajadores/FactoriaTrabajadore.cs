using CFactoriaDesinfectaciones.Trabajadores;
using CFactoriaDesinfectaciones.ValidadorSueldo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.FabricaTrabajadores
{
    public class FactoriaTrabajadore : IFatoriaTrabajadores
    {
        public ITrabajador DameTrabajador(int Codigo, string Nombre, float Coste, IValidarSueldo ValidadorSueldo)
        {
            if (ValidadorSueldo.ValidadorSueldo(Coste)) Codigo = 0;
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
