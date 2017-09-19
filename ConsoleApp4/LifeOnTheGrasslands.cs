using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class LifeOnTheGrasslands
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Welcome to 'Life On The Grasslands" );
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Before we being your new life, you much choose: ");
            Console.WriteLine("[1] Live life as a Herbivore");
            Console.WriteLine("[2] Live life as a Carnivore");
        
           string animalChoice =  Console.ReadLine();
            //int parsedAnimalChoice = int.Parse(animalChoice);
            Console.WriteLine("##################################################################################");
            Console.WriteLine("##################################################################################");
            Console.WriteLine("##################################################################################");
            string firstChoiceHerbivore = "";
            string firstChoiceCarnivore = "";
            string firstChoiceInsect = "";
            string secondChoiceHerbivore = "";
            string secondChoiceCarnivore = "";


            if ( animalChoice == "1" /*|| animalChoice = "[1]"*/)
            {
                //Herbivore intro
                Console.WriteLine("you enter this world as an herbivore. You open your eyes as a rabbit");
                animalChoice = "rabbit";


            }else if( animalChoice == "2")
            {
                // Omnivore intro 
                Console.WriteLine("you enter this world as an carnivore. You open your eyes as a Coyote");
                animalChoice = "coyote";

            }
            else
            {
                // Insect intro
                Console.WriteLine("Invalid input, you must enter only the number. Hopefully you will earn this for the next life.");
                Console.WriteLine("you enter this world as an insect. You open your eyes as a Bumblebee");
                animalChoice = "bumblebee";

            }
            Console.WriteLine("##################################################################################");
            Console.WriteLine("##################################################################################");
            Console.WriteLine("##################################################################################");

            if (animalChoice == "rabbit")
            {
                Console.WriteLine("You jump out of your burrow, to see the world around you. You see a lovely patch of field-clover. Do you:");
                Console.WriteLine("[1] Hop towards the clover and nibble ");
                Console.WriteLine("[2] Stay put and look around ");

                 firstChoiceHerbivore = Console.ReadLine();


            }else if(animalChoice == "coyote")
            {
                Console.WriteLine("You jump out of your burrow to see the world around you. You see other coyotes eating from a fresh kill. Do you:");
                Console.WriteLine("[1] Trot towards them, hoping to snag a meal");
                Console.WriteLine("[2] Stay put and look around");

                 firstChoiceCarnivore = Console.ReadLine();


            }
            else
            {
                Console.WriteLine("You unferl your beutiful wings, taking in all the sunlight and glory of the world. You see a georgous flower filled with life-sustaing nectar. Do you:");
                Console.WriteLine("[1] Flutter over to the flower, taking in all the wonder of the world.");
                Console.WriteLine("[2] Fly higher into the cannopy. Hope for more delicious fruit.");

                 firstChoiceInsect = Console.ReadLine();


            }  
            Console.WriteLine("##################################################################################");
            Console.WriteLine("##################################################################################");
            Console.WriteLine("##################################################################################");
            if (animalChoice == "rabbit" && firstChoiceHerbivore == "1")
            {
                Console.WriteLine("nibble, nibble, nibble. You suddenly hear the bushes rustling");
                Console.WriteLine("What do you do?");
                Console.WriteLine("[1] You make a break for it. Running in the opposite direction");
                Console.WriteLine("[2] You hunker down. Maybe they have");
                secondChoiceHerbivore = Console.ReadLine();
            }
            else if (animalChoice == "rabbit" && firstChoiceHerbivore == "2")
            {
                Console.WriteLine("You see a group of other rabbits. Do You:");
                Console.WriteLine("[1] Hop towards them, hoping to make rabbit friends");
                Console.WriteLine("[2] Hop along to another field. Hoping to find some goldclover to nib.");
                secondChoiceHerbivore = Console.ReadLine() + 2;

            }else if(animalChoice == "coyote" && firstChoiceCarnivore  == "1")
            {


            }else if(animalChoice == "coyote" && firstChoiceCarnivore == "2")
            {

            }else
            {

            }
        }
    }
}
