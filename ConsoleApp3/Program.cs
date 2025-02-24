using System;

class Program
{
    static void Main()
    {
        int[][] jaggedArray = new int[3][];

        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        int target = 5;

        bool found = false;

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                if (jaggedArray[i][j] == target)
                {
                    found = true;
                    break;
                }
            }
            if (found)
                break;
        }

        if (found)
        {
            Console.WriteLine(target + " jagged array ichida mavjud  .");
        }
        else
        {
            Console.WriteLine(target + " jagged array ichida mavjud emas  .");
        }
    }
}
