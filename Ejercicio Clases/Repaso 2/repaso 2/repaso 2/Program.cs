// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");

// pedir 5 numeros, guardarlos en una lista de int y mostrar el promedio 
/*
List<int> numero = new List<int>();

int suma = 0;
int prom = 0;
int total = 0;
Console.WriteLine("ingrese un numero");
string numero = Console.ReadLine();

List<int> numero = new List<int>(); 
if (numero.Count >= 5 );
{
    prom++;
  suma = suma + numero.Count;   
}

total = prom/ numero.Count;
*/





// pedir 5 numeros, guardarlos en una lista de int y mostrar el promedio 
//estructura rep
Console.WriteLine("ingrese un numero");
string numero = Console.ReadLine();
int numeroe = int.Parse(numero);

int suma = 0; 
int promedio = 0;   
int total = 0;

List<int> listanumeros = new List<int>();
listanumeros.Add(numeroe);  

if (numeroe >= 0) 
{
    var prom = listanumeros.Average();
    promedio++;
  suma = suma + numeroe;
  total = promedio / numeroe;
}
Console.WriteLine("el toal es:" + prom);








