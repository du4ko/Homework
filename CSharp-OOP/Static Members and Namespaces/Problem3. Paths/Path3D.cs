using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2.Distance_Calculator;
namespace Problem3.Paths
{
    class Path3D
    {
        // Constructor
        public Path3D(List<Point3D> path)
        {
            this.Path = path;
        }
        //public Path3D() : this(new List<Point3D>()) { }

        //Properties
        public List<Point3D> Path { get; private set; }
        public int Count {get{return this.Path.Count;}}
        //Methods
        public void AddPoint(Point3D point)
        {
            this.Path.Add(point);
        }
        public void RemovePoint(Point3D point)
        {
            this.Path.Remove(point);
        }

        public override string ToString()
        {
            StringBuilder finalString = new StringBuilder();
            int whom = 0;
            foreach (var item in Path)
            {
                finalString.Append(String.Format("/n" + "{0}:" + "x={1}, y={2}, z={3}", whom , item.X,item.Y,item.Z));
                whom++;
            }
            return finalString.ToString();
        }
     
    }
}
