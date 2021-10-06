using System;
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
            Console.WriteLine("10 Fib stevilo " + Fib(10));
            Console.WriteLine("5 mesto v zaporedju je " +Vaja3(5));
            Console.WriteLine("4 mesto v zaporedju je " + Vaja4(4));
            Console.WriteLine("4 mesto v zaporedju je " + Vaja5(4));
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
        //VAJA 3
        static int Vaja3(int n)
        {
            if (n == 1 || n == 2)
                return 2;
            else
                return Vaja3(n - 2) * Vaja3(n - 1) -1;
        }
        //VAJA 4
        static int Vaja4(int n)
        {
            if (n == 1)
                return 2;
            else
                return 3 * Vaja4(n - 1) + 2;
        }
       //VAJA 5
        static int Vaja5(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            else
                return Vaja5(n - 1) * 2 + Vaja5(n - 2);
        }
    }
}
