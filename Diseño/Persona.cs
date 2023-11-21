using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño  // Recomiendo antes de que sigan, que primero conecten la base de datos a el proyecto
{
    internal class Persona
    {
        // Camparación de variables con la base de datos

        //agregar int id_persona;
        int Identificacion;
        string Nombre;
        int Telefono; /* esta variables es: "telefono" en minuscula.. */
        string email;
        //agregar fechaDeNacimiento;
        int clave;

        public int Identificacion1 { get => Identificacion; set => Identificacion = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Telefono1 { get => Telefono; set => Telefono = value; }
        public string Email { get => email; set => email = value; }
        public int Clave { get => clave; set => clave = value; }
    }
}
