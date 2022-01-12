﻿using System;
using System.Collections.Generic;
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
        /// Override method ToString().
        /// </summary>
        /// <returns>
        /// Returns transports list.
        /// </returns>
        public override string ToString()
        {
            string resultTransport = string.Empty;
            foreach (Vehicle transport in Transports)
            {
                resultTransport += transport.ToString();
            }
            return "Transport list is " + resultTransport;
        }
    }
}
