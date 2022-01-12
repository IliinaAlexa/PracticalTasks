using System;
using System.Xml.Serialization;

namespace TransportPark
{
    [Serializable]

    public class Scooter : Vehicle
    {
        private int maxSpeed; // max scooter speed
        public Scooter() { }
        /// <summary>
        /// The class constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="maxSpeed"></param>
        /// <param name="chassis"></param>
        /// <param name="transmission"></param>
        /// <param name="engine"></param>
        public Scooter(string name, int maxSpeed, Chassis chassis, Transmission transmission, Engine engine) : base(name, chassis, transmission, engine)
        {
            this.maxSpeed = maxSpeed;
        }
        /// <summary>
        /// Override method ToString().
        /// </summary>
        /// <returns>
        /// Returns a string of field values for the scooter.
        /// </returns>
        public override string ToString()
        {
            return String.Format("Max speed is {0}", maxSpeed) + base.ToString();
        }
    }
}
