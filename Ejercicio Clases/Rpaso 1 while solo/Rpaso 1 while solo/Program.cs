// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
// Ej 1 - pero con IF
/*
Console.WriteLine("ingrese un numero:");    
int suma = 0;
int numeroe = 1; 
while (numeroe != 0)
{
    string numero = Console.ReadLine();
    numeroe = int.Parse(numero);
    if (numeroe < 0)
    {
        Console.WriteLine("ingresa un numero positivo");
    }
    else
        suma = suma+numeroe;
    }

Console.WriteLine("el total es:" + suma);

/*

/*
// Ej 1-2 ( sin if y juntos)
Console.WriteLine("Hola, por favor ingresa un numro positivo: ");
string? numero = Console.ReadLine();
int numeroa = int.Parse(numero);
int cont = 0;
int suma = 0;
while (numeroa != 0)
{
    suma = numeroa + suma;
    cont = cont + 1;
    Console.WriteLine("ingrese otro numero");
    numero = Console.ReadLine();
    numeroa = int.Parse(numero);

}
Console.WriteLine("La suma de los numeros ingresados es ; " + suma);
int prom = suma / cont;
Console.WriteLine("El promedio de los numeros que te pedimos es ; " + prom);
*/


// ej 3 suma de nimbres 
/*
Console.WriteLine("Porfavor ingresa un nombre!: ");
string mnombre = Console.ReadLine();
int cont1 = 0;

while (mnombre != "")
{
    cont1 = cont1 + 1;
    Console.WriteLine("Porfavor ingresa otro nombre!: ");
    mnombre = Console.ReadLine();
}
Console.WriteLine("la cantidad de nombres ingresados es : " + cont1);

*/

// Ej numero 4

/*

Console.WriteLine("ingrese el costo: ");
string costo = Console.ReadLine();
Console.WriteLine(" ingrese el total: ");
string total = Console.ReadLine();
int Costo = int.Parse(costo);
int Total = int.Parse(total);
int sumac = 0;
int sumat = 0;
int sumatotal = 0;

while (Costo != 0)
{
    sumac = Costo + sumac;
    sumat = Total + sumat;
    Console.WriteLine("ingrese el costo: ");
    string costoa = Console.ReadLine();
    Costo = int.Parse(costoa);
    Console.WriteLine(" ingrese el total: ");
    string totala = Console.ReadLine();
    Total = int.Parse(totala);

}
sumatotal = sumat + sumac;
Console.WriteLine("El total es:" + sumatotal);
*/


// Ej numero 4 pero Bien interpretado 

/*
 Console.WriteLine("Porfa ingreseme el costo");
string costo = Console.ReadLine();
int costoNum = int.Parse(costo);
int sumita = 0 ;

while (costoNum > 0)
{

    Console.WriteLine("Ahora poneme el total");
    string total = Console.ReadLine();
    int totalNum = int.Parse(total);

    // En estancia yo ya tengo ingresado al menos 1 par de costo y total
    // así ´que acá sería un buen momento de hacer mi proceso
    sumita = sumita  + (costoNum * totalNum);

    Console.WriteLine("Porfa ingreseme el costo");
    costo = Console.ReadLine();
    costoNum = int.Parse(costo);
}

Console.WriteLine("Flaco , pusiste: " + sumita);

 */




// ej 5 ( con for) afanado de la clase. 
/*
 Console.WriteLine("Porfa ingreseme el costo");
string costo = Console.ReadLine();
int costoNum = int.Parse(costo);
int sumita = 0 ;

while (costoNum > 0)
{

    Console.WriteLine("Ahora poneme el total");
    string total = Console.ReadLine();
    int totalNum = int.Parse(total);

    // En estancia yo ya tengo ingresado al menos 1 par de costo y total
    // así ´que acá sería un buen momento de hacer mi proceso
    sumita = sumita  + (costoNum * totalNum);

    Console.WriteLine("Porfa ingreseme el costo");
    costo = Console.ReadLine();
    costoNum = int.Parse(costo);
}

Console.WriteLine("Flaco , pusiste: " + sumita);
*/