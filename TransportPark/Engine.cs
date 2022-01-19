using System;
//using System.Xml.Serialization;

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
            this.engineSerialNumber = engineSerialNumber;
            if (enginePower < 0 || engineVolume < 0 || engineSerialNumber < 0)
            {
                throw new ArgumentOutOfRangeException("Only positive values are allowed");
            }
            if (engineType == "petrol" || engineType == "diesel" || engineType == "gaz" || engineType == "electro")
            {
                this.engineType = engineType;
            }
            else
            {
                throw new Exception("Engine type can be petrol, diesel, gaz and electro");
            }
        }

        /// <summary>
        /// Method GetInfo().
        /// </summary>
        /// <returns>
        /// Returns a string of field values for the engine.
        /// </returns>
        public string GetInfo()
        {
            return String.Format("Power is {0} , Volume is {1} , Type is {2} , Serial number is {3}. ",
                                    enginePower, engineVolume, engineType, engineSerialNumber);
        }
    }
}