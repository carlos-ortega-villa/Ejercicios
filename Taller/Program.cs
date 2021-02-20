using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static int Opcion(string msj, int menor, int mayor)
        {
            int op;
            do
            {
                op = int.Parse(Console.ReadLine());
                if (op < menor || op > mayor)
                {
                    Console.WriteLine(msj);
                    Console.ReadKey();
                }
            } while (op < menor && op > mayor);
            return op;
        }
        public static void Menu()
        {
            int OP = 9;
            do
            {
                Console.Clear();
                Console.WriteLine("|°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°|");
                Console.WriteLine("                                 Menu                                ");
                Console.WriteLine("1<- Sacar de Promedios");
                Console.WriteLine("2<- Obtener Pulsaciones  ");
                Console.WriteLine("3<- Ingresar Informacion Financiera");
                Console.WriteLine("0<- EXIT");
                Console.WriteLine("Elija una opcion");
                OP = Opcion("Los valores ingresados no estan disponibles", 0, 3);
                switch (OP)
                {
                    case 0: Console.WriteLine("Programa Terminado");Console.ReadKey(); break;
                    case 1: sacarPromedios(); break;
                    case 2: obtenerPulsaciones(); break;
                    case 3: informeFinanciero(); break;
                    default:
                        Console.WriteLine("Error, digite solamente los numeros correspondientes");
                        break;
                }
            } while (OP != 0);
        }
        public static void sacarPromedios()
        {
            double primeraNota;
            double segundaNota;
            double terceraNota;
            double definitivaDeNotas;
            Console.Write("Escriba las notas con coma(,) despues del entero");
            Console.WriteLine();
            Console.Write("Digite la nota del Primer Corte: ");
            primeraNota = Double.Parse(Console.ReadLine());
            Console.Write("Digite la nota del Segundo Corte: ");
            segundaNota = Double.Parse(Console.ReadLine());
            Console.Write("Digite la nota del Tercer Corte: ");
            terceraNota = Double.Parse(Console.ReadLine());
            definitivaDeNotas = ((primeraNota + segundaNota + terceraNota) / 3);
            Console.WriteLine();
            if (definitivaDeNotas >= 3)
            {
                Console.Write($"|||El estudiante gano ,Su nota definitiva es: {definitivaDeNotas}|||");
            }
            else
            {
                Console.Write($"|||El estudiante perdio,Su nota definitiva es: {definitivaDeNotas}|||");
            }
            Console.ReadKey();
        }
        public static void obtenerPulsaciones()
        {
            string Nombre;
            string Sexo;
            int Edad;
            decimal TotalDePulsaciones;
            Console.Write("Bienvenido,digite su nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Digite su Sexo para mujer (F) o para hombre (M): ");
            Sexo = Console.ReadLine();
            Console.WriteLine("Digite su edad");
            Edad = Convert.ToInt32(Console.ReadLine());
            if (Sexo.ToUpper() == "F")
            {
                TotalDePulsaciones = (220 - Edad) / 10;
            }
            else if (Sexo.ToUpper() == "M")
            {
                TotalDePulsaciones = (210 - Edad) / 10;
            }
            else
            {
                TotalDePulsaciones = 0;
            }
            Console.WriteLine($"|||Su nombre es: {Nombre} |||| Su edad es: {Edad} ||||| Su sexo es: {Sexo}|||");
            Console.WriteLine($"|||El total de sus pulsaciones es: {TotalDePulsaciones}|||");
            Console.ReadKey();
        }
        public static void informeFinanciero() 
        {
            string validacionCaracter;
            string nombreCliente;
            int numeroDeCuenta;
            double saldoCuentaInicial;
            double consignacionCuenta;
            double retiroCuenta;
            double saldoTotal;
            Console.WriteLine("Bienvenido querido Cliente, Digite su nombre: ");
            nombreCliente = Console.ReadLine();
            Console.WriteLine("Digite su numero de Cuenta: ");
            numeroDeCuenta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Establezca su saldo inicial: ");
            saldoCuentaInicial = double.Parse(Console.ReadLine());
            Console.WriteLine(" Desea hacer una consignacion Si(S) o No (N): ");
            validacionCaracter = Console.ReadLine();
            if (validacionCaracter.ToUpper() == "S")
            {
                Console.WriteLine("Digite el monto a consignar: ");
                consignacionCuenta = Double.Parse(Console.ReadLine());
                saldoTotal = saldoCuentaInicial + consignacionCuenta;
            }
            else
            {
                consignacionCuenta = 0;
                saldoTotal = saldoCuentaInicial;
            }
            Console.WriteLine(" Desea hacer un retiro Si(S) o No (N): ");
            validacionCaracter = Console.ReadLine();
            if (validacionCaracter.ToUpper() == "S")
            {
                Console.WriteLine("Digite el monto a retirar: ");
                retiroCuenta = Double.Parse(Console.ReadLine());
                saldoTotal = saldoTotal - retiroCuenta;
            }
            else
            {
                retiroCuenta = 0;
                saldoTotal = saldoCuentaInicial;
            }
            Console.WriteLine($"||||Su nombre es: {nombreCliente} ||| Su numero de cuenta es: {numeroDeCuenta}" +
                $" ||| Su saldo inicial fue de: {saldoCuentaInicial} ||| ");
            Console.WriteLine($"|||Hizo una consignacion de {consignacionCuenta} " +
                $"||| Hizo un retiro de {retiroCuenta} ||| Su saldo final es: {saldoTotal}||| ");
            Console.ReadKey();
        }

    }
}


