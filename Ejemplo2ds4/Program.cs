// See https://aka.ms/new-console-template for more information
using System.Transactions;

var radio = 1.1;
var resultado = 1.1;

const double PI = 3.1416;   
Console.WriteLine("Bienvenidos, calculemos circulos!");

Console.WriteLine("Ingrese el radio del circulo:");
radio = Convert.ToDouble(Console.ReadLine());
  
resultado = PI * radio * radio;

Console.WriteLine($"El area del circulo es: {resultado}");
