using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion_Profe_Eric_U2_Cesar.Clases
{
    public class Metodos
    {
        public void Ganancias()
        {
            double[,] ganancias =
            {
                { 500, 3000, 100, 400 },
                { 1000, 150, 200, 500 },
                { 250, 1800, 2900, 300, },
                { 400, 130, 90, 2400 },
                { 60, 20, 4000, 3600 }
            };

            double gananciaDeProducto1 = 0;
            double gananciaDeProducto2 = 0;
            double gananciaDeProducto3 = 0;
            double gananciaDeProducto4 = 0;
            double gananciaDeProducto5 = 0;


            double gananciaDeVendedor1 = 0;
            double gananciaDeVendedor2 = 0;
            double gananciaDeVendedor3 = 0;
            double gananciaDeVendedor4 = 0;


            for (int i = 0; i < ganancias.GetLength(0); i++)
            {
                for (int o = 0; o < ganancias.GetLength(1); o++)
                {
                    Console.WriteLine("" + ganancias[i,o]);
                }
                Console.WriteLine();
            }


            for (int p = 0; p < 4; p++)
            {
                gananciaDeVendedor1 += ganancias[0, p];
                gananciaDeVendedor2 += ganancias[1, p];
                gananciaDeVendedor3 += ganancias[2, p];
                gananciaDeVendedor4 += ganancias[3, p];
            }

            for (int a = 0; a < 5; a++)
            {
                gananciaDeProducto1 += ganancias[a, 0];
                gananciaDeProducto2 += ganancias[a, 1];
                gananciaDeProducto3 += ganancias[a, 2];
                gananciaDeProducto4 += ganancias[a, 3];
                gananciaDeProducto5 += ganancias[a, 4];
            }


            Console.WriteLine("LOS VENDEDORES");
            Console.WriteLine($"El vendedor1 obtuvo una ganancia de {gananciaDeVendedor1}");
            Console.WriteLine($"El vendedor1 obtuvo una ganancia de {gananciaDeVendedor2}");
            Console.WriteLine($"El vendedor1 obtuvo una ganancia de {gananciaDeVendedor3}");
            Console.WriteLine($"El vendedor1 obtuvo una ganancia de {gananciaDeVendedor4}");

            Console.WriteLine("LOS PRODUCTOS");
            Console.WriteLine($"El producto1 es {gananciaDeProducto1}");
            Console.WriteLine($"El producto2 es {gananciaDeProducto2}");
            Console.WriteLine($"El producto3 es {gananciaDeProducto3}");
            Console.WriteLine($"El producto4 es {gananciaDeProducto4}");
            Console.WriteLine($"El producto5 es {gananciaDeProducto5}");


            
        }


        public void Curp()
        {
            Console.WriteLine("Ingresa la curp");
            string curp = Console.ReadLine();
            char[] curp1 = curp.ToCharArray();

            if (curp1.Length != 18)
            {
                Console.WriteLine("Curp es incorrecta, vuelve a escribirla");
            }
            else if (curp1[10] == "H")
            {
                Console.WriteLine("Eres Hombre");
            }
            else
            {
                Console.WriteLine("Eres Mujer");
            }

            int año = int.Parse(curp.Substring(4,2));
            int mes = int.Parse(curp.Substring(6,2));
            int dia = int.Parse(curp.Substring(8,2));

            if (año > 0 && año < 49)
            {
                año += 2000;
            }
            else
            {
                año += 1900;
            }

            Console.WriteLine($"Nacimiento {dia}/{mes}/{año}");
        }
    }
}
