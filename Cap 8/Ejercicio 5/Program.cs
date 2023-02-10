using System;

namespace Program
{
    class Program
    {
        static void Main()
        {

            int Cantidad;
            string[] Array;

            Console.WriteLine("Digite la cantidad de cadenas a digitar por el usuario:");
            Cantidad = Convert.ToInt32(Console.ReadLine());


            Array = new string[Cantidad];

            for(int i = 0; i < Cantidad; i++)
            {
                Console.WriteLine($"Digite el valor de la cadena No.{i+1}:");
                Array[i] = Console.ReadLine();
            }


            Console.Clear();
            Console.WriteLine("\n");

            Console.WriteLine("Asi se digitaron:");
            ImprimirOriginal(Array);

            Console.WriteLine("Asi se organizaron las cadenas en orden alfabetico:");
            ImprimirOrdenado(Array);



        }

        static void ImprimirOriginal(string[] arr){

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                if(i == (arr.GetLength(0))-1){

                    Console.Write($"{arr[i]}");
                    
                }
                else{
                    Console.Write($"{arr[i]}, ");
                }
            }

            Console.WriteLine("");
            

        }

        static void ImprimirOrdenado(string[] arr)
        {
            
            Array.Sort(arr);

             for(int i = 0; i < arr.GetLength(0); i++)
            {
                if(i == (arr.GetLength(0))-1){

                    Console.Write($"{arr[i]}");
                    
                }
                else{
                    Console.Write($"{arr[i]},");
                }
            }
        }
    }
}