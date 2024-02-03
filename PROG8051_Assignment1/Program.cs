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
            int activityWithPet;
            int petHunger=5, petHappiness=5, petHealth=8;
            
            Console.WriteLine("Please choose a type of pet:\n1.Cat\n2.Dog\n3.Rabbit");
            Console.Write("\n");
            Console.Write("User Input: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

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
                    Console.WriteLine("Please choose a type of pet:\n1.Cat\n2.Dog\n3.Rabbit");
                    Console.Write("\n");
                    Console.WriteLine("User Input: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n");
                }

            } while (choice != 1 && choice != 2 && choice != 3);

            Console.WriteLine("You have chossen a " + petType + ". What would you like to name your pet");
            Console.Write("\n");
            Console.Write("User Input: ");
            petName = (Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("Welcome, " + petName + "! Lets take good care of him");
            Console.Write("\n");



            /*            Console.WriteLine("Main menu:\n1. Feed Buddy\n2.Play with Buddy\n3.Let Buddy Rest\n4.Check buddy's Status\n5.Exit");
                          activityWithPet=Convert.ToInt32(Console.ReadLine());
            */

            do
            {

               

                Console.WriteLine("Main menu:\n1. Feed Buddy\n2.Play with Buddy\n3.Let Buddy Rest\n4.Check buddy's Status\n5.Exit\n");
                activityWithPet = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");

                switch (activityWithPet)
                {
                    case 1:
                        petHunger -= 4;
                        petHealth += 2;
                        Console.WriteLine("You have fed " + petName + ".His happiness decreased to " + petHunger + ", And his hunger is now at " + petHealth + ". ");
                        Console.Write("\n");


                        petHunger += 1;
                        petHappiness -= 1;
                        Console.WriteLine("One hour has passed!!  " + petName + "'s happiness decreased to " + petHunger + ", But his hunger is now at " + petHunger + ". ");
                        Console.Write("\n");

                        break;

                    case 2:
                        petHunger += 1;
                        petHappiness += 1;
                        Console.WriteLine("You have played with " + petName + ".His happiness increased to " + petHappiness + ", But his hunger is now at " + petHunger + ". ");
                        Console.Write("\n");

                        petHunger += 1;
                        petHappiness -= 1;
                        Console.WriteLine("One hour has passed!!  " + petName + "'s happiness decreased to " + petHunger + ", But his hunger is now at " + petHunger + ". ");
                        Console.Write("\n");

                        break;

                    case 3:
                        petHealth += 2;
                        petHappiness -= 1;
                        Console.WriteLine(petName + " has rested " + ".His health is not at " + petHealth + ", But his happiness is now at " + petHappiness + ". ");
                        Console.Write("\n");

                        petHunger += 1;
                        petHappiness -= 1;
                        Console.WriteLine("One hour has passed!!  " + petName + "'s happiness decreased to " + petHunger + ", But his hunger is now at " + petHunger + ". ");
                        Console.Write("\n");

                        break;

                    case 4:
                        Console.WriteLine(petName + "'s Status: \n - Hunger: " + petHunger + "\n - Happiness: " + petHappiness + "\n - Health: " + petHealth);
                        Console.Write("\n");
                        break;

                    case 5:
                        Console.WriteLine("Thank you for playing with " + petName + ".Goodbye! ");
                        return;
                    default:
                        Console.WriteLine("Enter a valid input !!");
                        break;

                }

            } while (activityWithPet != 5);






        }
    }
}