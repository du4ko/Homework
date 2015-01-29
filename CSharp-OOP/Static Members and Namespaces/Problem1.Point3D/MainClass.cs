using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Members_and_Namespaces
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Point3D testPoint = new Point3D(1.5, 2.6, 9.7);
            Console.WriteLine(testPoint.ToString());
            testPoint = Point3D.StartingPoint;
            Console.WriteLine(testPoint.ToString());
        }
    }
}
