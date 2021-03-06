using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<IFeeding>
    {
        private int _capacity = 15;
        private Guid _id = Guid.NewGuid();

        private List<IFeeding> _animals = new List<IFeeding>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public List<IFeeding> Animals
        {
            get
            {
                return _animals;
            }
        }

        public void AddResource(IFeeding animal)
        {
            _animals.Add(animal);
        }

        // public void AddResource(IFeeding animal)
        // {
        //     // TODO: implement this...
        //     throw new NotImplementedException();
        // }

        public void AddResource(List<IFeeding> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken house {shortId} has {this._animals.Count} chickens\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}