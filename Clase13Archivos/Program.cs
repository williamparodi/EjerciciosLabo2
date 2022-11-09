using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace Clase13Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Intro
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Una clase es el tipo de dato más poderoso en C#.");
            stringBuilder.AppendLine("Como una estructura, una clase define datos y comportamiento para el tipo de dato.");

            File.WriteAllText("MiArchivo.txt", stringBuilder.ToString());

            bool existe = File.Exists("MiArchivo.txt");
            Console.WriteLine($"¿Existe el archivo?: {existe}");

            Console.WriteLine($"{Environment.NewLine}Contenido:");
            string textoDelArchivo = File.ReadAllText("MiArchivo.txt");
            Console.WriteLine(textoDelArchivo);
            */
            /*
            string nombreArchivo = "AprendiendoArchivos.txt";
            Console.WriteLine("¿Existe?: {0} {1}", File.Exists(nombreArchivo), Environment.NewLine);

            Console.WriteLine($"Creando archivo...");
            StreamWriter streamWriter = File.CreateText(nombreArchivo);
            streamWriter.WriteLine("Aprendo archivos en la UTN");
            streamWriter.Close();
            //Si quiero liberar memo streamWriteLine.Dispose();
            Console.WriteLine("¿Existe?: {0} {1}", File.Exists(nombreArchivo), Environment.NewLine);

            Console.WriteLine("Leyendo archivo...");
            StreamReader streamReader = File.OpenText(nombreArchivo);
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();

            Console.WriteLine("Borrando archivo...");
            File.Delete(nombreArchivo);

            Console.WriteLine("¿Existe?: {0} {1}", File.Exists(nombreArchivo), Environment.NewLine);
            */
            

            // De esta manera cierra y libera memoria sola ,close and dispose
            using (StreamWriter sw = new StreamWriter("MiArchivo.txt",true))//Si existe ecribe al final ,si no, lo crea.
            {
                sw.WriteLine("Hola como estaas?");
                sw.WriteLine("Chau");
               
            }
            string path = "MiArchivo.txt";
            try
            {
                //Path.GetFullPath(path) Trae el nombre completo de la ruta 
                
                Console.WriteLine(Environment.CurrentDirectory);
                Console.WriteLine(Environment.SpecialFolder.Desktop);
                Console.WriteLine(Environment.SpecialFolder.MyDocuments);

                if(File.Exists(path))
                {
                    using (StreamReader streamReader = new StreamReader(path))
                    {
                        //File.OpenText("MiArchivo.txt");// leo el arvhivo
                        Console.WriteLine(streamReader.Read()); //le por caracter
                        Console.WriteLine(streamReader.ReadLine());// lee linea
                        Console.WriteLine(streamReader.ReadToEnd()); // lee todo
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Serializacion de un objeto
            Usuario user = new Usuario("Pedro",22,"Pedro descripcion" );
            XmlSerializer serializer = new XmlSerializer(typeof(Usuario));
            StreamWriter writer = new StreamWriter("alumno.xml");

            serializer.Serialize(writer, user);
            writer.Close();

            // Varios
            Usuario user2 = new Usuario("Caelos", 42, "Caelos descripcion");
            Usuario user3 = new Usuario("Roberto",65, "Roberto desc");
            List<Usuario> listaUsuarios = new List<Usuario>();
            listaUsuarios.Add(user);
            listaUsuarios.Add(user2);

            using (StreamWriter writerLista = new StreamWriter("ListaAlumnos.xml",true))
            {
                XmlSerializer serializerLista = new XmlSerializer(typeof(List<Usuario>));
                serializerLista.Serialize(writerLista, listaUsuarios);
            }
             //Deserializo
            using (StreamReader streamReader1 = new StreamReader("alumno.xml"))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Usuario));

                Usuario userRescatado =  (Usuario)deserializer.Deserialize(streamReader1);// hay que castear al tipo de objeto
                Console.WriteLine(userRescatado.nombre);
                Console.WriteLine(userRescatado.edad);
                Console.WriteLine(userRescatado.descripcion);

            }

            //Deserializo una lista
            using (StreamReader streamReader2 = new StreamReader("ListaAlumnos.xml"))
            {
                XmlSerializer deserializer2 = new XmlSerializer(typeof(Usuario));

                List<Usuario> usersRescatados = (List<Usuario>)deserializer2.Deserialize(streamReader2);// hay que castear al tipo de objeto
                usersRescatados.Add(user);
                usersRescatados.Add(user2);
                usersRescatados.Add(user3);

                foreach(var item in usersRescatados)
                {
                    Console.WriteLine(item.nombre);
                    Console.WriteLine(item.edad);
                    Console.WriteLine(item.descripcion);
                }

            }

            // JSON Serializer Pasar objeto a string
            Usuario usuario = new Usuario("William", 22, "William joven");
            string userString;
            userString = JsonSerializer.Serialize(usuario);
            Console.WriteLine(userString);

            //Teniendo string pasar a objeto
             Usuario usuarioNuevo = JsonSerializer.Deserialize<Usuario>(userString);

            Console.WriteLine(usuarioNuevo.nombre);
            Console.WriteLine(usuarioNuevo.edad);
            Console.WriteLine(usuarioNuevo.descripcion);

        }


        
    }
}
