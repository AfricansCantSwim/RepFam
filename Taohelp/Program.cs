using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.IO;

namespace Taohelp
{
    class Program
    {
        static void Main(string[] args)
        {
            intetrnals.title();
            Console.Title = "Fashion Rep Helper | Version 1.0.0.0";
            intetrnals.start();
            Console.ReadLine();
        }
    }
    public static class intetrnals
    {
        public static void title()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                         FASHION REPS HELPER");
            Console.ResetColor();
        }
        public static void start()
        {
            Console.WriteLine("What would you like to do\n1).Convert to USD\n2).Convert to Yaun\n3).Trusted Sellers\n4).Exit");
            string i = Console.ReadLine();
            switch (i)
            {
                case "1":
                    Console.Write("> ¥");
                    string a = Console.ReadLine();
                    Console.WriteLine("$"+converter(a, 1));
                    start();
                    break;
                case "2":
                    Console.Write("> $");
                    string a1 = Console.ReadLine();
                    Console.WriteLine("¥" + converter(a1, 2));
                    start();
                    break;
                case "3":
                    Console.WriteLine("This feature is being added come back later for updates");
                    Thread.Sleep(2000);
                    start();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input...restarting!");
                    Thread.Sleep(2000);
                    start();
                    break;
            }
            Console.Write("> ");
            
           Console.WriteLine( converter(i, 1));
            start();
        }
        public static void converterstart()
        {

        }
        public static string converter(string inp, int choice)//1 = convert to usd, 2 = convert to yaun
        {
            int Out = 0;
            switch (choice)
            {
                case 1://divided by 7
                    try
                    {

                    Out = Convert.ToInt32(inp) / 7;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR: " + ex.Message);
                        Thread.Sleep(2000);
                        start();
                        
                    }
                    break;
                case 2://*0.14
                    try
                    {
                        Out = Convert.ToInt32(inp) * 14 / 100;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR: " + ex.Message);
                        Thread.Sleep(2000);
                        start();
                    }
                break;
                default:
                    break;
            }
            return Out.ToString();
        }
    }
    public static class shoes
    {

    }
}
