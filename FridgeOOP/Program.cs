using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an interactive console window
            //prompt user to chose what to do with the fridge
            //call methods on fridge object to so what user wants

            int userChoice;
            Fridge userFridge = new Fridge(false, "deluxe dispenser", 70, true);

            do
            {
                Console.WriteLine("Hello, welcome to the fridge app. ");
                Console.WriteLine("What would you like to do with you fridge?");

                Console.WriteLine("To dispesense water, type 1");
                Console.WriteLine("To change lightbulb, type 2");
                Console.WriteLine("To clean, type 3");
                Console.WriteLine("to take food, type 4");
                Console.WriteLine("To check food supples, type 5");
                Console.WriteLine("To see all fridge detail, type 6");
                //Console.WriteLine("To restart, type 7");
                Console.WriteLine("To quit, type 8");

                userChoice = int.Parse(Console.ReadLine());


                

                switch (userChoice)
                {
                    case 1:
                        userFridge.DispenseWater();
                        break;

                    case 2:
                        Console.WriteLine(userFridge.ChangeBulbs());
                        break;

                    case 3:
                        Console.WriteLine(userFridge.Clean());
                        break;

                    case 4:
                        Console.WriteLine("How much food would you like to remove");
                        int removeFood = int.Parse(Console.ReadLine());
                        userFridge.RemoveFood(removeFood);
                        Console.WriteLine("your new new food level is: " + userFridge.FoodAmount);
                       break;

                    case 5:
                        Console.WriteLine(userFridge.CheckSupplies());
                        break;

                    case 6:
                        Console.WriteLine("your fridge detials is: " + userFridge.IsClean + "your fridge is clean" + userFridge.DispenserType + 
                            userFridge.FoodAmount + userFridge.BulbsWork + "you bulbs work");
                        break;




                }

            } while (userChoice != 8);
        }
    }
}
