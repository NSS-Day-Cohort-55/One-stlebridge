using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, ISeedProducing
    {
        private double _compostProduced = 3.03;
        public string Type { get; } = "Wildflower";

        public double Harvest () {
            return _compostProduced;
        }

        public override string ToString () {
            return $"Wildflowers are for composting.";
        }
    }
}