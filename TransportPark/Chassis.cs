using System;
using System.Xml.Serialization;

namespace TransportPark
{
    [Serializable]

    public class Chassis
    {
        public int numberOfWheels; // number of wheels for chassis
        public int permissibleLoad; // permissible load for chassis
        public int chassisNumber; // chassis serial number
        
        public Chassis() { }

        /// <summary>
        /// The class constructor.
        /// </summary>
        /// <param name="numberOfWheels"></param>
        /// <param name="permissibleLoad"></param>
        /// <param name="chassisNumber"></param>
        public Chassis(int numberOfWheels, int permissibleLoad, int chassisNumber)
        {
            this.numberOfWheels = numberOfWheels;
            this.permissibleLoad = permissibleLoad;
            this.chassisNumber = chassisNumber;
            if (numberOfWheels < 0 || permissibleLoad < 0)
            {
                throw new ArgumentOutOfRangeException("Only positive values are allowed");
            }
            int lengthChassisNumber = chassisNumber.ToString().Length;
            if (lengthChassisNumber < 5 || lengthChassisNumber > 5)
            {
                throw new Exception("Chassis number length consists of 5 symbols"); 
            }
        }

        /// <summary>
        /// Method GetInfo().
        /// </summary>
        /// <returns>
        /// Returns a string of field values for the chassis.
        /// </returns>
        public string GetInfo()
        {
            return String.Format("Number of wheels is {0}, Permissible load is {1}, Chassis number is {2}; ",
                                  numberOfWheels, permissibleLoad, chassisNumber);
        }
    }
}