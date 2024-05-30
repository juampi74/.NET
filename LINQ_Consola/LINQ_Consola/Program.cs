using Clases;
using System.Collections;

string[] provincias = new string[] {"Tierra del Fuego","Santa Cruz","Chubut", "Rio Negro", "Neuquen", "La Pampa", "Buenos Aires", "Mendoza", "San Luis", "Cordoba", "Santa Fe", "Entre Rios", "San Juan", "La Rioja", "Catamarca", "Tucuman", "Santiago del Estero", "Chaco", "Corrientes", "Misiones", "Formosa", "Salta", "Jujuy"};

var provinciasST = (from p in provincias
                    where p.StartsWith("S") || p.StartsWith("T")
                    select p);

foreach (string p in provinciasST) {
    Console.WriteLine(p);
}

Console.WriteLine("----------------------------------------------------");

List<int> numeros = new List<int>(){1,21,32,4,56,20};

var mayoresA20 = (from n in numeros
                    where n > 20
                    select n);

foreach (int n in mayoresA20) {  
    Console.WriteLine(n);
}

Console.WriteLine("----------------------------------------------------");

List<Ciudad> ciudades = new List<Ciudad>() {new Ciudad("Rosario", 2000), new Ciudad("Parana", 2002), new Ciudad("Santa Fe", 2100), new Ciudad("Bahia Blanca", 4050), new Ciudad("Calamuchita", 3000), new Ciudad("Rafaela", 4630), new Ciudad("Funes", 3250), new Ciudad("Roldan", 9850), new Ciudad("Puerto Madryn", 7950), new Ciudad("Palermo", 2390)};

Console.WriteLine("Ingrese descripcion parcial de una ciudad: ");
string ciudadBuscada = Console.ReadLine().ToLower();

var cpCiudadesCoincidentes = (from cc in ciudades
                              where cc.nombre.Contains(ciudadBuscada)
                              select cc.codPostal);

foreach (int cp in cpCiudadesCoincidentes) {
    Console.WriteLine(cp);
}

Console.WriteLine("----------------------------------------------------");

List<Empleado> empleados = new List<Empleado>() {new Empleado(1, "Pedro", 2000), new Empleado(2, "Cirilo", 15), new Empleado(3, "Gianluca", 8000)};

var empleadosConMejorSueldo = (from emp in empleados
                              orderby emp.sueldo descending
                              select emp);

foreach (var emp in empleadosConMejorSueldo) {
    Console.WriteLine(emp.id);
    Console.WriteLine(emp.nombre);
    Console.WriteLine(emp.sueldo);
    Console.WriteLine("---------------");
}
