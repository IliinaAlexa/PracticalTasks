using System.Collections.Generic;

namespace _3DCoordinates
{
    class FlyingObjects
    {
        public List<IFlyable> Flyables { get; set; }

        public FlyingObjects()
        {
            Flyables = new List<IFlyable>();
        }

        /// <summary>
        /// To add flying objects to list
        /// </summary>
        /// <param name="point"></param>
        /// <returns>
        /// Returns times list.
        /// </returns>
        public List<double> GetFlyTimes(Point point)
        {
            List<double> resultFlyables = new List<double>();
            foreach (IFlyable flyable in Flyables)
            {
                resultFlyables.Add(flyable.GetFlyTime(point));
            }
            return resultFlyables;
        }
      
    }
}
