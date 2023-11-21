using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño
{
    internal class Administrador // borrar esta si se declarara como publica
    {
    }
    public class Administrador : Persona // toca borrar esta clase o la de arriba 
{
        /*  
            En esta clase según la base de datos se heredan las variables de la clase Persona.
            "Definir cuales se heredaran según la necesidad."
        */
    public string Usuario { get; set; } /* Tocaria agregarlo a la base de datos como una tabla
                                           debido a que serviria mejor como una clase padre para
                                           manejar los 3 tipos de usuar = "Administrador", "Colaborador", "Cliente".
                                           y esta clase Usuario Heredara de Persona y dara herencia a esas 3 subclases.
                                        */

    public class Parqueadero
    {
        //Agregar la variable: id_parqueadero;
        public string Nombre { get; set; } // Esta variable es: "nombre" 
        public string Tipo { get; set; } // Esta variable es: "clase"
        public string Direccion { get; set; } // Esta variable es: "direccion"
        public string Ciudad { get; set; } // Esta variable es: "ciudad"
        public string Coordenadas { get; set; } // Esta variable es: "coordenadas"
        public string ModoDeControl { get; set; } // Esta variable es: "modoDeControl"
        public int Capacidad { get; set; } // Esta variable es: "capacidad"
        //Agregar la variable: disponibilidad;
        public int Tarifa { get; set; } // Esta variable es una llave Foranea FK heredada de la clase o tabla tarifa
        public int Horario { get; set; } // Igual que tarifa solo que en la base de datos no esta relacionada a parqueadero

        public bool Disponibilidad()
        {
            // Calcular disponibilidad
            return this.Capacidad > 0;
        }

        public void Ingresar(string placa)
        {
            this.Placa = placa;
            this.FechaHoraIngreso = DateTime.Now;

            // Calcular tarifa
            double tarifaHora = this.Tarifa.TipoVehiculo == "Carro" ? this.Tarifa.ValorHora : this.Tarifa.ValorHoraAdicional;
            this.ValorTotal = tarifaHora * this.CalcularTiempo();
        }

        public void Salir()
        {
            this.FechaHoraSalida = DateTime.Now;
        }
        public void ImprimirRecibo()
        {
            // Imprimir recibo
        }

        public double CalcularTiempo()
        {
            // Calcular tiempo de estacionamiento
            return (this.FechaHoraSalida - this.FechaHoraIngreso).TotalHours;
        }

        public double CalcularValorTotal()
        {
            // Calcular valor total del estacionamiento
            return this.CalcularTiempo() * this.TarifaHora;
        }
    }
}
}
