using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mynums = new int[4]; //array with 4 integers
            int[] mynums2 = { 1, 3, 6, 32, 2, 421, 7, 3, 5, 67 }; //array with set values
            mynums[0] = 1;
            mynums[1] = 2;
            mynums[2] = 3;
            mynums[3] = 4;
            //mynums[4] = 5; causes out of bounds error 
            string[] weekDays = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            int[] myNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }

            Console.WriteLine(mynums2.Length);
            Console.WriteLine(mynums2[3]);

            foreach (int i in mynums2)
            {
                Console.WriteLine(i);
            }
            foreach (int i in mynums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
