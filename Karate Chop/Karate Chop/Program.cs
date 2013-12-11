using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate_Chop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int[] array = {1,3,5};
            int request = 4;

            

            x = Chop1(array, request);

            Console.WriteLine(x.ToString());
            Console.Read();
            
           
        }

        public static int Chop1(int[] A, int key)
        {
            int low = 0, high = A.Length - 1, midpoint = 0;

            while (low <= high)
            {
                midpoint = low + (high - low) / 2;

                if (key == A[midpoint])
                {
                    return midpoint;
                }
                else if (key < A[midpoint])
                {
                    high = midpoint - 1;
                }
                else
                {
                    low = midpoint + 1;
                }
            }

            return -1;           
        }

        
    }
}
