using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class MotorHome : Vehicle
    {
        //fields

        //props
        public int NumberOfBeds { get; set; }

        //ctors
        public MotorHome(string make, string model, int year, float weight, int numberOfBeds)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
            NumberOfBeds = numberOfBeds;
        }

        //methods
        public override string ToString()
        {
            //return string.Format("{0} {1} {2}\nWeight: {3} lbs. Beds: {4}", Year, Make, Model, Weight, NumberOfBeds);
            return base.ToString() + "\tNumber of Beds: " + NumberOfBeds; 
        }
    }
}
