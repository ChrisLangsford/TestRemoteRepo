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
            int[] idNumbers = { 122, 167, 204, 219, 345 };
            int x;
            string entry;
            int entryId;

            Console.Write("Enter employee ID: ");
            entry = Console.ReadLine();
            entryId = Convert.ToInt32(entry);

            x = Array.BinarySearch(idNumbers, entryId);

            if (x < 0)
            {
                Console.WriteLine("ID {0} not found", entryId);
            }
            else
            {
                Console.WriteLine("ID {0} found at position {1}", entryId, x);
            }
        }
    }
}
