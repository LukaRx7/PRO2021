using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Napiši poljubno besedo: ");
                string beseda = Console.ReadLine();

                Console.WriteLine(Polindrom(beseda));
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static string Polindrom(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[0] == input[input.Length - 1])
                {
                    return "Vaša beseda je polindrom";
                }
                
            } return "Ništa posebno";

        }
       
    }
}