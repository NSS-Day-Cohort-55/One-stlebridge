using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseStock
    {
        public static void CollectInput(Farm farm)
        {
            System.Console.WriteLine("1. Chicken");
            Console.WriteLine("2. Cow");
            Console.WriteLine("3. Duck");
            System.Console.WriteLine("4. Goat");
            System.Console.WriteLine("5. Ostrich");
            System.Console.WriteLine("6. Pig");
            System.Console.WriteLine("7. Sheep");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 1:
                    // needs to be Chicken House instead ChooseGrazingField.CollectInput(farm, new Chicken());
                    break;
                case 2:
                    ChooseGrazingField.CollectInput(farm, new Cow());
                    break;
                case 3:
                    // needs to be Duck House instead ChooseGrazingField.CollectInput(farm, new Duck());
                    break;
                case 4:
                    ChooseGrazingField.CollectInput(farm, new Goat());
                    break;
                case 5:
                    ChooseGrazingField.CollectInput(farm, new Ostrich());
                    break;
                case 6:
                    ChooseGrazingField.CollectInput(farm, new Pig());
                    break;
                case 7:
                    ChooseGrazingField.CollectInput(farm, new Sheep());
                    break;
                default:
                    break;
            }
        }
    }
}