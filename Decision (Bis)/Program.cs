Console.WriteLine("Ingrese un Texto: ");
string inputTexto = Console.ReadLine();

if (inputTexto == "")
{
    Console.WriteLine("No se ingresó ningún texto!");
}


Console.WriteLine("Opciones:\n 1 - Texto en Mayúsculas\n 2 - Texto en Minúsculas\n 3 - Longitud del Texto");
Console.WriteLine("\nIngrese opcion: ");
ConsoleKeyInfo opcion = Console.ReadKey();

switch (opcion.Key) {
    case ConsoleKey.D1:
        Console.WriteLine("\nTexto en Mayúsculas: " + inputTexto.ToUpper());
        break;
    case ConsoleKey.D2:
        Console.WriteLine("\nTexto en Minúsculas: " + inputTexto.ToLower());
        break;
    case ConsoleKey.D3:
        Console.WriteLine("\nLongitud del Texto: " + inputTexto.Length);
        break;
    default:
        Console.WriteLine("Opcion Incorrecta!");
        break;
}