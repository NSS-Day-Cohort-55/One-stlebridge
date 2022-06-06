using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class PurchaseSeed {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Sesame");
            Console.WriteLine ("2. Sunflower");
            Console.WriteLine ("2. Wildflower");

            Console.WriteLine ();
            Console.WriteLine ("What are you buying today?");

            Console.Write ("> ");
            string choice = Console.ReadLine ();

            switch (Int32.Parse(choice))
            {
                case 1:
                    Console.WriteLine("You chose Sesame.");
                    break;
                case 2:
                    Console.WriteLine("You chose Sunflower.");
                    break;
                case 3:
                    Console.WriteLine("You chose Wildflower.");
                    break;
                default:
                    break;
            }
        }
    }
}