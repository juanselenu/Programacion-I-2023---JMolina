// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Ej numero 1 

/*
int suma = 0;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Ingrese el número:" + i);
    int numero = int.Parse(Console.ReadLine());
    suma += numero;
}

Console.WriteLine("La suma de los 5 números es:"+ suma);
*/

//Ej numero 2 

/*
int suma =0;    
int prom =0;
int cont = 0;
for (int i = 0; i < 8; i++) 
{
    Console.WriteLine("ingrese un numero:" + i);            
    int numero  = int.Parse(Console.ReadLine());
    suma = suma + numero;
    cont++;
}
prom = suma / cont;

Console.WriteLine("el promedio es:" + prom);
*/

// Ej 5

/* 
int elMayorGasto = 0;
string elNombreDelFlacoQueMasGasto = "";

for (int i = 1; i <= 5 ; i++)
{
   Console.WriteLine("Porfa ingreseme el nombre del pibe ");
   string nombre = Console.ReadLine();

   Console.WriteLine("Porfa ingreseme cuanto gastó ");
   int gasto = int.Parse(Console.ReadLine());

   if (gasto > elMayorGasto)
   {
       // Aca tengo un nuevo gasto mayor, así que tengo que hacer 2 cosas
       // una es ahora tener este nuevo gasto como mayor
       // y lo otro es no perder el nombre del flaco, porque me piden que al final
       // diga quien es este pibe que mas gastó
       elMayorGasto = gasto;
       elNombreDelFlacoQueMasGasto = nombre;
   }
}
Console.WriteLine("El pibe que más gastó fue " + elNombreDelFlacoQueMasGasto);
Console.WriteLine(" Y el total que gastó fue " + elMayorGasto);

*/
