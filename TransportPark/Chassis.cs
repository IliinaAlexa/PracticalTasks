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
        }
        /// <summary>
        /// Override method ToString().
        /// </summary>
        /// <returns>
        /// Returns a string of field values for the chassis.
        /// </returns>
        public override string ToString()
        {
            return String.Format("Number of wheels is {0}, Permissible load is {1}, Chassis number is {2}",
                                  numberOfWheels, permissibleLoad, chassisNumber);
        }
    }
}