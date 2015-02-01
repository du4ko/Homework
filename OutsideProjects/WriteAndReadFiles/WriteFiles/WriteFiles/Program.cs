using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter write = new StreamWriter("testWrite.txt"))
            {
                write.Write("Kude e faila");
            }
        }
    }
}
