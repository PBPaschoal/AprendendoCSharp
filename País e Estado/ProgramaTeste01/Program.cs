//Programa para teste de vetor, for, if e else

using System;

namespace ProgramaTeste01
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade;
            string M, N;

            Console.WriteLine("Quantas vezes deseja repetir? ");
            quantidade = int.Parse(Console.ReadLine());

            for (int i=0; i<quantidade; i++) {
                Console.WriteLine("\nEm qual país e estado você nasceu? ");
                Console.WriteLine("OBS: Responda apenas o pais e o estado");
                Console.WriteLine("EXEMPLO: Brasil RJ\n");
                string[] s1 = Console.ReadLine().Split(' ');
                M = (s1[0]);
                N = (s1[1]);

                if (M == "Brasil" && N == "RJ")
                {
                    Console.WriteLine("Olá carioca!");
                }
                else if (M == "Brasil" && N == "SP")
                {
                    Console.WriteLine("Olá paulista");
                }
                else if (M == "Brasil" && N == "AC")
                {
                    Console.WriteLine("Olá acriano(a)");
                }
                else if (M == "Brasil" && N == "AL")
                {
                    Console.WriteLine("Olá alagoano(a)");
                }
                else if (M =="Brasil" && N == "AP")
                {
                    Console.WriteLine("Olá amapaense");
                }
                else if (M == "Brasil" && N == "AM")
                {
                    Console.WriteLine("Olá amazonense");
                }
                else if (M == "Brasil" && N == "BA")
                {
                    Console.WriteLine("Olá bahiano(a)");
                }
                else if (M == "Brasil" && N == "CE")
                {
                    Console.WriteLine("Olá cearense");
                }
                else if (M == "Brasil" && N == "ES")
                {
                    Console.WriteLine("Olá capixaba");
                }
                else if (M == "Brasil" && N == "GO")
                {
                    Console.WriteLine("Olá goiano(a)");
                }
                else if (M == "Brasil" && N == "MA")
                {
                    Console.WriteLine("Olá maranhense");
                }
                else if (M == "Brasil" && N == "MT")
                {
                    Console.WriteLine("Olá mato-grossense");
                }
                else if (M == "Brasil" && N == "MS")
                {
                    Console.WriteLine("Olá mato-grossense-do-sul");
                }
                else if (M == "Brasil" && N == "MG")
                {
                    Console.WriteLine("Olá mineiro(a)");
                }
                else if (M == "Brasil" && N == "PA")
                {
                    Console.WriteLine("Olá paraense");
                }
                else if (M == "Brasil" && N == "PB")
                {
                    Console.WriteLine("Olá paraibano(a)");
                }
                else if (M == "Brasil" && N == "PR")
                {
                    Console.WriteLine("Olá paranaense");
                }
                else if (M == "Brasil" && N == "PE")
                {
                    Console.WriteLine("Olá Pernambucano(a)");
                }
                else if (M == "Brasil" && N == "PI")
                {
                    Console.WriteLine("Olá piauiense");
                }
                else if (M == "Brasil" && N == "RN")
                {
                    Console.WriteLine("Olá potiguar");
                }
                else if (M == "Brasil" && N == "RS")
                {
                    Console.WriteLine("Olá gaúcho(a)");
                }
                else if (M == "Brasil" && N == "RO")
                {
                    Console.WriteLine("Olá rondoniense");
                }
                else if (M == "Brasil" && N == "RR")
                {
                    Console.WriteLine("Olá roraimense");
                }
                else if (M == "Brasil" && N == "SC")
                {
                    Console.WriteLine("Olá catarinense");
                }
                else if (M == "Brasil" && N == "SE")
                {
                    Console.WriteLine("Olá nordestino(a)");
                }
                else if (M == "Brasil" && N == "TO")
                {
                    Console.WriteLine("Olá tocantinense");
                }
                else if (M == "Brasil" && N == "DF")
                {
                    Console.WriteLine("Olá brasiliense");
                }
                else
                {
                    Console.WriteLine("Você não é Brasileiro.");
                }
            }

            Console.WriteLine("\n\n|*|*|*|*|*| E N C E R R A D O ! |*|*|*|*|*|\n\n");
        }
    }
}


/*using System;

namespace ProgramaTeste01
{
    class Program
    {
        static void Main(string[] args)
        {
            char M, N;

            string[] s1 = Console.ReadLine().Split(' ');
            M = char.Parse(s1[0]);
            N = char.Parse(s1[1]);

            if (M == 's' || N == 'm')
            {
                Console.WriteLine("Certo");
            }
            else
            {
                Console.WriteLine("Errado");
            }
        }
    }
}*/