using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBucle3.Servicios
{
    internal class mostrarPatronImplementcion : mostrarPatronInterfaz
    {
        public void mostrarPatron(int num1)
        {
            for (int i = 1; i <= num1; i++)
            {
             for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);

                }
              Console.WriteLine();
                
            }
        }
    }
}
