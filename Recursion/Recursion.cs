using System;

public class Program
{
    // https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
    public static int ReduceToZero(int a, int count = 0)
    {
        if (a == 0) { return count; }

        if (a % 2 != 0) { a -= 1; }
        else { a /= 2; }
        count++;
        return ReduceToZero(a, count);
    }

    public static int CountZero(int a, int count = 0)
    {
        if (a == 0) { return count; }

        if (a % 10 == 0) { count++; }

        return CountZero(a / 10, count);
    }

    public static double DigitSum(int a)
    {
        if (a == 0) { return 0; }

        return (a % 10) + DigitSum(a / 10);
    }

    public static double DigitMultipication(int a)
    {
        if (a == 0) { return 0; }

        return (a % 10) * DigitMultipication(a / 10);
    }

    public static double ReverseDigit(int a = 0)
    {
        if (a % 10 == a) { return a; }

        int n = CountLogTenBase(a) - 1;
        return ((a % 10) * Math.Pow(10, n)) + (ReverseDigit(a / 10));
    }
    public static int CountLogTenBase(int a, int count = 0)
    {
        if (a == 0) { return count; }

        ++count;
        return CountLogTenBase(a / 10, count);
    }


    public static void Main()
    {
        Console.WriteLine(DigitSum(12345));
    }
}