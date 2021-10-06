﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekurzijaVaja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 na 10 je " + PotencaIterativno(10));
            Console.WriteLine("2 na 10 je " + PotencaRekurzivno(10));
            Console.WriteLine("7 Fib stevilo " + Fib(250));
            Console.ReadLine();
        }
        static int Fib(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }
        //rekurzivno izraćuna n to fib število
            
        static int PotencaIterativno(int n)
        {
            int potenca = 1;
            for (int k=1;k<=n;k++)
            {
                potenca = potenca * 2;
            }
            return potenca;
        }
        static int PotencaRekurzivno(int n)
        {
            if (n == 0)
                return 1;
            return 2 * PotencaRekurzivno(n - 1);
        }
        static int Vaja3(int n)
        {

        }
    }
}
