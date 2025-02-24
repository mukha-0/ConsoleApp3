using System;

class Program
{
    static void Main()
    {
        int[][] jaggedArray = new int[3][];

        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        Console.WriteLine("Har bir ichki qator uzunligi:");

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.WriteLine("Massiv " + (i + 1) + " uzunligi: " + jaggedArray[i].Length);
        }
    }
}
