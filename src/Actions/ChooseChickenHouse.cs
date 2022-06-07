using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, IFeeding animal)
        {
            Utils.Clear();

            for (int i = 0; i < farm.ChickenHouse.Count; i++)
            {
                if (farm.ChickenHouse[i].Animals.Count() < farm.ChickenHouse[i].Capacity)
                {
                    Console.WriteLine($"{i + 1}. Chicken House ({farm.ChickenHouse[i].Animals.Count()})");
                }
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
            choice = choice - 1;

            if (farm.ChickenHouse[choice].Capacity - farm.ChickenHouse[choice].Animals.Count() >= 1)
            {
                farm.ChickenHouse[choice].AddResource(animal);
            }
            else
            {
                Console.WriteLine("**** That facililty is not large enough ****");
                Console.WriteLine("****Please choose another one****");
            }

        }
    }
}