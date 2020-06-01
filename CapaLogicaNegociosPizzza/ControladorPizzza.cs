using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatosPizzza;
using System.Data.Sql;
using System.Data.SqlClient;
using Comun;

namespace CapaLogicaNegociosPizzza
{

    public class ControladorPizzza
    {

        int opcion;
        string respuesta;
        double precioPizza;
        string nombrePizza;
        double precioAdicion;
        string nombreAdicion;
        string nombrePizzeria;
        string tamaño;
        int idPizzaEliminar;

        int idAdicionEliminar;

        /*BaseDeDatosSql Datos = new BaseDeDatosSql();

        public SqlDataReader iniciarSesionP(string nombreP , string contraseña)
        {
            SqlDataReader loguearP;
            loguearP = Datos.LoginPizzeria(nombreP , contraseña);
            return loguearP;
        }

        public void InsertarPizza(string nombreP, string pizza, string tamaño, double precioP)
        {

            Datos.InsertarMenu(nombreP, pizza, tamaño, precioP);

        }

        public void InsertarAdiciones(string nombreP, string producto, double precioP)
        {

            Datos.InsertarAdicion(nombreP, producto, precioP);

        }

        public void EliminarPizza(int id)
        {
            Datos.BorrarMenu(id);
        }

        public void EliminarAdicion(int id)
        {
            Datos.BorrarAdicion(id);
        }
        */

        public void CargarOpciones()
        {


                do
                {

                    Console.WriteLine("Bienbenido a la aplicacion de administracion Pizzza");
                    Console.WriteLine(" ");
                    Console.WriteLine("¿Que desea hacer?");
                    Console.WriteLine(" ");

                    do
                    {

                        Console.WriteLine("1. Agregar pizza al menú");
                        Console.WriteLine("2. Eliminar Pizza del menú");
                        Console.WriteLine("3. Agregar adicion al menú");
                        Console.WriteLine("4. Eliminar adicion del menú ");

                        opcion = Convert.ToInt16(Console.ReadLine());

                    } while ((opcion != 1) && (opcion != 2) && (opcion != 3) && (opcion != 4));


                    if (opcion == 1)
                    {

                        nombrePizzeria = "Max Pizza";

                        Console.WriteLine("Ingrese los datos de la pizza que desea agregar pizza al menú");
                        Console.WriteLine(" ");

                        Console.WriteLine("Ingrese el nombre de la pizza");
                        Console.WriteLine(" ");
                        nombrePizza = Console.ReadLine();

                        Console.WriteLine("Ingrese el tamaño de la pizza");
                        Console.WriteLine(" ");
                        tamaño = Console.ReadLine();

                        Console.WriteLine("Ingrese el precio de la pizza");
                        Console.WriteLine(" ");
                        precioPizza = Convert.ToDouble(Console.ReadLine());


                        //InsertarPizza(nombrePizzeria , nombrePizza , tamaño , precioPizza);

                        Console.WriteLine("Pizza agregada");
                        Console.WriteLine(" ");

                    }
                    else if (opcion == 2)
                    {
                        Console.WriteLine("Ingrese los datos de la pizza que desea eliminar Pizza del menú");
                        Console.WriteLine(" ");

                        Console.WriteLine("Ingrese el id de la pizza que desea eliminar");
                        Console.WriteLine(" ");
                        idPizzaEliminar = Convert.ToInt32(Console.ReadLine());

                        //EliminarPizza(idPizzaEliminar);

                        Console.WriteLine("Pizza eliminada");
                        Console.WriteLine(" ");

                }
                    else if (opcion == 3)
                    {

                        nombrePizzeria = "Max Pizza";
                        Console.WriteLine("Ingrese los datos de la adicion que desea agregar adicion al menú");
                        Console.WriteLine(" ");

                        Console.WriteLine("Ingrese el nombre de la adicion");
                        Console.WriteLine(" ");
                        nombreAdicion = Console.ReadLine();

                        Console.WriteLine("Ingrese el precio de la adicion");
                        Console.WriteLine(" ");
                        precioAdicion = Convert.ToDouble(Console.ReadLine());

                       // InsertarAdiciones(nombrePizzeria, nombreAdicion, precioAdicion);

                        Console.WriteLine("Adicion agregada");
                        Console.WriteLine(" ");

                    }
                    else if (opcion == 4)
                    {
                        Console.WriteLine("Ingrese los datos de la adicion que desea eliminar adicion del menú");
                        Console.WriteLine(" ");

                        Console.WriteLine("Ingrese el id de la adicion que desea eliminar");
                        Console.WriteLine(" ");
                        idAdicionEliminar = Convert.ToInt32(Console.ReadLine());

                        //EliminarAdicion(idAdicionEliminar);

                        Console.WriteLine("Adicion eliminada");
                        Console.WriteLine(" ");
                }


                    Console.WriteLine("¿desea hacer otra accion?");
                    Console.WriteLine(" ");
                    Console.WriteLine("Y: si u otra tecla para salir");
                    respuesta = Console.ReadLine();


                } while ((respuesta == "y") || (respuesta == "Y"));

                Console.ReadKey();

            return;

        }

        /*public void logeo(string contraceña)
        {

            int opcion;
            string respuesta;
            double precioPizza;
            string NombrePizza;
            double precioAdicion;
            string NombreAdicion;
            string tamaño;
            string nombrePizzeria = "Max Pizza";
            string nombrePizza;


            if (contraceña == "c")
            {


                do
                {

                    Console.WriteLine("Bienbenido a la aplicacion de administracion Pizzza");
                    Console.WriteLine(" ");
                    Console.WriteLine("¿Que desea hacer?");
                    Console.WriteLine(" ");

                    do
                    {

                        Console.WriteLine("1. Agregar pizza al menú");
                        Console.WriteLine("2. Eliminar Pizza del menú");
                        Console.WriteLine("3. Agregar adicion al menú");
                        Console.WriteLine("4. Eliminar adicion del menú ");

                        opcion = Convert.ToInt16(Console.ReadLine());

                    } while ((opcion != 1) && (opcion != 2) && (opcion != 3) && (opcion != 4));


                    if (opcion == 1)
                    {
                        Console.WriteLine("Ingrese los datos de la pizza que desea agregar pizza al menú");
                        Console.WriteLine(" ");

                        Console.WriteLine("Ingrese el nombre de la pizza");
                        Console.WriteLine(" ");
                        nombrePizza = Console.ReadLine();

                        Console.WriteLine("Ingrese el tamaño de la pizza");
                        Console.WriteLine(" ");
                        tamaño = Console.ReadLine();

                        Console.WriteLine("Ingrese el precio de la pizza");
                        Console.WriteLine(" ");
                        precioPizza = Convert.ToDouble(Console.ReadLine());


                        InsertarPizza(nombrePizzeria, nombrePizza, tamaño, precioPizza);

                        Console.WriteLine("Pizza agregada");
                        Console.WriteLine(" ");

                    }
                    else if (opcion == 2)
                    {
                        Console.WriteLine("Ingrese los datos de la pizza que desea eliminar Pizza del menú");
                        Console.WriteLine(" ");

                    }
                    else if (opcion == 3)
                    {
                        Console.WriteLine("Ingrese los datos de la adicion que desea agregar adicion al menú");
                        Console.WriteLine(" ");

                        Console.WriteLine("Ingrese el nombre de la adicion");
                        Console.WriteLine(" ");
                        NombreAdicion = Console.ReadLine();
                        Console.WriteLine("Ingrese el precio de la adicion");
                        Console.WriteLine(" ");
                        precioAdicion = Convert.ToDouble(Console.ReadLine());

                        InsertarAdicion(NombreAdicion, precioAdicion);

                        Console.WriteLine("Adicion agregada");
                        Console.WriteLine(" ");

                    }
                    else if (opcion == 4)
                    {
                        Console.WriteLine("Ingrese los datos de la adicion que desea eliminar adicion del menú");
                        Console.WriteLine(" ");
                    }


                    Console.WriteLine("¿desea hacer otra accion?");
                    Console.WriteLine(" ");
                    Console.WriteLine("Y: si u otra tecla para salir");
                    respuesta = Console.ReadLine();


                } while ((respuesta == "y") || (respuesta == "Y"));

                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Contraseña incorrecta");

            }

            return;
        }*/


    }
}
