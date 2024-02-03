using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {

            /*            Console.WriteLine(message);
            */
            string petName;
            string petType="";
            
            Console.WriteLine("Please choose a type of pet:\n1. Cat\n2.Dog\n3.Rabbit");
            Console.WriteLine("User Input: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            /*            Accepting user input from console and assigning pet name according to user input.
            */
            do {
                if (choice == 1)
                {
                    petType = "Cat";
                }
                else if (choice == 2)
                {
                    petType = "Dog";
                }
                else if (choice == 3)
                {
                    petType = "Rabbit";
                }
                else { 
                    Console.WriteLine("Enter a valid input !!");
                    Console.WriteLine("Please choose a type of pet:\n1. Cat\n2.Dog\n3.Rabbit");
                    Console.WriteLine("User Input: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                }

            } while (choice!=1 || choice != 2 || choice != 3);

            Console.WriteLine("You have chossen a " + petType + ". What would you like to name your pet");
            Console.WriteLine("User Input: ");
            petName = (Console.ReadLine());
            Console.WriteLine("Welcome, " + petType + "! Lets take good care of him");










        }
    }
}