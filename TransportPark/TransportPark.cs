using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TransportPark
{
    [Serializable]
    [XmlInclude(typeof(Vehicle))]
    [XmlInclude(typeof(Car))]
    [XmlInclude(typeof(Bus))]
    [XmlInclude(typeof(Scooter))]
    [XmlInclude(typeof(Truck))]
    [XmlInclude(typeof(Chassis))]
    [XmlInclude(typeof(Engine))]
    [XmlInclude(typeof(Transmission))]

    public class TransportPark
    {
        /// <summary>
        /// List<Vehicle> property.
        /// </summary>
        public List<Vehicle> Transports { get; set; } 

        /// <summary>
        /// The class constructor.
        /// </summary>
        public TransportPark()
        {
            Transports = new List<Vehicle>();
        }

        /// <summary>
        /// Method GetInfo()
        /// </summary>
        /// <returns>
        /// Returns transports list.
        /// </returns>
        public string GetInfo()
        {
            StringBuilder resultTransportStringBuilder = new StringBuilder();
            foreach (Vehicle transport in Transports)
            {
                resultTransportStringBuilder.Append(transport.GetInfo());
                resultTransportStringBuilder.Append("\n");
            }
            return "Transport list is " + resultTransportStringBuilder.ToString();
        }
    }
}
