using CFactoriaDesinfectaciones.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.FabricaCliente
{
    public interface IFactoriaCliente
    {
        public ICliente DameCliente(string nombre, string telefono, string email, string cP);
    }
}
