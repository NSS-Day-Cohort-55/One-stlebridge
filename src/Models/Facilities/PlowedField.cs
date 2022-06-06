using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<IPlowed>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<IPlowed> _seeds = new List<IPlowed>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IPlowed animal)
        {
             // TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource(List<IPlowed> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this._seeds.Count} animals\n");
            this._seeds.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}