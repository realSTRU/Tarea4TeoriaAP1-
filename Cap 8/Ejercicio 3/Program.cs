using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {

            string hora = DateTime.Now.ToString("hh:mm:ss:tt");
            string fecha = DateTime.Now.ToLongDateString();


            Console.WriteLine("Hora y fecha actual de esta maquina:\n*****************************************");

            Console.Write($"{hora}\t{fecha}");

            Console.WriteLine("\n*****************************************");
            
        }
    }
}