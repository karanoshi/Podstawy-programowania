﻿using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, suma = 0;
            Console.Write("Podaj a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b=");
            b = Convert.ToInt32(Console.ReadLine());
            i = a;
            while (i <= b)
            {
                suma += i;
                i++;
            } //while i
            Console.WriteLine("\"{0}+...+{1}={2}\"", a, b, suma);
            Console.ReadKey(true); //pauza
        }
    }
}