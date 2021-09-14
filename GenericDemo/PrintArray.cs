using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class PrintArray
    {
        public static void ToPrint(int[] intArray)
        {
            foreach(int element in intArray)
            {
                Console.WriteLine(" " + element + " ");
            }
        }
    }
}
