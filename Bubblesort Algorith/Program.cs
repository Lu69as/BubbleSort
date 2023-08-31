using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = {0, 0, 0, 0, 0};
            for (int i = 0; i <= 4; i++) {
                Console.WriteLine("Put in your " + (i + 1) + " number:");
                bool valid = false;
                bool failed = false;
                int number = 0;
                while (valid == false) {
                    if (failed == true)
                        Console.WriteLine("Try again, this time with a number");
                    valid = int.TryParse(Console.ReadLine(), out number);
                    if (valid == false)
                        failed = true;
                }
                Array[i] = number;
            }
            for (int i = 1; i <= 4; i++)
                for (int f = 0; f <= 4; f++)
                    if (f < 4)
                        if (Array[f] > Array[f + 1]) {
                            int FirstNum = Array[f];
                            Array[f] = Array[f + 1];
                            Array[f + 1] = FirstNum;
                        }
            Console.WriteLine("Here are your numbers sorted: ");
            for (int i = 0; i <= 4; i++)
                Console.Write(Array[i] + ", ");
        }
    }
}
