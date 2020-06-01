using System;
using CapaLogicaNegociosPizzza;
using System.Data.Sql;
using System.Data.SqlClient;



namespace CapaPresentacion
{
    class PizzzaConsola
    {
        static void Main(string[] args)
        {
            ControladorPizzza pizza = new ControladorPizzza();

            pizza.CargarOpciones();
   

            /*string contraseña;

            Console.WriteLine("Ingrese la contraseña?");
            Console.WriteLine(" ");
            contraseña = Console.ReadLine();

            pizza.logeo(contraseña);
            */

        }
    }
}
