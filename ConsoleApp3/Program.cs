﻿using System;

class Program
{
    static void Main()
    {
        int[][] jaggedArray = new int[3][];

        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        Console.WriteLine("Har bir ichki massiv teskari tartibda:");

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Array.Reverse(jaggedArray[i]);

            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }

            Console.WriteLine();
        }
    }
}
