﻿using CFactoriaDesinfectaciones.Trabajadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.FabricaTrabajadores
{
    public interface IFatoriaTrabajadores
    {
        public ITrabajador DameTrabajador(int Codigo, string Nombre, float Coste);
    }
}