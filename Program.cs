﻿using System;

namespace EntradaEsaida
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, media;

            Console.WriteLine("Digite o primeiro numero: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            y = double.Parse(Console.ReadLine());
            media = (x + y) / 2.0;
            Console.WriteLine("Media = " + media);
        }
    }
}
