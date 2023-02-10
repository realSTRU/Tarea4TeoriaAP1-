using System;

namespace Program
{
    class Program
    {

        public struct Dueño{

            public string Nombre;

            public int edad;

            public override string ToString()
            {
                return $"Informacion D:\n********************\nNombre:{Nombre}\tEdad:{edad}";
            }

            public Dueño()
            {
                
            }
        }
        public struct Mascota{

            public string TipoMascota;
            public string Nombre;

            Dueño papa;

            public Mascota(string Tipo, string nombre, string pnombre, int pedad)
            {
                TipoMascota = Tipo;
                Nombre = nombre;
                papa.edad= pedad;
                papa.Nombre= pnombre;

            }

            public override string ToString()
            {
                return $"Informacion M:\n********************\nNombre:{Nombre}\tTipo de mascota:{TipoMascota}\n{papa}";
            }

        }

        static void Main()
        {
         

            Mascota mascota1 = new Mascota("Perro canibal de extraña procedencia.", "Platanito",  "Ezekiel",36);

          

            Console.WriteLine(mascota1);

            
        }


    }
}