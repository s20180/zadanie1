using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] demoArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            System.Console.WriteLine("Inputs: " + demoArr);
            System.Console.WriteLine("Average: " + Average(demoArr));
            System.Console.WriteLine("Max: " + Max(demoArr));
        }

        private static double Average(int[] inputs)
        {
            int counter = 0;
            int sum = 0;
            foreach (int integer in inputs)
            {
                sum += integer;
                counter++;
            }

            if (counter == 0)
            {
                counter++;
            }
            
            return sum / counter;
        }

        private static int Max(int[] inputs)
        {
            int max = inputs[0];

            foreach (int integer in inputs)
            {
                if (max < integer)
                {
                    max = integer;
                }
            }
            
            return max;
        }
    }
}