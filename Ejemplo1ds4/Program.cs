// See https://aka.ms/new-console-template for more information

/// calculo del area de un rectangulo

int ladoA;
int ladoB;
int area;
Console.WriteLine("Ingrese el valor del lado A");
ladoA = Convert.ToInt32(Console.ReadLine());    

Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToInt32(Console.ReadLine());

area = ladoA * ladoB;

Console.WriteLine("El area del rectangulo es: " + area);

