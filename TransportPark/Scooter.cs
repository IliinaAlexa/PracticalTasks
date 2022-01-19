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
            if (maxSpeed < 100 || maxSpeed > 0)
            {
                this.maxSpeed = maxSpeed;
            }
            else
            {
                throw new Exception("Scooter speed must less than 100 and more than 0");
            }
        }

        /// <summary>
        /// Override method GetInfo().
        /// </summary>
        /// <returns>
        /// Returns a string of field values for the scooter.
        /// </returns>
        public override string GetInfo()
        {
            return String.Format("Max speed is {0}", maxSpeed) + base.GetInfo();
        }
    }
}
