using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class arrays
    {
        public int SumNumbers(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int MaxNumber(int[] numbers)
        {
            int max = numbers[0];
            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        public int ReverseNumbers(int[] numbers)
        {
            int reverse = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                reverse = numbers[i];
            }
            return reverse;
        }

        public void AvailableNumber(int[] number)
        {
            Console.WriteLine("Number: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            foreach (var numbers in number)
            {
                if (numbers == numb)
                {
                    Console.WriteLine("Bor");
                    return;
                }
            }
            Console.WriteLine("Yo'q");
        }

        public int[] Teskari(int[] numbers)
        {
            Array.Reverse(numbers);
            return numbers;
        }
    }
}

