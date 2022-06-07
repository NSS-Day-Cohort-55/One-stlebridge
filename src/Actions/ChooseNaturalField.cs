using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput(Farm farm, ICompostProducing plant)
        {
            Utils.Clear();

            void plantSeed()
            {
                for (int i = 0; i < farm.NaturalFields.Count; i++)
                {
                    if (farm.NaturalFields[i].Plants.Count() < farm.NaturalFields[i].Capacity)
                    {
                        Console.WriteLine($"{i + 1}. Natural Field ({farm.NaturalFields[i].Plants.Count()} rows of plants)");
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"Place the seeds where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine()) - 1;
                if (farm.NaturalFields[choice].Capacity - farm.NaturalFields[choice].Plants.Count() >= 1)
                {
                    farm.NaturalFields[choice].AddResource(plant);
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