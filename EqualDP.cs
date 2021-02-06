//Find reference on: https://www.hackerrank.com/challenges/equal/problem

using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {

        int t = int.Parse(Console.ReadLine());
        for (int ii = 0; ii < t; ii++)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(arr);
            int lowest = arr[0];


            int count = 0;
            int[] larr = new int[] { lowest, lowest - 1, lowest - 2, lowest - 5 };
            for (int j = 0; j < 4; j++)
            {
                count = 0;
                for (int i = 0; i < n; i++)
                {
                    count += (arr[i] - larr[j]) / 5;

                    if ((arr[i] - larr[j]) % 5 != 0)
                    {
                        if ((arr[i] - larr[j]) % 5 <= 2)
                            count++;
                        else
                            count += 2;
                    }
                }
                larr[j] = count;
            }
            lowest = larr[0];
            for (int j = 0; j < 4; j++)
                if (lowest > larr[j])
                    lowest = larr[j];
            Console.WriteLine(lowest);
        }
    }
}