using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBucle3.Servicios
{
    internal class indicarpalabraImplementacion : indicarPalabraInterfaz
    {
    
         
        
        public int solicitarNum()
        {
            Console.WriteLine("Indique un numero entero y positivo");
           int  numn1 = int.Parse(Console.ReadLine());
            if (numn1 <= 0)
            {
                Console.WriteLine("El numero elegido no es entero y/o mayor que 0\n");
                return 0;
            }
            else
            {
                Console.WriteLine("El numero elegido es entero y mayor que 0\n");
               


            }
            Console.WriteLine("El numero escogido es:" + numn1);
            return numn1;
        }
    }
}
