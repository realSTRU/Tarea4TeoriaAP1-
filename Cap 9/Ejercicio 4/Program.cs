using System;

namespace Program
{


    class Program
    {

        enum Neumaticos
        {
            radial, verano, invierno, tubeless, direccional, asimetrico
        }
        static void Main()
        {

            Neumaticos carro1 = Neumaticos.verano;

            Console.WriteLine($"{carro1}");
          
        }
    }
}