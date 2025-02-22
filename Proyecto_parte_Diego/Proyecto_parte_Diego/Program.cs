static void MostrarArregloFacturas(string[][] facturas, int indiceFacturas)
{
    for (int i = 0; i < indiceFacturas; i++)
    {
        Console.WriteLine($"Factura {i + 1}:");
        Console.WriteLine($"  Numero de Factura: {facturas[i][0]}");
        Console.WriteLine($"  Nombre del Pasajero: {facturas[i][1]}");
        Console.WriteLine($"  Destino: {facturas[i][2]}");
        Console.WriteLine($"  Puerta o Gate: {facturas[i][3]}");
        Console.WriteLine($"  Precio: {facturas[i][4]}");
        Console.WriteLine($"  Metodo de Pago: {facturas[i][5]}");
        Console.WriteLine($"  Estado de Factura: {facturas[i][6]}");
        Console.WriteLine();
    }
}

static void ImprimirPosicionAvion(string[][] aviones, int posicion, int indiceAviones)
{
    if (posicion >= 0 && posicion < indiceAviones)
    {
        Console.WriteLine($"Avion en la posicion {posicion}:");
        Console.WriteLine($"  Numero de Registro: {aviones[posicion][0]}");
        Console.WriteLine($"  Modelo: {aviones[posicion][1]}");
        Console.WriteLine($"  Capacidad de pasajeros: {aviones[posicion][2]}");
        Console.WriteLine($"  Estado: {aviones[posicion][3]}");
        Console.WriteLine($"  Destino: {aviones[posicion][4]}");
        Console.WriteLine($"  Año de Fabricacion: {aviones[posicion][5]}");
        Console.WriteLine($"  Numero de Vuelo: {aviones[posicion][6]}");
    }
    else
    {
        Console.WriteLine("Posicion fuera de rango.");
    }
}

static void ImprimirPosicionPasajero(string[][] pasajeros, int posicion, int indicePasajeros)
{
    if (posicion >= 0 && posicion < indicePasajeros)
    {
        Console.WriteLine($"Pasajero en la posicion {posicion}:");
        Console.WriteLine($"  Nombre: {pasajeros[posicion][0]}");
        Console.WriteLine($"  Edad: {pasajeros[posicion][1]}");
        Console.WriteLine($"  Sexo: {pasajeros[posicion][2]}");
        Console.WriteLine($"  Nacionalidad: {pasajeros[posicion][3]}");
        Console.WriteLine($"  Raza: {pasajeros[posicion][4]}");
        Console.WriteLine($"  Religion: {pasajeros[posicion][5]}");
        Console.WriteLine($"  Estado civil: {pasajeros[posicion][6]}");
    }
    else
    {
        Console.WriteLine("Posicion fuera de rango.");
    }
}

static void ImprimirPosicionBoleto(string[][] boletos, int posicion, int indiceBoletos)
{
    if (posicion >= 0 && posicion < indiceBoletos)
    {
        Console.WriteLine($"Boleto en la posicion {posicion}:");
        Console.WriteLine($"  Numero de boleto: {boletos[posicion][0]}");
        Console.WriteLine($"  Lugar de origen: {boletos[posicion][1]}");
        Console.WriteLine($"  Lugar de destino: {boletos[posicion][2]}");
        Console.WriteLine($"  Numero de asiento: {boletos[posicion][3]}");
        Console.WriteLine($"  Hora de entrada: {boletos[posicion][4]}");
        Console.WriteLine($"  Nombre del comprador: {boletos[posicion][5]}");
        Console.WriteLine($"  Clase: {boletos[posicion][6]}");
    }
    else
    {
        Console.WriteLine("Posicion fuera de rango.");
    }
}

static void ImprimirPosicionFactura(string[][] facturas, int posicion, int indiceFacturas)
{
    if (posicion >= 0 && posicion < indiceFacturas)
    {
        Console.WriteLine($"Factura en la posicion {posicion}:");
        Console.WriteLine($"  Numero de Factura: {facturas[posicion][0]}");
        Console.WriteLine($"  Nombre del Pasajero: {facturas[posicion][1]}");
        Console.WriteLine($"  Destino: {facturas[posicion][2]}");
        Console.WriteLine($"  Puerta o Gate: {facturas[posicion][3]}");
        Console.WriteLine($"  Precio: {facturas[posicion][4]}");
        Console.WriteLine($"  Metodo de Pago: {facturas[posicion][5]}");
        Console.WriteLine($"  Estado de Factura: {facturas[posicion][6]}");
    }
    else
    {
        Console.WriteLine("Posicion fuera de rango.");
    }
}

static void ImprimirPosicionMaleta(string[][] maletas, int posicion, int indiceMaletas)
{
    if (posicion >= 0 && posicion < indiceMaletas)
    {
        Console.WriteLine($"Maleta en la posicion {posicion}:");
        Console.WriteLine($"  Numero de Identificacion: {maletas[posicion][0]}");
        Console.WriteLine($"  Peso: {maletas[posicion][1]}");
        Console.WriteLine($"  Tamaño: {maletas[posicion][2]}");
        Console.WriteLine($"  Color: {maletas[posicion][3]}");
        Console.WriteLine($"  Estado: {maletas[posicion][4]}");
        Console.WriteLine($"  Nombre del Dueño: {maletas[posicion][5]}");
        Console.WriteLine($"  Numero de Vuelo Asociado: {maletas[posicion][6]}");
    }
    else
    {
        Console.WriteLine("Posicion fuera de rango.");
    }
}
}