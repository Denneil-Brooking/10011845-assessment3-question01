using System;
using System.Collections.Generic;

namespace _10011845_assessment3_question01
{
    class Program

    {
        static List<string> falcons = new List<string> { "Hisan", "Ka Kite", "Siren", "Koa", "Stella", "Mojo" };
        static List<string> falconers = new List<string> { "Debbie", "Heidi", "Noel", "Melissa", "Kirsten", "Koshy" };

        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Flying for the WINGSPAN display today is:");
            Console.WriteLine("------------------------------------------");

            //Printing results
            Console.WriteLine(DisplayFalconers());


            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("**************Display starts at 2pm***************");
            Console.WriteLine("Please Press <Enter> to close program");
            Console.ReadKey();
        }

        static int GenFalconAndHuman(List<string> myList)
        {
            var rand = new Random();
            return rand.Next(1, myList.Count);
        }



        static string DisplayFalconers()
        {


            var selectedFalcon = falcons[GenFalconAndHuman(falcons)];
            var selectedFalconer = falconers[GenFalconAndHuman(falconers)];

            //ruturns info to display under console.writeline
            return $"Falconer = {selectedFalconer}\nWith Falcon = {selectedFalcon}";
        }
    }
}
