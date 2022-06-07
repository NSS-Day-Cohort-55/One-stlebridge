using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public List<IGrazing> Animals
        {
            get
            {
                return _animals;
            }
        }

        public void AddResource(IGrazing animal)
        {
            _animals.Add(animal);
        }

        public void AddResource(List<IGrazing> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }



        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            int cowCounter = 0;
            int pigCounter = 0;
            int goatCounter = 0;
            int sheepCounter = 0;
            int ostrichCounter = 0;

            foreach (var animal in Animals)
            {
                if (animal.ToString().Contains("Cow"))
                {
                    cowCounter++;
                }
                else if (animal.ToString().Contains("Pig"))
                {
                    pigCounter++;
                }
                else if (animal.ToString().Contains("Goat"))
                {
                    goatCounter++;
                }
                else if (animal.ToString().Contains("Sheep"))
                {
                    sheepCounter++;
                }
                else if (animal.ToString().Contains("Ostrich"))
                {
                    ostrichCounter++;
                }
            }

            output.Append($"Grazing Field ({cowCounter} cow, {pigCounter} pig, {goatCounter} goat, {sheepCounter} sheep and {ostrichCounter} ostrich)\n");
            //this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}