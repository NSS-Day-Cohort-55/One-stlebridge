using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<ICompostProducing>
    {
        private int _plantsPerRow = 6;
        private int _rows = 10;
        private Guid _id = Guid.NewGuid();
        private List<ICompostProducing> _plants = new List<ICompostProducing>();


        public double Capacity
        {
            get
            {
                return _rows;
            }
        }
        public double Amount
        {
            get
            {
                return _plantsPerRow * _rows;
            }
        }

        public List<ICompostProducing> Plants
        {
            get
            {
                return _plants;
            }
        }

        public int Rows
        {
            get
            {
                return _rows;
            }
        }

        public int PlantsPerRow
        {
            get
            {
                return _plantsPerRow;
            }
        }


        public void AddResource(ICompostProducing plant)
        {
            _plants.Add(plant);
        }

        public void AddResource(List<ICompostProducing> plants)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            int sunflowerCount = 0;
            int wildflowerCount = 0;

            foreach (var plant in Plants)
            {
                if (plant.ToString().Contains("Sunflower"))
                {
                    sunflowerCount++;
                }
                else if (plant.ToString().Contains("Wildflower"))
                {
                    wildflowerCount++;
                }
            }

            output.Append($"Natural Field ({sunflowerCount} sunflower, {wildflowerCount} wildflower)\n");
            // output.Append($"Natural Field {shortId} has {this._plants.Count} plants\n");
            // this._plants.ForEach(p => output.Append($"   {p}\n"));

            return output.ToString();
        }
    }
}