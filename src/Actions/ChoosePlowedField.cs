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
                int count = 1;
                int i = 0;
                int e = 0;
                foreach (var plant in farm.PlowedFields)
                {
                    Console.WriteLine($"{i + 1}. {plant}");
                    i++;
                    count++;
                }
                if (plant is ICompostProducing)
                {
                    foreach (var plant in farm.NaturalFields)
                    {
                        Console.WriteLine($"{i + 1}. {plant}");
                        e++;
                        count++;
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"Place the seeds where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine()) - 1;
                if (choice + 1 > farm.PlowedFields.Count())
                {
                    if (farm.NaturalFields[choice - (farm.PlowedFields.Count())].Capacity - farm.NaturalFields[choice - (farm.PlowedFields.Count())].Plants.Count() >= 1)
                    {

                        if (plant is ICompostProducing)
                        {
                            farm.NaturalFields[choice - (farm.PlowedFields.Count())].AddResource(plant as ICompostProducing);
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
                else
                {
                    if (farm.PlowedFields[choice].Capacity - farm.PlowedFields[choice].Plants.Count() >= 1)
                    {
                        farm.PlowedFields[choice].AddResource(plant);
                    }
                    else
                    {
                        Console.WriteLine("**** That facililty is not large enough ****");
                        Console.WriteLine("**** Please choose another one ****");
                        Console.WriteLine();
                        plantSeed();
                    }
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