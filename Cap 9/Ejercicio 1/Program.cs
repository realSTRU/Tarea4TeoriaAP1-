using System;

namespace Program
{
    class Program
    {
        public struct Producto
            {
                public int IDproducto;
                public string Descripcion;

                public double costo;
                public double precio;

                public int existencia;
                

                public override String ToString()
                {
                    return $"Descripcion:{Descripcion}\n************************\nProductoID:{IDproducto}\nCosto:{costo}\nPrecio:{precio}\nExistencia:{existencia}";

                }
            }
        static void Main()
        {


            Producto producto_1;
            Producto producto_2;
            Producto producto_3;

            producto_1.IDproducto = 1;
            producto_1.Descripcion = "BERTINAs";
            producto_1.costo = 375.9;
            producto_1.precio= 467.7;
            producto_1.existencia = 436;

            producto_2.IDproducto = 2;
            producto_2.Descripcion = "Creatina";
            producto_2.costo = 2000.75;
            producto_2.precio= 3500;
            producto_2.existencia = 56;

            producto_3.IDproducto = 56;
            producto_3.Descripcion = "MSI ASUS PrO";
            producto_3.costo = 78000;
            producto_3.precio= 237563.9;
            producto_3.existencia = 2;

            Console.WriteLine($"{producto_1}\n\n{producto_2}\n\n{producto_3}\n\n");

            
        }
    }
}