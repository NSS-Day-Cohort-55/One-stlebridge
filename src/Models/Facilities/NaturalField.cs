using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities {
    public class NaturalField : IFacility<ISeedProducing>
    {
        private int _plantsPerRow = 6;
        private int _rows = 10;
        private Guid _id = Guid.NewGuid();
        private List<ISeedProducing> _plants = new List<ISeedProducing>();

        public double Capacity {
            get {
                return _plantsPerRow * _rows;
            }
        }

        public int Rows {
            get {
                return _rows;
            }
        }

        public int PlantsPerRow {
            get {
                return _plantsPerRow;
            }
        }

        public void AddResource (ISeedProducing plant)
        {
             // TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource(ICompostProducing plant)
        {
            throw new NotImplementedException();
        }

        public void AddResource (List <ISeedProducing> plants)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            this._plants.ForEach(p => output.Append($"   {p}\n"));

            return output.ToString();
        }
    }
}