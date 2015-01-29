using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.Distance_Calculator
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Point3D firstPoint = new Point3D(1.3, 2.5, 3.6);
            Point3D secondPoint = new Point3D(3.7, 8.9, 4.6);

            Distance_Calculator.DistanceCalculator.CalculateDistance(firstPoint, secondPoint);
        }
    }
}
