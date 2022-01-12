using System;


namespace _3DCoordinates
{
    class Drone : IFlyable
    {
        const double MAXDISTANCE = 100; //100 km
        double speed;
        public Point CurrentPosition { get; set; }
       
        public Drone()
        {       
            speed = 70; 
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
            return CurrentPosition.GetDistance(coordinate) / speed;
        }
            
    
            
             
     }
}


