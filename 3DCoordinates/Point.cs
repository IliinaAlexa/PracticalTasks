using System;


namespace _3DCoordinates
{
    public struct Point
    {
        double x, y, z;
        public double X
        {
            get { return x; }
        }
        public double Y
        {
            get { return y; }
        }
        public double Z
        {
            get { return z; }
        }
        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            
            if (x < 0 || y < 0 || z < 0)
            {
                throw new ArgumentOutOfRangeException("Only positive values ​​are allowed");
            }
           
        }
        /*  public static double GetDistance(Point A, Point B)
          {
              return Math.Sqrt(((B.X - A.X) * (B.X - A.X)) + ((B.Y - A.Y) * (B.Y - A.Y)) + ((B.Z - A.Z) * (B.Z - A.Z)));
          }*/


        /// <summary>
        /// To calculate the distance between two points.
        /// </summary>
        /// <param name="position"></param>
        /// <returns>
        /// Returns Point3D.
        /// </returns>

        public double GetDistance(Point position) 
        {
            return Math.Sqrt(((this.X - position.X) * (this.X - position.X)) + 
                             ((this.Y - position.Y) * (this.Y - position.Y)) +
                             ((this.Z - position.Z) * (this.Z - position.Z))); 
        }
        

    }
}
