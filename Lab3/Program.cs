using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Continue = true;
            while (Continue == true)
            {
                int UserInput; 
                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine("Enter an integer:");
                UserInput = int.Parse(Console.ReadLine());
                Console.WriteLine("Number" + "\t" + "Squared" + "\t" + "Cubed"); //challenge: use pad instead of tab?

                for (int i = 1; i <= UserInput; i++) 

                {
                    Console.WriteLine(i + "\t" + Math.Pow(i, 2) + "\t" + Math.Pow(i, 3)); //number, tab, squared, tab, cubed.
                }  

                string UserChoice; //loop back
                Console.WriteLine("Continue? (y/n?)");
                UserChoice = Console.ReadLine();
                if (UserChoice == "N" || UserChoice == "No"|| UserChoice == "no" || UserChoice == "n")
                {
                    Continue = false;
                    Console.WriteLine("See ya later, alligator!");
                }
            }
        }
    }
}
