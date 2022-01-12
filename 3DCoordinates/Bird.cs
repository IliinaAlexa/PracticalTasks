using System;


namespace _3DCoordinates
{
    class Bird : IFlyable
    {
       public Point CurrentPosition { get; set; }
       public double speed; 

        /// <summary>
        /// The class constructor.
        /// </summary>
        public Bird()
        {
            // CurrentPosition = point;

                Random random = new Random();
                speed = random.Next(0, 20);

            if (speed == 0) // if speed = 0, throw an exception 
            {
                throw new Exception("Bird cannot fly, speed - 0 ");
            }
        }

        /// <summary>
        /// To fly to the point
        /// </summary>
        /// <param name="coordinate">Target Point</param>
        public void FlyTo(Point coordinate)
        {
            CurrentPosition = coordinate;
        }

        //   public double GetFlyTime(Point coordinate) => Point.GetDistance(CurrentPosition, coordinate) / speed;// time min;

        /// <summary>
        /// To calculate the flight time
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns>
        /// The duration of the flight.
        /// </returns>
        public double GetFlyTime(Point coordinate)
        {
            return  CurrentPosition.GetDistance(coordinate) / speed;
        }
    }
}
