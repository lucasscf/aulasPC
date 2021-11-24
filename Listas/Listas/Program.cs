using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando vetor
            int[] vetor = new int[5];

            // Adicionando itens no vetor
            vetor[0] = 5;
            vetor[1] = 3;
            vetor[2] = 1;
            vetor[3] = 2;
            vetor[4] = 7;

            Console.WriteLine(vetor.Length);

            // Decalrando Lista
            List<int> listNumeros = new List<int>();

            // Adicionando itens na lista
            listNumeros.Add(5);
            listNumeros.Add(3);
            listNumeros.Add(1);
            listNumeros.Add(2);
            listNumeros.Add(7);
            listNumeros.Add(7);
            listNumeros.RemoveAt(5);

            // Adicionando valor do teclado na lista
            //listNumeros.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine(listNumeros[2]);

            // Percorrendo por todos os itens da lista
            foreach (int numero in listNumeros)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine();

            // Ordenar a lista ASC
            listNumeros.Sort();

            // Ordenar a lista DESC
            listNumeros.Sort((a, b) => b.CompareTo(a)); // descending sort

            // Percorrendo por todos os itens da lista
            foreach (int numero in listNumeros)
            {
                Console.Write(numero + " ");
            }

            //Console.WriteLine(listNumeros.Count);

            Console.ReadKey();
        }
    }
}
