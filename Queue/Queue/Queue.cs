using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> filaNomes = new Queue<string>();

            filaNomes.Enqueue("Lucas");
            filaNomes.Enqueue("Natan");
            filaNomes.Enqueue("Felipe");
            filaNomes.Enqueue("Fabricio");

            Console.WriteLine(filaNomes.Peek());

            filaNomes.Dequeue(); // Lucas
            filaNomes.Dequeue(); // Natan

            Console.WriteLine(filaNomes.Peek());

            Console.ReadKey();
        }
    }
}
