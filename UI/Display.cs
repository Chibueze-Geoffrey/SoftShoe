using SoftShoes.Core.Implementations;
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftShoes.Core.Interfaces;

namespace SoftShoes.UI
{
    public class Display : IDisplay
    {

        public  string GetGreeting()
        {
           
            var now = DateTime.Now;

            if (now.Hour > 16) return "evening";
            else if (now.Hour >= 12) return "afternoon";
            else return "morning";

            

        }
        public void Menu()
        {
            //Console.WriteLine($"| {"---",-3} | {"---------------------------",-27} | {"-------------",-14}
            //| {"------------",-12} | {"-------------------",-19} |");
            Console.WriteLine($"GOOD {GetGreeting().ToUpper()}---DEAR CUSTOMER WELCOME TO SOFT-SHOES");
            Console.WriteLine("\n");
            Console.WriteLine("BELOW IS THE LIST OF SHOE SIZE");
            OrderList();
            Console.WriteLine("\n");
            int TotalShoeSize = 0;
            Start :
            Console.WriteLine("-----------------------------------------------------------------",-50);
            Console.WriteLine("Please Select Your shoe Size : 1 - small, 2- medium, 3 - large");
            Console.WriteLine("------------------------------------------------------------------",-70);
            int UserChoice = int.Parse(Console.ReadLine());
            switch (UserChoice)

            {

                case 1:
                    TotalShoeSize += 10000;
                    break;
                case 2:
                    TotalShoeSize += 20000;
                    break;
                case 3:
                    TotalShoeSize += 30000;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("-----------------------------------------------------------------",- 24);
                    Console.WriteLine("Your choice is invalid", UserChoice);
                    goto Start;
            }
        Decide:
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Do you want another shoe - Yes or No");
            String UserDecision = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------");

            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine("Your choice {0} isINVALID..Try again", UserDecision);
                    Console.WriteLine("-----------------------------------------------------------------");
                    goto Decide;
            }
            {
                Console.WriteLine("THANKS FOR PATRONIZING");
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("Total bill amount Is- ${0}", TotalShoeSize);
               
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("\n");
                Console.WriteLine($"HAVE A NICE {GetGreeting().ToUpper()} AHEAD");
            }

        }

        public void OrderList()
        {
            Console.WriteLine("1= SMALL = $10000");
            Console.WriteLine("2 = MEDIUM = $20000");
            Console.WriteLine("3= LARGE = $30000");
            
        }
    }
}
