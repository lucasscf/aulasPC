using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncProc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool executa = true;
            string valor = "";
            double resultado = 0;

            while (executa) {
                Console.Clear();

                calculaMediaProc();
                resultado = calculaMediaFunc(); // 5

                Console.WriteLine("Deseja sair? S/N");
                valor = Console.ReadLine();
                if (valor == "S") {
                    executa = false;
                }
            }
        }

        // PROCEDIMENTO!!!
        static void calculaMediaProc() {
            // declarando variavel
            double num1;
            double num2;
            double media;
            // Solicito
            // Imprimo
            Console.WriteLine("Informe o numero 1");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o numero 2");
            num2 = Convert.ToDouble(Console.ReadLine());

            media = (num1 + num2) / 2;

            Console.WriteLine("A media eh: " + media);
            Console.ReadLine();
        }

        static double calculaMediaFunc() {
            // declarando variavel
            double num1;
            double num2;
            double media;

            Console.WriteLine("Informe o numero 1");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o numero 2");
            num2 = Convert.ToDouble(Console.ReadLine());

            media = (num1 + num2) / 2;

            return media;
        }

        static void teste() { 
        
        }
    }
}
