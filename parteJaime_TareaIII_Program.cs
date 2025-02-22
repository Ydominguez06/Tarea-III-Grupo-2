       case 2:
    Console.WriteLine("Que arreglo desea visualizar?");
    Console.WriteLine("1. Aviones");
    Console.WriteLine("2. Pasajeros");
    Console.WriteLine("3. Boletos");
    Console.WriteLine("4. Facturas");
    Console.WriteLine("5. Maletas");
    Console.Write("Seleccione un arreglo: ");
    int visualizarArreglo = int.Parse(Console.ReadLine());
    switch (visualizarArreglo)
    {
        case 1:
            MostrarArregloAviones(aviones, indiceAviones);
            break;
        case 2:
            MostrarArregloPasajeros(pasajeros, indicePasajeros);
            break;
        case 3:
            MostrarArregloBoletos(boletos, indiceBoletos);
            break;
        case 4:
            MostrarArregloFacturas(facturas, indiceFacturas);
            break;
        case 5:
            MostrarArregloMaletas(maletas, indiceMaletas);
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
    break;

case 3:
    Console.WriteLine("De que arreglo desea imprimir una posicion");
    Console.WriteLine("1. Aviones");
    Console.WriteLine("2. Pasajeros");
    Console.WriteLine("3. Boletos");
    Console.WriteLine("4. Facturas");
    Console.WriteLine("5. Maletas");
    Console.Write("Seleccione un arreglo: ");
    int imprimirArreglo = int.Parse(Console.ReadLine());

    Console.Write("Ingrese la posicion: ");
    int posicion = int.Parse(Console.ReadLine());

    switch (imprimirArreglo)
    {
        case 1:
            ImprimirPosicionAvion(aviones, posicion, indiceAviones);
            break;
        case 2:
            ImprimirPosicionPasajero(pasajeros, posicion, indicePasajeros);
            break;
        case 3:
            ImprimirPosicionBoleto(boletos, posicion, indiceBoletos);
            break;
        case 4:
            ImprimirPosicionFactura(facturas, posicion, indiceFacturas);
            break;
        case 5:
            ImprimirPosicionMaleta(maletas, posicion, indiceMaletas);
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
    break;

case 4:
    Console.WriteLine("¡Hasta luego!");
    break;

default:
    Console.WriteLine("Opción no válida.");
    break;
}

Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
        }
    }

    static void MostrarArregloAviones(string[][] aviones, int indiceAviones)
{
    for (int i = 0; i < indiceAviones; i++)
    {
        Console.WriteLine($"Avion {i + 1}:");
        Console.WriteLine($"  Numero de Registro: {aviones[i][0]}");
        Console.WriteLine($"  Modelo: {aviones[i][1]}");
        Console.WriteLine($"  Capacidad de pasajeros: {aviones[i][2]}");
        Console.WriteLine($"  Estado: {aviones[i][3]}");
        Console.WriteLine($"  Destino: {aviones[i][4]}");
        Console.WriteLine($"  Año de Fabricacion: {aviones[i][5]}");
        Console.WriteLine($"  Numero de Vuelo: {aviones[i][6]}");
        Console.WriteLine();
    }
}

static void MostrarArregloMaletas(string[][] maletas, int indiceMaletas)
{
    for (int i = 0; i < indiceMaletas; i++)
    {
        Console.WriteLine($"Maleta {i + 1}:");
        Console.WriteLine($"  Numero de Identificacion: {maletas[i][0]}");
        Console.WriteLine($"  Peso: {maletas[i][1]}");
        Console.WriteLine($"  Tamaño: {maletas[i][2]}");
        Console.WriteLine($"  Color: {maletas[i][3]}");
        Console.WriteLine($"  Estado: {maletas[i][4]}");
        Console.WriteLine($"  Nombre del Dueño: {maletas[i][5]}");
        Console.WriteLine($"  Numero de Vuelo Asociado: {maletas[i][6]}");
        Console.WriteLine();
    }
}

static void MostrarArregloPasajeros(string[][] pasajeros, int indicePasajeros)
{
    for (int i = 0; i < indicePasajeros; i++)
    {
        Console.WriteLine($"Pasajero {i + 1}:");
        Console.WriteLine($"  Nombre: {pasajeros[i][0]}");
        Console.WriteLine($"  Edad: {pasajeros[i][1]}");
        Console.WriteLine($"  Sexo: {pasajeros[i][2]}");
        Console.WriteLine($"  Nacionalidad: {pasajeros[i][3]}");
        Console.WriteLine($"  Raza: {pasajeros[i][4]}");
        Console.WriteLine($"  Religion: {pasajeros[i][5]}");
        Console.WriteLine($"  Estado civil: {pasajeros[i][6]}");
        Console.WriteLine();
    }
}

static void MostrarArregloBoletos(string[][] boletos, int indiceBoletos)
{
    for (int i = 0; i < indiceBoletos; i++)
    {
        Console.WriteLine($"Boleto {i + 1}:");
        Console.WriteLine($"  Numero de boleto: {boletos[i][0]}");
        Console.WriteLine($"  Lugar de origen: {boletos[i][1]}");
        Console.WriteLine($"  Lugar de destino: {boletos[i][2]}");
        Console.WriteLine($"  Numero de asiento: {boletos[i][3]}");
        Console.WriteLine($"  Hora de entrada: {boletos[i][4]}");
        Console.WriteLine($"  Nombre del comprador: {boletos[i][5]}");
        Console.WriteLine($"  Clase: {boletos[i][6]}");
        Console.WriteLine();
    }
}