using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TransportPark
{
    [Serializable]

    public class Truck: Vehicle
    {
        private int weight; // truck weight

        public Truck() { }

        /// <summary>
        /// The class constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        /// <param name="chassis"></param>
        /// <param name="transmission"></param>
        /// <param name="engine"></param>
        public Truck(string name , int weight, Chassis chassis, Transmission transmission, Engine engine): base(name, chassis, transmission, engine)
        {
            this.weight = weight;
        }

        /// <summary>
        /// Override method ToString().
        /// </summary>
        /// <returns>
        /// Returns a string of field values for the truck.
        /// </returns>
        public override string ToString()
        {
            return String.Format("Weight is {0}", weight) + base.ToString();
        }
    }
}
