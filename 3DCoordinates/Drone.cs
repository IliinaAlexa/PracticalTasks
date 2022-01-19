using System;

namespace _3DCoordinates
{
    class Drone : IFlyable
    {
        const int FREEZETIME = 1;
        const double MAXDISTANCE = 1000; //1000 km
        public double Speed;
        public Point CurrentPosition { get; set; }

        public Drone(double speed)
        {       
            Speed = speed; 
        }

        /// <summary>
        /// To fly to the point.
        /// </summary>
        /// <param name="coordinate"></param>
        public void FlyTo(Point coordinate)
        {
          
               if (CurrentPosition.GetDistance(coordinate) > MAXDISTANCE) // if max distance of more than 1000 km, throw exeption.
               {
                   throw new Exception("Drone cannot to fly at a distance of more than 1000 km");
               }
               
                   CurrentPosition = coordinate;
        }

        /// <summary>
        /// To calculate the flight time
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns>
        /// The duration of the flight.
        /// </returns>
        public double GetFlyTime(Point coordinate)
        {

            if (CurrentPosition.GetDistance(coordinate) > MAXDISTANCE)
            {
                throw new Exception("Drone cannot to fly at a distance of more than 1000 km");
            }
            var helpTime = CurrentPosition.GetDistance(coordinate)/Speed;
            var freezeTime = (((int)helpTime / 10) - 1)*FREEZETIME;
            if (freezeTime > 0)
            {
                helpTime += freezeTime;
            }
            return helpTime;
        }

    }
}


