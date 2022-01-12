using System;
using System.Xml.Serialization;

namespace TransportPark
{
    [Serializable]
    

    public class Car : Vehicle
    {
        private string color; // car color
        public Car() { }
       /// <summary>
       /// The class constructor.
       /// </summary>
       /// <param name="name"></param>
       /// <param name="color"></param>
       /// <param name="chassis"></param>
       /// <param name="engine"></param>
       /// <param name="transmission"></param>
        public Car(string name, string color, Chassis chassis, Engine engine, Transmission transmission) : base(name, chassis, transmission, engine)
        {
            this.color = color;

        }
        /// <summary>
        /// Override method ToString().
        /// </summary>
        /// <returns>
        /// Returns a string of field values for the car.
        /// </returns>
        public override string ToString()
        {
            return String.Format("Color is {0}", color + " ") + base.ToString();

        }
    }
}