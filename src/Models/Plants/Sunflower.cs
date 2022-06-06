using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing, ICompostProducing
    {
        private int _seedsProduced = 50;
        private double _compostProduced = 2.16;
        public string Type { get; } = "Sunflower";

        public double Harvest()
        {
            return _seedsProduced;
            //need to return compost as well.
        }

        public double CollectCompost()
        {
            return _compostProduced;
        }


        public override string ToString()
        {
            return $"Sunflowers are for ...stuff";
        }
    }
}