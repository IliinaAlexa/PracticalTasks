using System;

namespace _3DCoordinates
{
    class Program
    {
        static void Main(string[] args)
        {
               FlyingObjects flyingObjects = new FlyingObjects();
            try
            {
                Point currentPosition = new Point(1, 1, 1);
                Plane plane = new Plane();
                plane.CurrentPosition = currentPosition;
                Drone drone = new Drone(70);
                drone.CurrentPosition = currentPosition;
                Bird bird = new Bird();
                bird.CurrentPosition = currentPosition;
                flyingObjects.Flyables.Add(new Bird()); // current position
                flyingObjects.Flyables.Add(new Drone(50));
                flyingObjects.Flyables.Add(new Plane());
                var timeResults = flyingObjects.GetFlyTimes(new Point(20, 500, 100));
                foreach (var time in timeResults)
                {
                    Console.WriteLine(time);
                }
                
                foreach (var flyingObject in flyingObjects.Flyables)
                {
                    try
                    {
                        flyingObject.FlyTo(new Point(20, 50, 10));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }     
    }
}
