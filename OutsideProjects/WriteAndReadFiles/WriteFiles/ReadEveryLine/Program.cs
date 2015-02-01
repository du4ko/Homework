using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadEveryLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"c:\Users\viktor\Desktop\Homework\OutsideProjects\WriteAndReadFiles\WriteFiles\test.txt");
            int checker = 1;
            foreach (var item in text)
            {
                Console.WriteLine("{0}-line says: {1}" , checker,item );
                checker++;
            }
        }
    }
}
