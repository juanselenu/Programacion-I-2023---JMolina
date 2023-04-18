// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
Console.WriteLine("ingrese un numero");
string numero  = Console.ReadLine();    
int numeroe = int.Parse(numero);
int suma = 0;

for (int i = 0; i < 5; numeroe++) ;
{
    suma = suma + numeroe;
}

Console.WriteLine("la suma es " + suma);    
*/

int suma = 0;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Ingrese el número:" + i);
    int numero = int.Parse(Console.ReadLine());
    suma += numero;
}

Console.WriteLine("La suma de los 5 números es:"+ suma);