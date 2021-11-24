using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaTelefonica = new int[5];

            listaTelefonica[0] = 1;
            listaTelefonica[1] = 5;
            listaTelefonica[2] = listaTelefonica[0];
            listaTelefonica[3] = listaTelefonica[1];
            listaTelefonica[4] = 10;

            for (int i = 0; i <= listaTelefonica.Length; i++) {
                Console.WriteLine(listaTelefonica[i]);
            }

            Console.ReadKey();
        }
    }
}
