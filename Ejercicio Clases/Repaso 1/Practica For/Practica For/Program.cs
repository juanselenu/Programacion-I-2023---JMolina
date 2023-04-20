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


//  

/*
 Este es un ejercicio donde hay un podio de 3 ganadores en una lista de 5 productos, es como un 5 BIS

int elUno = 0;
int elDos   = 0;
int elTres = 0;
string elNombreUno = "";
string elNombreDos = "";
string elNombreTres = "";

for (int i = 1; i <= 5 ; i++)
{
    Console.WriteLine("Porfa ingreseme el nombre del pibe ");
    string nombre = Console.ReadLine();

    Console.WriteLine("Porfa ingreseme cuanto gastó ");
    int gasto = int.Parse(Console.ReadLine());

   
    if (gasto > elUno)
    {
        // Aca es porque llegó un nuevo grandote, uno mayor a todos, tiene que ir primero
        // Ojo que allá en el fondo aclaran también que podría ser el primero, así que ojo.

        // acá yo subo al primer flaco al palco del mas grande, pero ANTES!! ojo que si había
        // uno.. no lo puedo matar, tengo que ponerlo en el segundo.
        // pero ANTES de matar al tercero, ahí tengo que sentar al segundo
        elTres = elDos;
        elNombreTres = elNombreDos;

        elDos = elUno;
        elNombreDos = elNombreUno;

        elUno = gasto;
        elNombreUno = nombre;


    }
    else
    {   // acá SI, ya sé que tengo un valor que NO fue primero... pero.. podría ser segundo
        // podría ser tercero o ninguno !!! ...  
        if (gasto > elDos)
        {
            // SI ESTOY acá es porque este nuevo flaco gastó MENOS que el primero
            // pero más que el segundo.
            // eentonces... tengo un nuevo segundo... y un nuevo tercero
            elTres = elDos;
            elNombreTres = elNombreDos;
            elDos = gasto;
            elNombreDos = nombre;

        }
        else
        {
            if (gasto > elTres)
            {
                elTres = gasto;
                elNombreTres = nombre;
            }
        }

    }
}

Console.WriteLine("El pibe que más gastó 1 fue " + elNombreUno);
Console.WriteLine("El pibe que más gastó 2 fue " + elNombreDos);
Console.WriteLine("El pibe que más gastó 3 fue " + elNombreTres); 
 */


