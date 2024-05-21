using CFactoriaDesinfectaciones.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.FabricaRecurso
{
    public class FactoriaRecurso : IFactoriaRecurso
    {
        public IRecurso DameRecurso()
        {
            string NombreRecurso = "";
            float GastoRecurso = 0;
            Console.WriteLine("Escribe el nombre del recurso:");
            NombreRecurso = Console.ReadLine();
            Console.WriteLine("Escribe el gasto del recurso:");
            GastoRecurso = float.Parse(Console.ReadLine());
            return new Recurso(NombreRecurso, GastoRecurso);
        }
    }
}
