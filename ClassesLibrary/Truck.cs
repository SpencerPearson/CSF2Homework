using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Truck : Vehicle
    {
        //fields

        //props
        public float LoadCapacityLbs { get; set; }

        //ctors
        public Truck(string make, string model, int year, float weight, float loadCapacityLbs)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
            LoadCapacityLbs = loadCapacityLbs;
        }

        //methods
        public override string ToString()
        {
            //return string.Format("{0} {1} {2}\nWeight: {3} lbs. Load Capacity: {4} lbs.", Year, Make, Model, Weight, LoadCapacityLbs);
            return base.ToString() + "\tCapacity: " + LoadCapacityLbs;
        }
    }
}
