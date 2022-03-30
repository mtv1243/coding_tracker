using System;
using System.Configuration;
using System.Collections.Specialized;

namespace coding_tracker
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the CodingTracker(TM)! Please choose an option fro mthe menu below");
            Console.WriteLine();

            while (true)
            {
                PrintMenu();
                string input = Console.ReadLine();

                

            }

            void PrintMenu()
            {
                Console.WriteLine("==================================");
                Console.WriteLine("1 - print database");
                Console.WriteLine("2 - log new session");
                Console.WriteLine("3 - update session");
                Console.WriteLine("4 - delete session");
                Console.WriteLine("0 - close and exit program");
                Console.WriteLine("==================================");


            }

            //CodingSession newSession = new();

            //Console.WriteLine(".");
            //Console.WriteLine(".");
            //Console.WriteLine("start:");
            //Console.WriteLine(newSession.Start.ToString());
            //Console.WriteLine("End");
            //Console.WriteLine(newSession.End.ToString());
            //Console.WriteLine("Duration");
            //Console.WriteLine(newSession.Duration.Days + "days, " + newSession.Duration.Hours + "hours, " + newSession.Duration.Minutes + "minutes");




        }
    }
}
