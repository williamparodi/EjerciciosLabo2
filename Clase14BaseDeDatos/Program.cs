using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace Clase14BaseDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            SqlConnection conexion;
            SqlCommand command;
            SqlDataReader reader;

            string conexionString = "Server=.;Database=EMPRESA_DB;Trusted_Connection=True;";

            conexion = new SqlConnection(conexionString);//coneccion entre visual y base de datos

            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;

            command.Connection = conexion;// a traves de quien 

            command.CommandText = "SELECT * FROM EMPLEADOS";

            //Abrimos la conexion
            conexion.Open();

            //Realizamos la consulta y la guardarmos en un objeto  DataReader
            reader = command.ExecuteReader();// de esta manera ejecuta el comando y me devuelve lo que leyo

            //reader.Read();// lee un solo elemento
            List<Empleado> listaEmpleados = new List<Empleado>();

            try
            {
                while (reader.Read())
                {
                    string nombre = reader["nombre"].ToString();//la mejor forma
                    double sueldo = (double)reader[4];
                    int id_puesto = reader.GetInt32(3);

                    Empleado e = new Empleado(nombre, id_puesto, sueldo);
                    listaEmpleados.Add(e);

                    Console.WriteLine(nombre + " - ");
                    Console.WriteLine(sueldo + " - ");
                    Console.WriteLine(id_puesto);
                }
                reader.Close(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
               
            }



            //Sacamos los datos
            /*
            string nombre = reader["nombre"].ToString();
            double sueldo = (double)reader["sueldo"];// traeme este campo 
            */

            //Console.WriteLine(nombre);

            //Cierro conexion
            //conexion.Close();

            // HAGO UN INSERT
            /*
            SqlConnection conexion1;
            SqlCommand command1;
            string consulta = "INSERT INTO EMPLEADOS " +
                "VALUES ('lalo','panchi',1,65656.65,'true','1996-03-21',NULL,'asdad@gmail.com')";
            conexion1 = new SqlConnection(conexionString);
            command1 = new SqlCommand(consulta, conexion1);

            // va en un try cat como el anterior
            conexion1.Open();
            if(command1.ExecuteNonQuery() == 0)
            {
                Console.WriteLine("NO se agrego eempleado");
            }
            else
            {
                Console.WriteLine(" se Agrego");
            }
            conexion1.Close();

            */

            ////////
            ///MODifico
            Empleado emp = new Empleado(1, "pedro","perez",3,545454,true,"2012-12-03");// hay que agrgar datos en la clase
            SqlConnection conexion;
            SqlCommand command;
            /* Esto no se usa
            string consulta = "UPDATE EMPLEADOS" +
                "SET nombre = " + emp.nombre +
                "WHERE id_empleado = 14";*/

            string consulta = "UPDATE EMPLEADOS SET nombre=@nombre WHERE Id_empleado=@id";

            string conexionString = "Server=.;Database=EMPRESA_DB;Trusted_Connection=True;";
            conexion = new SqlConnection(conexionString);
            command = new SqlCommand(consulta, conexion);

            command.Parameters.AddWithValue("@nombre", emp.nombre);// usar esto es mas seguro 
            command.Parameters.AddWithValue("@id", emp.id_puesto);//nombre 
            conexion.Open();
            
            if(command.ExecuteNonQuery() == 0)
            {
                Console.WriteLine("Se modifico");
            }
            else
            {
                Console.WriteLine("No se pudo");
            }
            
            // DELETE 

            SqlConnection conexion2;
            SqlCommand command2;

            string consulta2 = "DELETE FROM Empleados WHERE id_empleado=@id";
            conexion2 = new SqlConnection(conexionString);
            int id = 2;

            using (conexion2 = new SqlConnection(conexionString))
            {
                conexion2.Open();
                command2 = new SqlCommand(consulta2, conexion);
                command2.Parameters.AddWithValue("@id", id);
                if (command.ExecuteNonQuery() == 0)
                {
                    Console.WriteLine("Se modifico");
                }
                else
                {
                    Console.WriteLine("No se pudo");
                }

            }
                

        }
    }
}
