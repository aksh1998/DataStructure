// ref: https://www.hackerrank.com/challenges/pairs/problem
// Q. Given an array of integers and a target value, 
// determine the number of pairs of array elements that have a difference equal to the target value.



using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static int pairs(int diffrence, List<int> arr)
    {
        int total = 0;

        arr.Sort();

        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < arr.Count; i++)
        {
            int sum = arr[i] - diffrence;

            if (dict.ContainsKey(sum))
            {
                Console.WriteLine(arr[i]);
                total++;
            }

            dict.Add(arr[i], 0);
        }
        return total;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.pairs(k, arr);

        Console.WriteLine(result);
    }
}
