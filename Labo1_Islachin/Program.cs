using System;

namespace Labo1_Islachin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de CajeroAutomatico

            CuentaBancaria.CajeroAutomatico cajero = new CuentaBancaria.CajeroAutomatico { 
            NumeroCuenta = 1,
            TitularCuenta = "Luis Islachin",
            Saldo = 15555,
            PinSeguridad = 1234
            };


            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar fondos");
                Console.WriteLine("3. Retirar efectivo");
                Console.WriteLine("4. Cambiar PIN");
                Console.WriteLine("5. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        cajero.ConsultarSaldo();
                        break;
                    case "2":
                        Console.Write("Ingrese la cantidad a depositar: ");
                        decimal cantidadDeposito;
                        if (!decimal.TryParse(Console.ReadLine(), out cantidadDeposito))
                        {
                            Console.WriteLine("Cantidad inválida. Intente de nuevo.");
                            break;
                        }
                        cajero.Depositar(cantidadDeposito);
                        break;
                    case "3":
                        Console.Write("Ingrese la cantidad a retirar: ");
                        decimal cantidadRetiro;
                        if (!decimal.TryParse(Console.ReadLine(), out cantidadRetiro))
                        {
                            Console.WriteLine("Cantidad inválida. Intente de nuevo.");
                            break;
                        }
                        Console.Write("Ingrese su PIN: ");
                        int pinRetiro;
                        if (!int.TryParse(Console.ReadLine(), out pinRetiro))
                        {
                            Console.WriteLine("PIN inválido. Intente de nuevo.");
                            break;
                        }
                        try
                        {
                            cajero.Retirar(cantidadRetiro, pinRetiro);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;
                    case "4":
                        Console.Write("Ingrese su PIN actual: ");
                        int pinActual;
                        if (!int.TryParse(Console.ReadLine(), out pinActual))
                        {
                            Console.WriteLine("PIN inválido. Intente de nuevo.");
                            break;
                        }
                        Console.Write("Ingrese su nuevo PIN: ");
                        int nuevoPin;
                        if (!int.TryParse(Console.ReadLine(), out nuevoPin))
                        {
                            Console.WriteLine("PIN inválido. Intente de nuevo.");
                            break;
                        }
                        try
                        {
                            cajero.CambiarPIN(pinActual, nuevoPin);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }
    }
}
