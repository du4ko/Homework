using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneProject
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Laptop sampleOne = new Laptop("Yoga",199.90);
            Laptop sampleTwo = new Laptop("Pravec", "Comunist", "Stalin", 32, "Check", 100, 10.0, 150.0, "Ruskolitieva", 4.0);
            Console.WriteLine(sampleTwo);
        }
    }
}
