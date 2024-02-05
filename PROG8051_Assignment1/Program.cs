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
                
                if(petHunger >= 7 || petHealth <= 3 || petHappiness <= 3 )
                {
                    if(petHunger >= 7)
                    {
                        Console.WriteLine(petName + " is hungry feed him");
                        petHunger = 7;
                        Console.Write("\n");
                    }
                    if (petHealth <= 3)
                    {
                        Console.WriteLine(petName + "is not healthy let him rest ");
                        petHealth = 3;
                        Console.Write("\n");
                    }
                    if (petHappiness <= 3)
                    {
                        Console.WriteLine(petName + "is not happy play with him");
                        petHappiness = 3;
                        Console.Write("\n");
                    }

                    
      
                }

                Console.WriteLine("Main menu:\n1. Feed Buddy\n2.Play with Buddy\n3.Let Buddy Rest\n4.Check buddy's Status\n5.Exit\n");
                activityWithPet = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");

                switch (activityWithPet)
                {
                    case 1:
                        petHunger -= 4;
                        petHealth += 2;
                        Console.WriteLine("You have fed " + petName + ".His happiness is at " + petHappiness + ",his hunger is now at " + petHunger + " and his health is at  " + petHealth);
                        Console.Write("\n");


                        petHunger += 1;
                        petHappiness -= 1;
                        Console.WriteLine("One hour has passed!!  " + petName + "'s happiness decreased to " + petHunger + ", his hunger is now at " + petHunger + " and his health is at  " + petHealth);
                        Console.Write("\n");



                        break;

                    case 2:
                        if(petHunger >= 7)
                        {
                            Console.WriteLine("Feed the pet");
                            break;
                        }

                        petHunger += 1;
                        petHappiness += 4;
                        Console.WriteLine(petName + "'s Status: \n - Hunger: " + petHunger + "\n - Happiness: " + petHappiness + "\n - Health: " + petHealth);
                        Console.Write("\n");

                        petHunger += 1;
                        petHappiness -= 1;
                        Console.WriteLine("One hour has passed!!  ");
                        Console.WriteLine(petName + "'s Status: \n - Hunger: " + petHunger + "\n - Happiness: " + petHappiness + "\n - Health: " + petHealth);
                        Console.Write("\n");

                        break;

                    case 3:
                        petHealth +=4 ;
                        petHappiness -= 1;
                        Console.WriteLine(petName + "'s Status: \n - Hunger: " + petHunger + "\n - Happiness: " + petHappiness + "\n - Health: " + petHealth);
                        Console.Write("\n");
                        

                        petHunger += 1;
                        petHappiness -= 1;
                        Console.WriteLine("One hour has passed!!  ");
                        Console.WriteLine(petName + "'s Status: \n - Hunger: " + petHunger + "\n - Happiness: " + petHappiness + "\n - Health: " + petHealth);
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

                if (petHunger < 1 || petHealth < 1 || petHappiness < 1 || petHunger > 10 || petHealth > 10 || petHappiness > 10)
                {
                    petHunger = (petHunger > 10) ? 10 : petHunger;
                    petHappiness = (petHappiness > 10) ? 10 : petHappiness;
                    petHealth = (petHealth > 10) ? 10 : petHealth;

                    petHunger = (petHunger < 1) ? 1 : petHunger;
                    petHappiness = (petHappiness < 1) ? 1 : petHappiness;
                    petHealth = (petHealth < 1) ? 1 : petHealth;
                }

            } while (activityWithPet != 5);






        }
    }
}