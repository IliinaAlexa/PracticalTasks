using System;

namespace _3DCoordinates
{
    class Plane: IFlyable
    {
        private double startingSpeed = 200; // km/h
        const double ACCELERATION = 208; // km/h
        private double Speed;
    
        public Point CurrentPosition { get; set; }

        public Plane()
        {
            if (Speed > 950) // If speed more than 950 km/h, throw an exception 
            {
                throw new Exception("Plane cannot fly, speed more than 950 ");
            }
        }
      

        /// <summary>
        /// To fly to the point
        /// </summary>
        /// <param name="coordinate"></param>
        public void FlyTo(Point coordinate)
        {
            CurrentPosition = coordinate;
        }

        /// <summary>
        /// To calculate the flight time
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns>
        /// Returns the duration of the flight
        /// </returns>
        public double GetFlyTime(Point coordinate) => (((Math.Sqrt(2*CurrentPosition.GetDistance(coordinate)*ACCELERATION + 
                                                                 startingSpeed*startingSpeed) - startingSpeed)) / ACCELERATION);


    }
}
