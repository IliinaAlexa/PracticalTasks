using System;

namespace _3DCoordinates
{
    class Plane: IFlyable
    {
        private double _startingSpeed = 200; // km/h
        const double SPEEDINCREASEDISTANCE = 10;
        const double SPEEDINCREASE = 10; // km/h
        private double _currentSpeed;
    
        public Point CurrentPosition { get; set; }

        public Plane()
        {
            _currentSpeed = _startingSpeed;
           
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
        public double GetFlyTime(Point coordinate)
        {
            var fullDistance = CurrentPosition.GetDistance(coordinate);
            var increasesCount = (int)fullDistance / SPEEDINCREASEDISTANCE; // Amount of speed increase
            double accumalatedTime = 0;
            for (int i = 0; i <= increasesCount; i++)
            {
                accumalatedTime += (double)SPEEDINCREASEDISTANCE/_currentSpeed;
                _currentSpeed += SPEEDINCREASE;
                if (_currentSpeed > 950) // If speed more than 950 km/h, throw an exception 
                {
                    throw new Exception("Plane cannot fly, speed more than 950 ");
                }
            }
            return accumalatedTime + (fullDistance - SPEEDINCREASEDISTANCE * increasesCount)/_currentSpeed;
        }

    }
}
