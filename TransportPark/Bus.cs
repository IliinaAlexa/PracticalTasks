using System;
using System.Xml.Serialization;

namespace TransportPark
{
    [Serializable]
   
    public class Bus : Vehicle
    {
        private int placeNumber; // number of place in bus

        public Bus() { }
        /// <summary>
        /// The class constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="placeNumber"></param>
        /// <param name="chassis"></param>
        /// <param name="transmission"></param>
        /// <param name="engine"></param>
        public Bus(string name, int placeNumber, Chassis chassis, Transmission transmission, Engine engine) : base(name, chassis, transmission, engine)
        {
            this.placeNumber = placeNumber;
        }
        /// <summary>
        /// Override method ToString().
        /// </summary>
        /// <returns>
        /// Returns a string of field values for the bus.
        /// </returns>
        public override string ToString()
        {
            return String.Format("Place number is {0}", placeNumber) + base.ToString();
        }
    }
}