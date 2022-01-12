using System;

namespace _3DCoordinates
{
    interface IFlyable

    {
        /// <summary>
        /// To fly to the point
        /// </summary>
        /// <param name="coordinate"></param>
        void FlyTo(Point coordinate);

        /// <summary>
        /// To calculate the flight time
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns>The duration of the flight</returns>
        double GetFlyTime(Point coordinate); 
     
    }
}
