using System;
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

    public abstract class Vehicle // base class
    {
    /// <summary>
    /// The name property.
    /// </summary>
    public string Name {get; set; }

    /// <summary>
    /// The engine property.
    /// </summary>
    public Engine Engine { get; set; }

    /// <summary>
    /// The transmission property.
    /// </summary>
    public Transmission Transmission { get; set; }

    /// <summary>
    /// The chassis property.
    /// </summary>
    public Chassis Chassis { get; set; }

        public Vehicle(){}

        /// <summary>
        /// The base class constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="chassis"></param>
        /// <param name="transmission"></param>
        /// <param name="engine"></param>
        public Vehicle(string name, Chassis chassis, Transmission transmission, Engine engine)
        {
            this.Name = name;
            Engine = engine;
            Transmission = transmission;
            Chassis = chassis;

        }

        /// <summary>
        /// Override method ToString()
        /// </summary>
        /// <returns>
        /// Returns a string of field values for the vehicle.
        /// </returns>
        public override string ToString()
        {
            return  String.Format("Name is {0}", Name) +
                    String.Format("Chassis is {0}", Chassis) +
                    String.Format("Transmission is {0}", Transmission) +
                    String.Format("Engine is {0}", Engine);

        }

    }
}