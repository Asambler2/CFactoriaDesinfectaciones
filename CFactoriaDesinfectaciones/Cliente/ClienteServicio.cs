using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFactoriaDesinfectaciones.Cliente
{
    public class ClienteServicio : ICliente
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string CP { get; set; }

        public ClienteServicio(string nombre, string telefono, string email, string cP)
        {
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
            CP = cP;
        }
        public string MostrarCliente()
        {
            return $"Nombre ciente: {this.Nombre}, Teléfono: {this.Telefono}, Email: {this.Email}, CP: {this.CP}";
        }
    }
}
