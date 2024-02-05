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
            int petHunger=5, petHappiness=5, petHealth=5;
            
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

            /*            Accepting input from the user
            */

            Console.WriteLine("You have chossen a " + petType + ". What would you like to name your pet");
            Console.Write("\n");
            Console.Write("User Input: ");
            petName = Console.ReadLine();
            Console.Write("\n");
            Console.WriteLine("Welcome, " + petName + "! Lets take good care of him");
            Console.Write("\n");


            do
            {
                
                if(petHunger >= 7 || petHealth <= 3 || petHappiness <= 3 )
                {
                    /*            Verifying if the pet is ok. otherwise approprite message is displayed.
                    */
                    
                    if (petHunger >= 7)
                    {
                        Console.WriteLine(petName + " is hungry feed him\n");
                        petHunger = 7;
                    }
                    if (petHealth <= 3)
                    {
                        Console.WriteLine(petName + "is not healthy let him rest \n");
                        petHealth = 3;
                    }
                    if (petHappiness <= 3)
                    {
                        Console.WriteLine(petName + "is not happy play with him\n");
                        petHappiness = 3;
                    }                    
      
                }

                /*           Displaying the main menu message
                    */

                Console.WriteLine("Main menu:\n1. Feed Buddy\n2.Play with Buddy\n3.Let Buddy Rest\n4.Check buddy's Status\n5.Exit\n\n");
                activityWithPet = Convert.ToInt32(Console.ReadLine());

                switch (activityWithPet)
                {
                    case 1:

                        /*            Feeding the ped
                    */

                        petHunger = Math.Max (1 , petHunger -= 4);
                        petHealth = Math.Min(10, petHealth += 2);
                        
                        Console.WriteLine(petName + "'s Status: \n - Hunger: " + petHunger + "\n - Happiness: " + petHappiness + "\n - Health: " + petHealth + "\n ");
                        break;

                    case 2:

                        /*            When the pet hunger is greater than or equal to 7 the user cannot make the
                                      play without feeding it more.
                         */                                     

                        if (petHunger >= 7)
                        {
                            Console.WriteLine("Feed the pet\n");
                            break;
                        }

                        /*              Playing with the pet
                        */

                        petHunger = Math.Max(10, petHunger -= 1);
                        petHappiness = Math.Min(10, petHappiness += 4);
                        Console.WriteLine(petName + "'s Status: \n - Hunger: " + petHunger + "\n - Happiness: " + petHappiness + "\n - Health: " + petHealth + "\n ");
                        break;

                    case 3:
                        /*            Making the pet rest.
                        */

                        petHealth = Math.Min(10, petHealth += 4);
                        petHappiness = Math.Max(1, petHappiness -= 1);
                        Console.WriteLine(petName + "'s Status: \n - Hunger: " + petHunger + "\n - Happiness: " + petHappiness + "\n - Health: " + petHealth + "\n ");
                        break;

                    case 4:

                        /*            Displaying the pet status to the user.
                        */

                        Console.WriteLine(petName + "'s Status: \n - Hunger: " + petHunger + "\n - Happiness: " + petHappiness + "\n - Health: " + petHealth + "\n ");
                        break;

                    case 5:
                        /*            Exit menu for the user to exit out of the loop.
                        */

                        Console.WriteLine("Thank you for playing with " + petName + ".Goodbye! ");
                        return;
                    default:
                        Console.WriteLine("Enter a valid input !!");
                        break;

                }

                /*            After every action one hour is passed and hunger and happniesi is changed.
                */

                petHunger = Math.Min(10, petHunger += 1);
                petHappiness = Math.Max(1, petHappiness -= 1);
                Console.WriteLine("One hour has passed!!  ");
                Console.WriteLine(petName + "'s Status: \n - Hunger: " + petHunger + "\n - Happiness: " + petHappiness + "\n - Health: " + petHealth+"\n");
                

            } while (activityWithPet != 5);






        }
    }
}