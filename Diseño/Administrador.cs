using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño
{
    internal class Administrador
    {
    }
    public class Administrador : Persona
{
    public string Usuario { get; set; }

    public class Parqueadero
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Coordenadas { get; set; }
        public string ModoDeControl { get; set; }
        public int Capacidad { get; set; }

        public Tarifa Tarifa { get; set; }
        public Horario Horario { get; set; }

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

        public void ImprimirTicket()
        {
            // Imprimir ticket
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
