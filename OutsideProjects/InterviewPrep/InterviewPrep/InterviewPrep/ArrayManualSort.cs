using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class ArrayManualSort
    {
        static void Main(string[] args)
        {
            int[] array = {15,3,32,5,6,3,2,12};
            List<int> temporary = array.ToList<int>();
            List<int> numbers = new List<int>();
            int position = 0;
            while (temporary.Count != 0)
            {
                int minValue = temporary[0];
                for (int i = 0; i < temporary.Count; i++)
                {
                    int currentNumb = temporary[i];
                    if (currentNumb <= minValue)
                    {
                        minValue = currentNumb;
                         position = i;
                    }
                    
                }
                temporary.RemoveAt(position);
                numbers.Add(minValue);
            }



            int[] sortedArray = numbers.ToArray<int>();
            foreach (var item in sortedArray)
            {
 
                Console.Write(item + " ");
            }
            
        }
    }
}
