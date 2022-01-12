using System;
using System.Xml.Serialization;

namespace TransportPark
{
    [Serializable]

    public class Engine
    {
        public int enginePower; 
        public double engineVolume;
        public string engineType;
        public int engineSerialNumber;

        public Engine() { }
        /// <summary>
        /// The class constructor.
        /// </summary>
        /// <param name="enginePower"></param>
        /// <param name="engineVolume"></param>
        /// <param name="engineType"></param>
        /// <param name="engineSerialNumber"></param>
        public Engine(int enginePower, double engineVolume, string engineType, int engineSerialNumber)
        {
            this.enginePower = enginePower;
            this.engineVolume = engineVolume;
            this.engineType = engineType;
            this.engineSerialNumber = engineSerialNumber;
        }
        /// <summary>
        /// Override method ToString().
        /// </summary>
        /// <returns>
        /// Returns a string of field values for the engine.
        /// </returns>
        public override string ToString()
        {
            return String.Format("Power is {0}, Volume is {1}, Type is {2}, Serial number is {3}",
                                  enginePower, engineVolume, engineType, engineSerialNumber);
        }
    }
}