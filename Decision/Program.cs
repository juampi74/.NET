Console.WriteLine("Ingrese un Texto: ");
string inputTexto = Console.ReadLine();

if (inputTexto == "") {
    Console.WriteLine("No se ingresó ningún texto!");
}


Console.WriteLine("Opciones:\n 1 - Texto en Mayúsculas\n 2 - Texto en Minúsculas\n 3 - Longitud del Texto");
Console.WriteLine("\nIngrese opcion: ");
ConsoleKeyInfo opcion = Console.ReadKey();

if (opcion.Key == ConsoleKey.D1) {
    Console.WriteLine("\nTexto en Mayúsculas: " + inputTexto.ToUpper());
} else if (opcion.Key == ConsoleKey.D2) {
    Console.WriteLine("\nTexto en Minúsculas: " + inputTexto.ToLower());
} else if (opcion.Key == ConsoleKey.D3) {
    Console.WriteLine("\nLongitud del Texto: " + inputTexto.Length);
} else {
    Console.WriteLine("Opcion Incorrecta!");
}