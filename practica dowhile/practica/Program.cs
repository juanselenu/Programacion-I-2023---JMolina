// See https://aka.ms/new-console-template for more information
/*  // ej 1 (ok)
Console.WriteLine("Hello, World!");
Console.WriteLine("ingresar contraseña:");
string clave = Console.ReadLine();

while (clave != "667788")
{
Console.WriteLine("clave incorrecta");
clave = Console.ReadLine();
}
Console.WriteLine("joya pa");
*/





/* //ej 2 (ok)

Console.WriteLine("ingresar un numero:");
string numero = Console.ReadLine();
int numeroInt = int.Parse(numero);

do
{
    numero = Console.ReadLine();
    numeroInt = int.Parse(numero);
}
while (numeroInt <= 0);
*/






/*
 //ejercicio 3 practica 1 ( No me da el promedio) 

Console.WriteLine("ingresar un numero:");
string numero = Console.ReadLine();
int numeroInt;
int cont = 0;
int sum = 0;
int prom = 0;
do
{
    numero = Console.ReadLine();
    numeroInt = int.Parse(numero);
    if (numeroInt > 0)
    {
        cont++;
        sum = sum + numeroInt;
    }

}
while (numeroInt <= 0);

prom = sum/cont;

Console.WriteLine("el promedio es de los numeros negativos es : " + prom);
*/






/* //Ej 4 numero mayor a 3 cifras 
using System;

Console.WriteLine("Ingrese un número:");
string numero = Console.ReadLine();
int numeroe;

do
{
    numero = Console.ReadLine();
    numeroe = int.Parse(numero);


    if (numeroe < 999)
    {

        Console.WriteLine("proba otro:");
    }
}
while (numeroe < 999);

Console.WriteLine("sos cra");
*/






/* // Ej 5 promedio numero mayor a 3 cifras( todo ok) 
Console.WriteLine("Ingrese un número:");
string numero = Console.ReadLine();
int numeroe;
int cont = 0;
int suma =0;
int promedio =0;    

do
{
    numero = Console.ReadLine();
    numeroe = int.Parse(numero);


    if (numeroe < 999)
    {
        suma = suma + numeroe;
        cont++;
        Console.WriteLine("proba otro:");
    }
}
while (numeroe < 999);

promedio = suma / cont;


Console.WriteLine("el promedio es:" + promedio);
*/














