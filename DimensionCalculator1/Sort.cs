
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionCalculator1
{
    class Sort : MainWindow
    {
        static double[] numbers = new double[20];
        static void Main(string[] args)
        {
            Random rand = new Random();
            //Loop 20 times
            for (int i = 0; i < 20; i++)
            {
                //numbers[i] = Double.Parse(Console.ReadLine());
                numbers[i] = rand.NextDouble();
            }

            //Print out unsorted array
            Console.WriteLine("Array not sorted: ");
            for (var i = 0; i < numbers.Length; i++)
            {
                //Math.Round() Rounds the number you provide (1st parameter) to number of specified decimal places (the 2nd parameter)
                Console.WriteLine(Math.Round(numbers[i] * 100, 2));
            }

            double temp = 0.0;
            //Sort array
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    //Swap
                    if (numbers[i] > numbers[j])
                    {
                        //Current value is greater than next number
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            //Print out sorted array
            Console.WriteLine("Array sorted: ");
            for (var i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(Math.Round(numbers[i] * 100, 0));
            }

            Console.ReadLine();
        }


    }
}
