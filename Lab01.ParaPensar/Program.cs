/* Ejercicio 1 (Suma de 2 Números)
int num1, num2;
Console.WriteLine("Ingrese el primer número: ");
num1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número: ");
num2 = Int32.Parse(Console.ReadLine());

int resultado = num1 + num2;    

Console.WriteLine("El resultado de la suma de " + num1 + " y " + num2 + " es " + resultado + ".");

*/

/* Ejercicio 2 (Año Bisiesto)
Console.WriteLine("Ingrese el Año: ");
int anio = Int32.Parse(Console.ReadLine());
if (anio % 400 == 0 ||  (anio % 4 == 0 && !(anio % 100 == 0))) {
    Console.WriteLine("Año Bisiesto");
} else {
    Console.WriteLine("Año No Bisiesto");
}
*/

/* Ejercicio 3 (Serie de Fibonacci)
int num1 = 0;
int num2 = 1;
int fibonacci;

int i = 0;
while (i < 16) {
    fibonacci = num1 + num2;
    num1 = num2;
    num2 = fibonacci;
    Console.WriteLine(fibonacci);
    i++;
}
*/

/* Ejercicio 4
for(int i = 0; i <= 100; i = i + 2) {
    Console.WriteLine(i);
}
*/

/* Ejercicio 5 (Número de Mes según su Nombre)
string[] meses = new string[] {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

Console.WriteLine("Ingrese mes: ");
string mesIngresado = Console.ReadLine();

int i = 0;
int numeroMes = 0;
while(i < 12) {
    if (meses[i].ToLower() == mesIngresado) {
        numeroMes = i + 1;
    }
    i++;
}

Console.WriteLine("Nombre del mes: " + mesIngresado + "\nNúmero del mes: " + numeroMes);
*/

// Ejercicio 6 (No Terminado)
/*string[] numerosRomanos = new string[] { "I", "V", "X", "L", "C", "D", "M" };

string numeroAConvertir = "8";

int longitudNumero = numeroAConvertir.Length;

switch (longitudNumero) {
    case 1:
        numeroConvertido = numerosRomanos[0] * Int32.Parse(numeroAConvertir);
        break;
    case 2:

        break;
    case 3:

        break;
    case 4:

        break;
    default:
        break;
}

// Así se puede repetir un char
char letra = 'L';
string letraRepetida = new string(letra, 3);

Console.WriteLine(letraRepetida);
*/