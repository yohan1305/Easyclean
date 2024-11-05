using System;
using System.Collections.Generic;

class EasyClean
{
    static string? nombredelusuario, direcciondelusuario;
    static long telefonodelusuario;
    static bool Membresiadelusuario;

    // Variables para precios de los servicios
    static readonly int precioLavadoMuebles = 2000;
    static readonly int precioLavadoColchones = 2500;
    static readonly int precioLavadoAlfombras = 1500;
    static readonly int precioPulidoPisos = 170;
    static readonly int precioLavadoCeramica = 100;
    static readonly int precioReparacionCortinas = 1000;
    static readonly int precioLavadoVehiculo = 2500;
    static readonly int precioMantenimientoOficina = 5000;
    static readonly int precioCortinas = 3500;
    static readonly int precioLimpiezaHogar = 10000;

    static void Main()
    {
        MostrarLogo(); // Llama a la función para mostrar el logo
        MostrarMenu(); // Muestra el menú principal
    }

    // Función para mostrar el logo
    static void MostrarLogo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        string logo = @"
$$$$$$$$\                                        $$\                               
$$  _____|                                       $$ |                              
$$ |      $$$$$$\   $$$$$$$\ $$\   $$\  $$$$$$$\ $$ | $$$$$$\   $$$$$$\  $$$$$$$\  
$$$$$\    \____$$\ $$  _____|$$ |  $$ |$$  _____|$$ |$$  __$$\  \____$$\ $$  __$$\ 
$$  __|   $$$$$$$ |\$$$$$$\  $$ |  $$ |$$ /      $$ |$$$$$$$$ | $$$$$$$ |$$ |  $$ |
$$ |     $$  __$$ | \____$$\ $$ |  $$ |$$ |      $$ |$$   ____|$$  __$$ |$$ |  $$ |
$$$$$$$$\\$$$$$$$ |$$$$$$$  |\$$$$$$$ |\$$$$$$$\ $$ |\$$$$$$$\ \$$$$$$$ |$$ |  $$ |
\________|\_______|\_______/  \____$$ | \_______|\__| \_______| \_______|\__|  \__|
                             $$\   $$ |                                            
                             \$$$$$$  |                                            
                              \______/                           ";
        Console.WriteLine(logo);
        Console.ResetColor();
    }

    // Función para mostrar el menú principal
    static void MostrarMenu()
    {
        while (true)
        {
            Console.Clear();
            MostrarLogo();

            Console.WriteLine("Bienvenido a EasyClean - Tu servicio de limpieza en un clic!");
            Console.WriteLine("\nSeleccione una opción para comenzar:");
            Console.WriteLine("1. Ver lista de servicios");
            Console.WriteLine("2. Ingresar datos del usuario(lo primero)");
            Console.WriteLine("3. Programar una cita");
            Console.WriteLine("4. Salir");

            Console.Write("\nIngrese su opción: ");
            string opcion = Console.ReadLine()!;

            switch (opcion)
            {
                case "1":
                    VerServicios();
                    break;
                case "2":
                    informaciondelusuario();
                    break;
                case "3":
                    agendarcitas();
                    break;
                case "4":
                    Console.WriteLine("Gracias por usar EasyClean. ¡Hasta pronto!");
                    return; // Salir del programa
                default:
                    Console.WriteLine("Opción inválida. Por favor, intenta de nuevo.");
                    break;
            }
        }
    }

    // Función para mostrar los servicios disponibles
    static void VerServicios()
    {
        List<string> servicios = new List<string>
        {
            $"1. Lavado de muebles - Precio = {precioLavadoMuebles}$RD",
            $"2. Lavado de colchones - Precio = {precioLavadoColchones}$RD",
            $"3. Lavado de alfombras - Precio = {precioLavadoAlfombras}$RD",
            $"4. Pulido de pisos - Cada metro cuadrado - Precio = {precioPulidoPisos}$RD",
            $"5. Lavado de cerámica - Cada metro cuadrado - Precio = {precioLavadoCeramica}$RD",
            $"6. Reparación y limpieza de cortinas - Precio = {precioReparacionCortinas}$RD",
            $"7. Lavado de vehículo a domicilio - Precio = {precioLavadoVehiculo}$RD",
            $"8. Mantenimiento de oficina - Precio = {precioMantenimientoOficina}$RD",
            $"9. Venta e instalación de cortinas - Precio = {precioCortinas}$RD",
            $"10. Limpieza completa de hogar - Precio = {precioLimpiezaHogar}$RD"
        };

        Console.Clear();
        Console.WriteLine("\nServicios disponibles:\n");

        foreach (string servicio in servicios)
        {
            Console.WriteLine("- " + servicio);
        }
int total = 0;

        while (true)
        {
            Console.Write("\nSeleccione el número del servicio que desea (0 para finalizar): ");
            int seleccion = int.Parse(Console.ReadLine()!);

            if (seleccion == 0)
                break;

            switch (seleccion)
            {
                case 1:
                    total += precioLavadoMuebles;
                    Console.WriteLine("Lavado de muebles agregado al total.");
                    break;
                case 2:
                    total += precioLavadoColchones;
                    Console.WriteLine("Lavado de colchones agregado al total.");
                    break;
                case 3:
                    total += precioLavadoAlfombras;
                    Console.WriteLine("Lavado de alfombras agregado al total.");
                    break;
                case 4:
                    Console.Write("Ingrese los metros cuadrados para Pulido de pisos: ");
                    int metrosPulido = int.Parse(Console.ReadLine()!);
                    total += metrosPulido * precioPulidoPisos;
                    Console.WriteLine("Pulido de pisos agregado al total.");
                    break;
                case 5:
                    Console.Write("Ingrese los metros cuadrados para Lavado de cerámica: ");
                    int metrosCeramica = int.Parse(Console.ReadLine()!);
                    total += metrosCeramica * precioLavadoCeramica;
                    Console.WriteLine("Lavado de cerámica agregado al total.");
                    break;
                case 6:
                    total += precioReparacionCortinas;
                    Console.WriteLine("Reparación y limpieza de cortinas agregado al total.");
                    break;
                case 7:
                    total += precioLavadoVehiculo;
                    Console.WriteLine("Lavado de vehículo agregado al total.");
                    break;
                case 8:
                    total += precioMantenimientoOficina;
                    Console.WriteLine("Mantenimiento de oficina agregado al total.");
                    break;
                case 9:
                    total += precioCortinas;
                    Console.WriteLine("Venta e instalación de cortinas agregado al total.");
                    break;
                case 10:
                    total += precioLimpiezaHogar;
                    Console.WriteLine("Limpieza completa de hogar agregado al total.");
                    break;
                default:
                    Console.WriteLine("Opción de servicio no válida. Intente de nuevo.");
                    break;
            }
        }

        Console.WriteLine($"\nEl total por los servicios seleccionados es: {total}$RD");
        Console.WriteLine("\nPresiona cualquier tecla para volver al menú principal...");
        Console.ReadKey();

        Console.WriteLine("\nPresiona cualquier tecla para volver al menú principal...");
        Console.ReadKey();

    }



    // Función para capturar información del usuario
    static void informaciondelusuario()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("¿Tienes membresía especial? (1 para Sí, 0 para No)");
            string respuestaMembresia = Console.ReadLine()!;

            if (respuestaMembresia == "1")
            {
                Membresiadelusuario = true;
            }
            else if (respuestaMembresia == "0")
            {
                Membresiadelusuario = false;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Presiona cualquier tecla para intentarlo de nuevo.");
                Console.ReadKey();
                continue;
            }

            Console.WriteLine("Dime tu Nombre:");
            nombredelusuario = Console.ReadLine()!;

            Console.WriteLine("Dime tu Dirección:");
            direcciondelusuario = Console.ReadLine()!;

            Console.WriteLine("Dime tu Teléfono:");
            while (!long.TryParse(Console.ReadLine(), out telefonodelusuario) || telefonodelusuario < 999999999)
            {
                Console.WriteLine("Entrada no válida. Ingrese su número de teléfono.");
                Console.Write("Ingrese un teléfono válido: ");
            }

            Console.Clear();
            Console.WriteLine("Información capturada:");
            Console.WriteLine($"\nNombre: {nombredelusuario}");
            Console.WriteLine($"Dirección: {direcciondelusuario}");
            Console.WriteLine($"Teléfono: {telefonodelusuario}");
            Console.WriteLine($"Tiene membresía especial?: {(Membresiadelusuario ? "Sí" : "No")}");

            Console.WriteLine("\n¿Son estos tus datos?");
            Console.WriteLine("1 - Cambiar datos");
            Console.WriteLine("0 - Confirmar y salir");

            string opcionInput = Console.ReadLine()!;
            if (opcionInput == "1")
            {
                continue; // Volver a ingresar datos
            }
            else if (opcionInput == "0")
            {
                break; // Confirmar y salir
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresa 1 o 0.");
            }
        }
    }

    // Función para agendar citas
    static void agendarcitas()
    {
        while (true)
        {
            Console.WriteLine("\n¿Desea Agendar Cita? (1: SI / 2: NO)");
            string entrada = Console.ReadLine()!;

            if (int.TryParse(entrada, out int opcion) && (opcion == 1 || opcion == 2))
            {
                if (opcion == 2)
                {
                    Console.WriteLine("Ha decidido no agendar una cita.");
                    break; // Salir del bucle si elige NO
                }

                // Bucle para ingresar la fecha deseada para la cita
                string fechaCita;
                while (true)
                {
                    Console.WriteLine("Ingrese la fecha deseada para su cita (formato: DD/MM/AAAA):");
                    fechaCita = Console.ReadLine()!;

                    // Intentar parsear la fecha
                    if (DateTime.TryParseExact(fechaCita, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fecha))
                    {
                        Console.WriteLine($"Cita agendada para el {fecha.ToShortDateString()}");
                        Console.WriteLine($"{nombredelusuario}, gracias por agendar.");
                        break; // Salir del bucle de fecha si la entrada es válida
                    }
                    else
                    {
                        Console.WriteLine("Fecha no válida. Por favor, ingrese la fecha en el formato DD/MM/AAAA.");
                    }
                }
                // Salir del bucle principal después de agendar una cita
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, elija 1 para SI o 2 para NO.");
            }
        }

        
    }
}
