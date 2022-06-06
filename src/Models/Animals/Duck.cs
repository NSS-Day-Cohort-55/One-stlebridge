using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IResource, IGrazing, IEggProducing, IFeatherProducing
    {

        private Guid _id = Guid.NewGuid();

        private int _eggsProduced = 6;

        private double _feathersProduced = .75;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrassPerDay { get; set; } = .8;
        public string Type { get; } = "Duck";

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Duck {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public int CollectEggs()
        {
            return _eggsProduced;
        }

        public double CollectFeathers()
        {
            return _feathersProduced;
        }

        public override string ToString()
        {
            return $"Duck {this._shortId}. Mooo!";
        }
    }
}