using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilhaNomes = new Stack<string>();
            Stack<string> pilhaNomesAux = new Stack<string>();
            pilhaNomes.Push("Lucas");
            pilhaNomes.Push("Natan");
            pilhaNomes.Push("Felipe");
            pilhaNomes.Push("Fabricio");

            pilhaNomesAux.Push(pilhaNomes.Pop()); // Fabricio
            pilhaNomesAux.Push(pilhaNomes.Pop()); // Felipe

            Console.WriteLine(pilhaNomes.Peek());

            Console.ReadKey();
        }
    }
}
