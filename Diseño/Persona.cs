using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño
{
    internal class Persona
    {
        int Identificacion;
        string Nombre;
        int Telefono;
        string email;
        int clave;

        public int Identificacion1 { get => Identificacion; set => Identificacion = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Telefono1 { get => Telefono; set => Telefono = value; }
        public string Email { get => email; set => email = value; }
        public int Clave { get => clave; set => clave = value; }
    }
}
