using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string documento = "/Users/edwinvalladares/Desktop/doc.txt";
        //documento en mi escritorio. 

        try
        {
            string contenido = File.ReadAllText(documento);
            Console.WriteLine("Contenido del archivo:");
            Console.WriteLine(contenido);
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error al leer el archivo: " + ex.Message);
        }
    }
}

