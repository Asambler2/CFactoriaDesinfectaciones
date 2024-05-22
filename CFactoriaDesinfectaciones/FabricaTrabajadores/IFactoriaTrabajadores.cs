using CFactoriaDesinfectaciones.Trabajadores;
using CFactoriaDesinfectaciones.ValidadorSueldo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.FabricaTrabajadores
{
    public interface IFactoriaTrabajadores
    {
        public ITrabajador DameTrabajador(int Codigo, IValidarSueldo ValidadorSueldo);
    }
}
