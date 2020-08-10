//Apenas uma brincadeira que eu fiz para praticar, inspirado em filmes de Hacker
using System;

namespace Programming_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, contador = 0;
            double sen;

            sen = 1234;
            Console.WriteLine("Acesso restrito ");
            Console.WriteLine("There is no valid permission to access the data.");
            A = int.Parse(Console.ReadLine());
            do {
                if (A == sen) {
                    Console.WriteLine("Loading...");
                    Console.WriteLine("Loading... 3%");
                    Console.WriteLine("Loading... 9%");
                    Console.WriteLine("Loading... 28%");
                    Console.WriteLine("Loading... 44%");
                    Console.WriteLine("Loading... 71%");
                    Console.WriteLine("Loading... 88%");
                    Console.WriteLine("Loading... 89%");
                    Console.WriteLine("Loading... 96%");
                    Console.WriteLine("Loading... 99%");
                    Console.WriteLine("Loading... 100%");
                    Console.WriteLine("\nEntry allowed successfully. Database access available\n");
                    break;
                }
                else {
                    Console.WriteLine("\nAccess denied\n");
                    A = int.Parse(Console.ReadLine());
                }
                contador++;
            } while (contador < 2);
            if (contador == 2) {
                Console.WriteLine("\nToo many attempts. Connection closed\n");
            }
        }
    }
}
