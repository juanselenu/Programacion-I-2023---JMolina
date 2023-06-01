using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Figurageometrica
    {
        
        public string Nombre { get; set; } 

            
        public abstract double CalcularArea();

        public string DecimeQuiensos()
        { 
         return "Hola Me Llamo" +  Nombre  + "Y mi area es" + CalcularArea();
                
        }

    }
}
