// See https://aka.ms/new-console-template for more information
using System;

bool valor1 = true;
bool valor2 = true;
bool valor3 = true;

bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd);

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr);

bool resultAndOr = (valor1 && valor2) || valor3;
Console.WriteLine(resultAndOr);

bool resultadoNot = !valor1;
Console.WriteLine(resultadoNot);

bool resultadoXor = valor1 ^ valor2; //XOR = not or (es decir lo opuesto a la or)
Console.WriteLine(resultadoXor);

resultadoXor = (valor1 ^ valor2) ^ valor3; //XOR ^ XOR es decir primero saca el binario T/F de la primera Xor y luego lo compara con la segunda
Console.WriteLine(resultadoXor);