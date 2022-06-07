using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<ISeedProducing>
    {
        private int _plantsPerRow = 5;
        private int _rows = 13;
        private Guid _id = Guid.NewGuid();
        private List<ISeedProducing> _plants = new List<ISeedProducing>();

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
                return _rows * _plantsPerRow;
            }
        }


        public List<ISeedProducing> Plants
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

        public void AddResource(ISeedProducing plant)
        {
            // TODO: implement this...
            _plants.Add(plant);
        }

        public void AddResource(List<ISeedProducing> plants)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Plowed Field {shortId} has {this._plants.Count} plants\n");
            this._plants.ForEach(p => output.Append($"   {p}\n"));

            return output.ToString();
        }
    }
}