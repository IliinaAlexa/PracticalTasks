using System;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace TransportPark
{
    [Serializable]

    class Program
    {
        static void Main(string[] args)

        {
            TransportPark transportPark = new TransportPark();
            try
            {
                Chassis chassis = new Chassis(4, 1500, 78896); // class object chassis for car
                Engine engine = new Engine(150, 2, "diesel", 1234); // class object engine for car
                Transmission transmission = new Transmission("automative", 6, "ZF"); // class object transmission for car
                Chassis chassisBus = new Chassis(12, 5000, 58741); // class object chassis for bus
                Engine engineBus = new Engine(200, 2.5, "petrol", 5248); // class object engine for bus
                Transmission transmissionBus = new Transmission("automative", 8, "KL"); // class object transmission for bus
                Chassis chassisTruck = new Chassis(16, 7000, 98741); // class object chassis for truck
                Engine engineTruck = new Engine(300, 3.5, "petrol", 7635); // class object engine for truck
                Transmission transmissionTruck = new Transmission("manual", 6, "JGHF"); // class object transmission for truck
                Chassis chassisScooter = new Chassis(2, 500, 56895); // class object chassis for scooter
                Engine engineScooter = new Engine(70, 1, "diesel", 58789); // class object engine for scooter
                Transmission transmissionScooter = new Transmission("manual", 4, "HGUS"); // class object transmission for scooter
                Chassis chassisCarKIA = new Chassis(6, 2000, 58942);
                Engine engineCarKIA = new Engine(300, 2.5, "petrol", 1234);
                Transmission transmissionCarKIA = new Transmission("automative", 8, "GT");
                Chassis chassisBusMAN = new Chassis(15, 3000, 85741);
                Engine engineBusMAN = new Engine(300, 3, "diesel", 74588);
                Transmission transmissionBusMAN = new Transmission("manual", 6, "HRT");
                Chassis chassisTruckGAZ = new Chassis(12, 7000, 98561);
                Engine engineTruckGAZ = new Engine(300, 1.5, "diesel", 7635);
                Transmission transmissionTruckGAZ = new Transmission("manual", 6, "YTHF");
                Chassis chassisScooterBMW = new Chassis(4, 600, 58595);
                Engine engineScooterBMW = new Engine(80, 1, "petrol", 58789);
                Transmission transmissionScooterBMW = new Transmission("manual", 2, "QWE");
                Car car = new Car("Car ", "Black ", chassis, engine, transmission); // class object car
                Bus bus = new Bus("Bus ", 50, chassisBus, transmissionBus, engineBus); // class object bus
                Truck truck = new Truck("Truck", 5500, chassisTruck, transmissionTruck, engineTruck); // class object truck
                Scooter scooter = new Scooter("Scooter ", 50, chassisScooter, transmissionScooter, engineScooter); // class object scooter
                Car carKIA = new Car("KIA ", "Red ", chassisCarKIA, engineCarKIA, transmissionCarKIA); // class object Kia car
                Bus busMAN = new Bus("MAN ", 60, chassisBusMAN, transmissionBusMAN, engineBusMAN); // class object MAN bus
                Truck truckGAZ = new Truck("GAZ ", 7000, chassisTruckGAZ, transmissionTruckGAZ, engineTruckGAZ); // class object Gaz truck
                Scooter scooterBMW = new Scooter("BMW ", 60, chassisScooterBMW, transmissionScooterBMW, engineScooterBMW); // class object BMW scooter

                transportPark.Transports.Add(car); // add class object car in list
                transportPark.Transports.Add(bus); // add class object bus in list
                transportPark.Transports.Add(truck); // add class object truck in list
                transportPark.Transports.Add(scooter); // add class object scooter in list
                transportPark.Transports.Add(carKIA); // add class object Kia car in list
                transportPark.Transports.Add(busMAN); // add class object MAN bus in list
                transportPark.Transports.Add(truckGAZ); // add class object Gaz truck in list
                transportPark.Transports.Add(scooterBMW); // add class object BMW scooter in list
                Console.WriteLine(transportPark.GetInfo());

            // select information about all vehicles Which an engine capacity is more than 1.5 liters
            var selectedEnginetransport = transportPark.Transports.Where(x => x.Engine.engineVolume > 1.5)
                                                                  .ToList();

            XmlSerializer xml = new XmlSerializer(typeof(List<Vehicle>)); // create a new serializer with type List<Vehicle>
            TextWriter writer = new StreamWriter("transportParkEngineVolume.xml"); // create a xml file
            xml.Serialize(writer, selectedEnginetransport); // serialize the file

            // select information about engine type, serial number and power rating for all buses and trucks
            var selectedtransportBusTruck = transportPark.Transports.Where(x => x is Bus || x is Truck)
                                                                    .Select(x =>
                                                                    (x.Engine.engineType, x.Engine.engineSerialNumber,
                                                                    x.Engine.enginePower))
                                                                    .ToList();

            XmlSerializer xmlTruckBus = new XmlSerializer(typeof(List<(string, int, int)>)); // create a new serializer with type string,int,int
            TextWriter writerXml = new StreamWriter("selectedtransportBusTruck.xml"); // create a new xml file
            xmlTruckBus.Serialize(writerXml, selectedtransportBusTruck); // serialize the file

            // select information about all vehicles, grouped by transmission type
            var transportGroupedByTransmission = transportPark.Transports.GroupBy(x => x.Transmission.transmissionType)
                                                                         .Select(x => (x.Key, x.Select(t =>
                                                                         (t.Name, t.Chassis, t.Engine, t.Transmission))
                                                                         .ToList()))
                                                                         .ToList();

            // create a new serializer with type List<(string, List<(string, Chassis, Engine, Transmission)>)>
            XmlSerializer xmltransportGrouped = new XmlSerializer(typeof(List<(string, List<(string, Chassis, Engine, Transmission)>)>));
            TextWriter writerGrouped = new StreamWriter("GroupedByTransmission.xml"); // create a new xml file
            xmltransportGrouped.Serialize(writerGrouped, transportGroupedByTransmission); // serialize the file
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}