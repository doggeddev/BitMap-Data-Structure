using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPearlsBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bitmap for sorting a set of integers

            int[] numbers = { 12345, 54637, 15478, 34521, 97624, 34516, 91452, 37815, 74863, 34578};

            Console.WriteLine("writing 0s to bitmap");

            int[] bitmap = new int[99999];

            for(int i = 0; i < bitmap.Length; i++) //init all indicies to 0
            {
                bitmap[i] = 0;
            }

            Console.WriteLine("writing 1s to bitmap");

            for (int i = 0; i < numbers.Length; i++) //for every integer read, mark a 1 in corresponding position
            {
                bitmap[numbers[i]] = 1;
            }

            for(int i = 0; i < bitmap.Length; i++) //every 1 in the array, write the index on the screen
            {
                if(bitmap[i] == 1)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
