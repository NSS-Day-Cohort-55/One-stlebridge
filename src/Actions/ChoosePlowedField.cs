using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
    {
        public static void CollectInput(Farm farm, ISeedProducing plant)
        {
            Utils.Clear();

            void plantSeed()
            {
                for (int i = 0; i < farm.PlowedFields.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Plowed Field ({farm.PlowedFields[i].Plants.Count()} rows of plants)");
                }
                if (plant is ICompostProducing)
                {
                    for (int i = 0; i < farm.NaturalFields.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. Natural Field ({farm.NaturalFields[i].Plants.Count()} rows of plants)");
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"Place the seeds where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine()) - 1;
                if (farm.PlowedFields[choice].Capacity - farm.PlowedFields[choice].Plants.Count() >= 1)
                {
                    if (choice + 1 > farm.PlowedFields.Count())
                    {
                        farm.NaturalFields[choice].AddResource(plant);
                    }
                    else
                    {
                        farm.PlowedFields[choice].AddResource(plant);
                    }
                }
                else
                {
                    Console.WriteLine("**** That facililty is not large enough ****");
                    Console.WriteLine("**** Please choose another one ****");
                    Console.WriteLine();
                    plantSeed();
                }
            }

            plantSeed();

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}