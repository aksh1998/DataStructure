//ref: https://www.hackerrank.com/challenges/minimum-loss/problem
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

    public static int getIndex(List<long> price, long value)
    {
        for (int i = 0; i < price.Count; i++)
        {
            if (value == price[i])
            {
                return i;
            }
        }
        return 0;
    }
    public static long minimumLoss(List<long> price)
    {
        long min = 99999999999999999;
        List<long> p = new List<long>();
        foreach (var i in price)
        {
            p.Add(i);
        }
        p.Sort();
        for (int i = 0; i < price.Count - 1; i++)
        {
            long diff = p[i + 1] - p[i];
            //p[i + 1] value index in price needs to be lesser than p[i] value index  

            if (diff > 0 && diff < min && (getIndex(price, p[i + 1])) < (getIndex(price, p[i]))
            )
            {
                min = diff;
            }

        }
        return min;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<long> price = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(priceTemp => Convert.ToInt64(priceTemp)).ToList();

        long result = Result.minimumLoss(price);

        Console.WriteLine(result);

    }
}
