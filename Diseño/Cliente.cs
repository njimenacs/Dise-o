using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño
{

    public class Cliente:Persona
    {
        public string Cedula { get; set; }
        public string Direccion { get; set; }

        public class Parqueo
        {
            public string Placa { get; set; }
            public DateTime FechaHoraIngreso { get; set; }
            public DateTime FechaHoraSalida { get; set; }
            public string CodigoDeBarras { get; set; }

            public void Ingresar(string placa)
            {
                this.Placa = placa;
                this.FechaHoraIngreso = DateTime.Now;
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
                return this.CalcularTiempo() * 2000;
            }
        }


    }
}
