using System;
using System.Linq;
using Trestlebridge.Actions;
using Trestlebridge.Models;

namespace Trestlebridge
{
    class Program
    {
        static void DisplayBanner()
        {
            Utils.Clear();
            Console.WriteLine();
            Console.WriteLine(@"
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
        |T||r||e||s||t||l||e||b||r||i||d||g||e|
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
                    |F||a||r||m||s|
                    +-++-++-++-++-+");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Farm Trestlebridge = new Farm();

            while (true)
            {
                DisplayBanner();
                Console.WriteLine("1. Create Facility");
                Console.WriteLine("2. Purchase Animals");
                Console.WriteLine("3. Purchase Seeds");
                Console.WriteLine("4. Display Farm Status");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                Console.WriteLine("Choose a FARMS option");
                Console.Write("> ");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    DisplayBanner();
                    CreateFacility.CollectInput(Trestlebridge);
                }
                else if (option == "2")
                {
                    DisplayBanner();
                    PurchaseStock.CollectInput(Trestlebridge);
                }
                else if(option == "3")
                {
                    DisplayBanner();
                    PurchaseSeed.CollectInput(Trestlebridge);
                }
                else if (option == "4")
                {
                    DisplayBanner();
                    Console.WriteLine("1. Seed Harvester");
                    Console.WriteLine("2. Meat Processor");
                    Console.WriteLine("3. Egg Gatherer");
                    Console.WriteLine("4. Composter");
                    Console.WriteLine("5. Feather Harvester");
                    Console.WriteLine();

                    Console.WriteLine("Choose a FARMS option or press ENTER to return to the previous menu");
                    Console.Write("> ");
                    string subOption = Console.ReadLine();

                    switch(subOption)
                    {
                        case "1":
                            Console.WriteLine(Harvest.CheckHarvestSeed(Trestlebridge));
                            break;
                        case "2":
                            Console.WriteLine(Harvest.CheckProcessMeat(Trestlebridge));
                            break;
                        case "3":
                            Console.WriteLine(Harvest.CheckGatherEgg(Trestlebridge));
                            break;
                        case "4":
                            Console.WriteLine(Harvest.CheckCompost(Trestlebridge));
                            break;
                        case "5":
                            Console.WriteLine(Harvest.CheckHarvestFeather(Trestlebridge));
                            break;
                        default:
                            break;
                    }

                }
                else if (option == "5")
                {
                    Console.WriteLine("Today is a great day for farming");
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid option: {option}");
                }
            }
        }
    }
}
