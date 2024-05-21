using CFactoriaDesinfectaciones.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.FabricaCliente
{
    public class FactoriaCliente : IFactoriaCliente
    {
        public ICliente DameCliente()
        {
            string Nombre = "";
            string Telefono = "";
            string Email = "";
            string CP = "";
            Console.WriteLine("Escribe el nombre del cliente:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Escribe el telefono del cliente:");
            Telefono = Console.ReadLine();
            Console.WriteLine("Escribe el email del cliente:");
            Email = Console.ReadLine();
            Console.WriteLine("Escribe el código postal del cliente:");
            CP = Console.ReadLine();
            return new ClienteServicio(Nombre, Telefono, Email, CP);
        }
    }
}
