using CFactoriaDesinfectaciones.ValidadorCosteVeneno;
using CFactoriaDesinfectaciones.Venenos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.FabricaVeneno
{
    public class FactoriaVenenos : IFactoriaVeneno
    {
        public IVeneno DameVeneno(IValidadorCoste ValidadorCoste)
        {
            string Nombre = "";
            string UdMedida = "";
            float CostePorGramo = 0;
            Console.WriteLine("Escribe el nombre del veneno:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Escribe la unidad de medida del veneno:");
            UdMedida = Console.ReadLine();
            Console.WriteLine("Escribe el coste por gramo del veneno:");
            CostePorGramo = float.Parse(Console.ReadLine());
            if (ValidadorCoste.ValidadorCosteVeneno(CostePorGramo)) return new Veneno(Nombre, UdMedida, CostePorGramo);
            return null;
        }
    }
}
