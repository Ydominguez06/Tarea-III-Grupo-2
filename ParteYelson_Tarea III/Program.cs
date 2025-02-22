using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParteYelson_Tarea_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int indiceAviones = 0, indicePasajeros = 0, indiceBoletos = 0, indiceFacturas = 0;
            int indiceMaletas = 0;

            int tamAviones = 10;
            int tamPasajeros = 100;
            int tamBoletos = 100;
            int tamFacturas = 100;
            int tamMaletas = 100;

            int camposPasajeros = 7;
            int camposBoletos = 7;
            int camposFactura = 7;
            int camposAvion = 7;
            int camposMaleta = 7;

            string[][] aviones = new string[tamAviones][];
            string[][] pasajeros = new string[tamPasajeros][];
            string[][] boletos = new string[tamBoletos][];
            string[][] facturas = new string[tamFacturas][];
            string[][] maletas = new string[tamMaletas][];

            while (opcion != 4)
            {
                Console.WriteLine("Bienvenido al menu");
                Console.WriteLine("1. Agregar al Arreglo");
                Console.WriteLine("2. Visualizar el Arreglo");
                Console.WriteLine("3. Imprimir alguna posicion");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Que arreglo desea agregar?");
                        Console.WriteLine("1. Aviones");
                        Console.WriteLine("2. Pasajeros");
                        Console.WriteLine("3. Boletos");
                        Console.WriteLine("4. Facturas");
                        Console.WriteLine("5. Maletas");
                        Console.Write("Seleccione un arreglo: ");
                        int arreglo = int.Parse(Console.ReadLine());

                        switch (arreglo)
                        {
                            case 1:
                                if (indiceAviones < tamAviones)
                                {
                                    aviones[indiceAviones] = new string[camposAvion];

                                    Console.Write("Numero de registro: ");
                                    aviones[indiceAviones][0] = Console.ReadLine();

                                    Console.Write("Modelo: ");
                                    aviones[indiceAviones][1] = Console.ReadLine();

                                    Console.Write("Capacidad de pasajeros: ");
                                    aviones[indiceAviones][2] = Console.ReadLine();

                                    Console.Write("Estado (En Servicio o En Mantenimiento): ");
                                    aviones[indiceAviones][3] = Console.ReadLine();

                                    Console.Write("Destino: ");
                                    aviones[indiceAviones][4] = Console.ReadLine();

                                    Console.Write("Año de fabricacion: ");
                                    aviones[indiceAviones][5] = Console.ReadLine();

                                    Console.Write("Numero de Vuelo: ");
                                    aviones[indiceAviones][6] = Console.ReadLine();

                                    indiceAviones++;
                                }
                                else
                                {
                                    Console.WriteLine("Arreglo de aviones lleno.");
                                }
                                break;

                            case 2:
                                if (indicePasajeros < tamPasajeros)
                                {
                                    pasajeros[indicePasajeros] = new string[camposPasajeros];

                                    Console.Write("Nombre: ");
                                    pasajeros[indicePasajeros][0] = Console.ReadLine();

                                    Console.Write("Edad: ");
                                    pasajeros[indicePasajeros][1] = Console.ReadLine();

                                    Console.Write("Sexo: ");
                                    pasajeros[indicePasajeros][2] = Console.ReadLine();

                                    Console.Write("Nacionalidad: ");
                                    pasajeros[indicePasajeros][3] = Console.ReadLine();

                                    Console.Write("Raza: ");
                                    pasajeros[indicePasajeros][4] = Console.ReadLine();

                                    Console.Write("Religion: ");
                                    pasajeros[indicePasajeros][5] = Console.ReadLine();

                                    Console.Write("Estado civil: ");
                                    pasajeros[indicePasajeros][6] = Console.ReadLine();

                                    indicePasajeros++;
                                }
                                else
                                {
                                    Console.WriteLine("Arreglo de pasajeros lleno.");
                                }
                                break;

                            case 3:
                                if (indiceBoletos < tamBoletos)
                                {
                                    boletos[indiceBoletos] = new string[camposBoletos];

                                    Console.Write("Numero de boleto: ");
                                    boletos[indiceBoletos][0] = Console.ReadLine();

                                    Console.Write("Lugar de origen: ");
                                    boletos[indiceBoletos][1] = Console.ReadLine();

                                    Console.Write("Lugar de destino: ");
                                    boletos[indiceBoletos][2] = Console.ReadLine();

                                    // Validación del número de asiento
                                    Console.Write("Numero de asiento (1-500): ");
                                    string asiento = Console.ReadLine();
                                    if (!int.TryParse(asiento, out int numAsiento) || numAsiento < 1 || numAsiento > 500)
                                    {
                                        Console.WriteLine("Número de asiento no válido. Debe ser un número entre 1 y 500.");
                                        break;
                                    }
                                    boletos[indiceBoletos][3] = asiento;

                                    // Validación de la hora de entrada
                                    Console.Write("Hora de entrada (HH:MM): ");
                                    string horaEntrada = Console.ReadLine();
                                    if (!System.Text.RegularExpressions.Regex.IsMatch(horaEntrada, @"^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$"))
                                    {
                                        Console.WriteLine("Formato de hora no válido. Use HH:MM.");
                                        break;
                                    }
                                    boletos[indiceBoletos][4] = horaEntrada;

                                    Console.Write("Nombre del comprador: ");
                                    boletos[indiceBoletos][5] = Console.ReadLine();

                                    Console.Write("Clase: ");
                                    boletos[indiceBoletos][6] = Console.ReadLine();

                                    indiceBoletos++;
                                }
                                else
                                {
                                    Console.WriteLine("Arreglo de boletos lleno.");
                                }
                                break;

                            case 4:
                                if (indiceFacturas < tamFacturas)
                                {
                                    facturas[indiceFacturas] = new string[camposFactura];

                                    Console.Write("Numero de Factura: ");
                                    facturas[indiceFacturas][0] = Console.ReadLine();

                                    Console.Write("Nombre del Pasajero: ");
                                    facturas[indiceFacturas][1] = Console.ReadLine();

                                    Console.Write("Destino: ");
                                    facturas[indiceFacturas][2] = Console.ReadLine();

                                    Console.Write("Puerta o Gate: ");
                                    facturas[indiceFacturas][3] = Console.ReadLine();

                                    Console.Write("Precio: ");
                                    facturas[indiceFacturas][4] = Console.ReadLine();

                                    Console.Write("Metodo de Pago: ");
                                    facturas[indiceFacturas][5] = Console.ReadLine();

                                    Console.Write("Estado de Factura: ");
                                    facturas[indiceFacturas][6] = Console.ReadLine();

                                    indiceFacturas++;
                                }
                                else
                                {
                                    Console.WriteLine("Arreglo de facturas lleno.");
                                }
                                break;

                            case 5:
                                if (indiceMaletas < tamMaletas)
                                {
                                    maletas[indiceMaletas] = new string[camposMaleta];

                                    Console.Write("Numero de Identificacion de la Maleta: ");
                                    maletas[indiceMaletas][0] = Console.ReadLine();

                                    // Validación del peso de la maleta (200 libras)
                                    Console.Write("Peso de la Maleta (en libras): ");
                                    string peso = Console.ReadLine();
                                    if (!int.TryParse(peso, out int pesoMaleta) || pesoMaleta != 200)
                                    {
                                        Console.WriteLine("Peso no válido. Debe ser exactamente 200 libras.");
                                        break;
                                    }
                                    maletas[indiceMaletas][1] = peso;

                                    Console.Write("Tamaño de Maleta: ");
                                    maletas[indiceMaletas][2] = Console.ReadLine();

                                    Console.Write("Color de la Maleta: ");
                                    maletas[indiceMaletas][3] = Console.ReadLine();

                                    // Validación del estado de la maleta
                                    Console.Write("Estado de la Maleta (entregada o perdida): ");
                                    string estado = Console.ReadLine();
                                    if (estado.ToLower() != "entregada" && estado.ToLower() != "perdida")
                                    {
                                        Console.WriteLine("Estado no válido. Debe ser 'entregada' o 'perdida'.");
                                        break;
                                    }
                                    maletas[indiceMaletas][4] = estado;

                                    Console.Write("Nombre del Dueño: ");
                                    maletas[indiceMaletas][5] = Console.ReadLine();

                                    Console.Write("Numero de Vuelo Asociado: ");
                                    maletas[indiceMaletas][6] = Console.ReadLine();

                                    indiceMaletas++;
                                }
                                else
                                {
                                    Console.WriteLine("Arreglo de maletas lleno.");
                                }
                                break;

                            default:
                                Console.WriteLine("Opción no válida.");
                                break;
                        }
                        break;


                }
            }
        }
    }
}
