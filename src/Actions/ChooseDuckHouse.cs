using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IFeeding animal)
        {
            Utils.Clear();

            for (int i = 0; i < farm.DuckHouse.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Duck House ({farm.DuckHouse[i].Animals.Count()})");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
            choice = choice - 1;

            if (farm.DuckHouse[choice].Capacity - farm.DuckHouse[choice].Animals.Count() >= 1)
            {
                farm.DuckHouse[choice].AddResource(animal);
            }
            else
            {
                Console.WriteLine("**** That facililty is not large enough ****");
                Console.WriteLine("****Please choose another one****");
            }

        }
    }
}