using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_superpoderosas_macacolouco
{
    class Program
    {
        static void Main(string[] args)
        {
            //► (alt + 1 + 6) ♦ (alt + 4) ƒ (alt + 1 + 5 + 9) • (alt + 0 + 1 + 4 + 9)
            double cont;
            string op1, op2;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("► START (1)");
                    Console.WriteLine("► EXIT  (2)");
                    Console.WriteLine("TM AND © 2018 SUPER PODEROSAS E MACACO LOUCO");
                    Console.WriteLine("LICENSED BY");
                    Console.Write("ETEC DRA RUTH CARDOSO");
                    op1 = Console.ReadLine();
                }
                while (op1 != "1" && op1 != "2");


            }
            while (op1 == "4");
        }
    }
}
