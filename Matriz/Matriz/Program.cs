using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[10, 10];

            int count = 1; 
            for (int l = 0; l <= 9; l++)
            {
                for (int c = 0; c <= 9; c++)
                {
                    matriz[l, c] = count.ToString(); // 1, 2, 3, 4, 5, 6
                    count++;
                    Console.Write(matriz[l, c] + "\t");
                }
                Console.Write("\n");
                Console.Write("\n");
            }


            Console.ReadKey();
        }
    }
}
