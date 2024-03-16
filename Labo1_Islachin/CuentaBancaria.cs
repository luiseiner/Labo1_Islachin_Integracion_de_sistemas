using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Labo1_Islachin
{
    public class CuentaBancaria
    {
       
        public int NumeroCuenta { get; set; }
        public string TitularCuenta { get; set; }
        public decimal Saldo { get; set; }
        public int PinSeguridad { get; set; }

        public class CajeroAutomatico : CuentaBancaria
        {

            public void ConsultarSaldo()
            {
                Console.WriteLine($"Saldo actual: {Saldo}");
            }


            public void Depositar(decimal cantidad)
            {
                Saldo += cantidad;
                Console.WriteLine($"Se ha depositado {cantidad} en la cuenta. Nuevo saldo: {Saldo}");
            }

            public void Retirar(decimal monto, int pin)
            {
                if (pin != PinSeguridad)
                {
                    throw new InvalidOperationException("PIN incorrecto.");
                }

                if (monto <= 20)
                {
                    throw new ArgumentException("La cantidad a retirar debe ser mayor que cero.");
                }
                if (monto >= 2000)
                {
                    throw new ArgumentException("Solo se puede retirar 2000 por transaccion");
                }

                if (monto > Saldo)
                {
                    throw new InvalidOperationException("Saldo insuficiente.");
                }

                Saldo -= monto;
                Console.WriteLine($"Se han retirado {monto} de la cuenta. Nuevo saldo: {Saldo}");
            }

            public void CambiarPIN(int pinActual, int nuevoPin)
            {
                if (pinActual != PinSeguridad)
                {
                    throw new InvalidOperationException("PIN actual incorrecto.");
                }

                if (pinActual == nuevoPin)
                {
                    throw new ArgumentException("El nuevo PIN no puede ser igual al PIN actual.");
                }

                PinSeguridad = nuevoPin;
                Console.WriteLine("PIN cambiado correctamente.");
            }
        }


    }
}
