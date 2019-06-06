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
leticia 
namespace telainicial
{
    class Program
    {
        static void Main(string[] args)
        {
            double cont;
            string op1, op2;
            do
            {
                do
                {
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", " "));
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", " "));
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", " "));
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", " "));
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", " "));
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", " "));
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", " "));
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", " "));
                    string msg = "MENINAS PODEROSAS E MACACO LOUCO";
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + msg.Length / 2) + "}", msg);
                    Console.SetWindowSize(100, 50);
                    Console.BufferHeight = 500;
                    Console.BufferWidth = 100;
                    /* Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "► START (1) "));
                     Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "► EXIT  (2)"));
                     Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "TM AND © 2018 SUPER PODEROSAS E MACACO LOUCO"));
                     Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "LICENSED BY"));
                     Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "ETEC DRA RUTH CARDOSO"));
                     Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", " "));
                     Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "PITCH YOUR CHOICE: "));*/
                    string msg1 = "TM AND © 2018 SUPER PODEROSAS E MACACO LOUCO";
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + msg.Length / 2) + "}", msg1);
                    string msg2 = "LICENSED BY";
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + msg.Length / 2) + "}", msg2);
                    string msg3 = "ETEC DRA RUTH CARDOSO";
                    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + msg.Length / 2) + "}", msg3);
                    /* Console.WriteLine("► START (1)");
                     Console.WriteLine("► EXIT  (2)");
                     Console.WriteLine("TM AND © 2018 SUPER PODEROSAS E MACACO LOUCO");
                    Console.WriteLine("          LICENSED BY             ");
                    Console.Write("ETEC DRA RUTH CARDOSO");*/

                    op1 = Console.ReadLine();

                    
                }
                while (op1 != "1" && op1 != "2");


            }
            while (op1 == "4");
            Console.ReadKey();
        }
    }
}
