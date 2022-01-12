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
            this.transmissionType = transmissionType;
            this.transferNumber = transferNumber;
            this.transmissionManufacture = transmissionManufacture;

        }

        /// <summary>
        /// Override method ToString().
        /// </summary>
        /// <returns>
        /// Returns a string of field values for the transmission.
        /// </returns>
        public override string ToString()
        {
            return String.Format("Type is {0}, Transfer number is {1}, Manufacture is {2}",
                                  transmissionType, transferNumber, transmissionManufacture) ;
        }
    }
}