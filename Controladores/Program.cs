using EjercicioBucle3.Servicios;

namespace EjercicioBucle3
{
    /// <summary>
    /// Clase de nuestro programa 
    /// </summary>
    class program
    {
        /// <summary>
        /// metodo main donde se encuentra todos los metodos de los servicios
        /// </summary>
        /// <param name="args"></param>
        

        public static void Main(String[] args)
        {
            indicarPalabraInterfaz ip = new indicarpalabraImplementacion();
            mostrarPatronInterfaz mp = new mostrarPatronImplementcion();
            
            int numero1 = ip.solicitarNum();
            mp.mostrarPatron(numero1);

        }
    }
}