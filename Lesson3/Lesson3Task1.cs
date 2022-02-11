using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbAlgorithms
{
    /// <summary>
    /// Measures execution time of Class and Struct Points methods on arrays of different sizes.
    /// </summary>
    internal class Lesson3Task1 : ITask
    {
        public string Description { get; }

        public Lesson3Task1()
        {
            Description = "Task 1. Distance";
        }
        /// <summary>
        /// Creates array of points of PointClassDouble
        /// </summary>
        /// <param name="pointsNumber">number of points</param>
        /// <returns></returns>
        private PointClassDouble[] createClassPointsArray(int pointsNumber)
        {

            PointClassDouble[] pointsArray = new PointClassDouble[pointsNumber];
            for (int i = 0; i < pointsNumber; i++)
            {
                Random random = new Random(100);
                pointsArray[i] = new PointClassDouble { x = random.NextDouble(), y = random.NextDouble()};
            }
            return pointsArray;
        }
        /// <summary>
        /// Creates array of points of PointStructDouble
        /// </summary>
        /// <param name="pointsNumber">number of points</param>
        /// <returns></returns>
        private PointStructDouble[] createStructPointsArray(int pointsNumber)
        {
            PointStructDouble[] pointsArray = new PointStructDouble[pointsNumber];
            for (int i = 0; i < pointsNumber; i++)
            {
                Random random = new Random();
                pointsArray[i] = new PointStructDouble { x = random.NextDouble(), y = random.NextDouble() };
            }
            return pointsArray;
        }

        /// <summary>
        /// Calculates distance between points
        /// </summary>
        /// <param name="pointOne">Point One</param>
        /// <param name="pointTwo">Point two</param>
        /// <returns>Distance between two points</returns>
        public static double PointDistance(PointStructDouble pointOne, PointStructDouble pointTwo)
        {
            double x = pointOne.x - pointTwo.x;
            double y = pointOne.y - pointTwo.y;
            return Math.Sqrt((x * x) + (y * y));
        }
        /// <summary>
        /// Calculates distance between points
        /// </summary>
        /// <param name="pointOne">Point One</param>
        /// <param name="pointTwo">Point two</param>
        /// <returns>Distance between two points</returns>
        public static double PointDistance(PointClassDouble pointOne, PointClassDouble pointTwo)
        {
            double x = pointOne.x - pointTwo.x;
            double y = pointOne.y - pointTwo.y;
            return Math.Sqrt((x * x) + (y * y));
        }

        /// <summary>
        /// Calculate execution time for n point of PointClassDouble and PointStructDouble
        /// </summary>
        /// <param name="n"></param>
        public void calculateTime(int n)
        {
            Stopwatch stopwatch = new Stopwatch();
            PointClassDouble[] classPoints = createClassPointsArray(n);
            PointStructDouble[] structPoints = createStructPointsArray(n);

            stopwatch.Start();
            for (int i = 0; i < classPoints.Length - 1; i++)
            {
               PointDistance(classPoints[i], classPoints[i + 1]);
            }
            stopwatch.Stop();
            var classTime = stopwatch.Elapsed;

            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < classPoints.Length - 1; i++)
            {
                PointDistance(classPoints[i], classPoints[i + 1]);
            }
            stopwatch.Stop();
            var structTime = stopwatch.Elapsed;

            Console.WriteLine($"Number of points: {n}");
            Console.WriteLine("# of points |   PointStructDouble   |   PointClassDouble    |   Ratio");
            Console.WriteLine($"{n}\t\t{structTime}\t{classTime}\t{structTime/classTime}");
        }
    }
}
