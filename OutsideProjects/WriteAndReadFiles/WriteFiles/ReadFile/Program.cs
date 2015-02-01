using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"c:\Users\viktor\Desktop\Homework\OutsideProjects\WriteAndReadFiles\WriteFiles\test.txt");
            Console.WriteLine(text);
        }
    }
}
