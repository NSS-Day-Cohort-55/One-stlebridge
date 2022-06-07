using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Utils.Clear();

            // How can I output the type of animal chosen here?

            void placeAnimal()
            {
                int i = 0;
                foreach (var anim in farm.GrazingFields)
                {
                    Console.WriteLine($"{i + 1}. {anim}");
                    i++;
                }


                Console.WriteLine();
                Console.WriteLine($"Place the animal where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine()) - 1;
                if (farm.GrazingFields[choice].Capacity - farm.GrazingFields[choice].Animals.Count() >= 1)
                {
                    farm.GrazingFields[choice].AddResource(animal);
                }
                else
                {
                    Console.WriteLine("**** That facililty is not large enough ****");
                    Console.WriteLine("**** Please choose another one ****");
                    Console.WriteLine();
                    placeAnimal();
                }
            }

            placeAnimal();



            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}