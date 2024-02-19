using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace arrays_intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> Numberslist = new List<int>(); //create a list that can change in length, add and remove elements
            int[] mynums = new int[4]; //array with 4 integers
            int[] mynums2 = { 1, 3, 6, 32, 2, 421, 7, 3, 5, 67 }; //array with set values
            mynums[0] = 1; // set each index a value
            mynums[1] = 2;
            mynums[2] = 3;
            mynums[3] = 4;
            //mynums[4] = 5; causes out of bounds error 
            string[] weekDays = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            int[] myNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // use count controlled to loop through the array
            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }

            Console.WriteLine(mynums2.Length);
            Console.WriteLine(mynums2.GetUpperBound(0));
            Console.WriteLine(mynums2[3]);

            foreach (int i in mynums2) // uses foreach to loop through the array
            {
                Console.WriteLine(i);
            }
            foreach (int i in mynums)
            {
                Console.WriteLine(i);
            }


            // lists and fun
            for (int i = 0; i < 100; i++) 
            {
                int rand = rnd.Next(1,100);
                Numberslist.Add(rand);
                Console.WriteLine(Numberslist[i]);
            }
            int[] numbers = Numberslist.ToArray();
        }
    }
}
