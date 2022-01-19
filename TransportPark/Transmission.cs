using System;
using System.Xml.Serialization;

namespace TransportPark
{

    [Serializable]

    public class Transmission
    {
        public string transmissionType;
        public int transferNumber;
        public string transmissionManufacture;
        public Transmission() { }

        /// <summary>
        /// The class constructor.
        /// </summary>
        /// <param name="transmissionType"></param>
        /// <param name="transferNumber"></param>
        /// <param name="transmissionManufacture"></param>
        public Transmission(string transmissionType, int transferNumber, string transmissionManufacture)
        {
            this.transferNumber = transferNumber;
            this.transmissionManufacture = transmissionManufacture;
            if (transmissionType == "manual" || transmissionType == "automative")
            {
                this.transmissionType = transmissionType;
            }
            else
            {
                throw new Exception("Transmission type can be manual or automative");
            }
            if (transferNumber < 0)
            {
                throw new ArgumentOutOfRangeException("Only positive values are allowed");
            }
        }

        /// <summary>
        /// Override method ToString().
        /// </summary>
        /// <returns>
        /// Returns a string of field values for the transmission.
        /// </returns>
        public string GetInfo()
        {
            return String.Format("Type is {0}, Transfer number is {1}, Manufacture is {2}; ",
                                  transmissionType, transferNumber, transmissionManufacture) ;
        }
    }
}