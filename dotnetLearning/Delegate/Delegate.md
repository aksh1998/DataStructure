# C# - Func Delegate

Func is a generic delegate included in the System namespace. It has zero or more input parameters and one out parameter. The last parameter is considered as an out parameter.

```
namespace System
{
    public delegate TResult Func<in T, out TResult>(T arg);
}
```

<img src="https://www.tutorialsteacher.com/Content/images/csharp/func-delegate.png" alt="MarineGEO circle logo" style="height: 100px; width:500px;"/>

<img src="https://www.tutorialsteacher.com/Content/images/csharp/func-delegate2.png" alt="MarineGEO circle logo" style="height: 100px; width:500px;"/>

You can assign any method to the above func delegate that takes two int parameters and returns an int value.

```
class Program
{
    static int Sum(int x, int y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        Func<int,int, int> add = Sum;

        int result = add(10, 10);

        Console.WriteLine(result);
    }
}
Output:
20
```

## C# Func with an Anonymous Method

> You can assign an anonymous method to the Func delegate by using the delegate keyword.

```
Func<int> getRandomNumber = delegate()
                            {
                                Random rnd = new Random();
                                return rnd.Next(1, 100);
                            };
```

## Func with Lambda Expression

> A Func delegate can also be used with a lambda expression, as shown below:

```
Example: Func with lambda expression
Func<int> getRandomNumber = () => new Random().Next(1, 100);
//Or
Func<int, int, int>  Sum  = (x, y) => x + y;
```

---

---

# C# | Predicate Delegate

A Predicate delegate is an in-built generic type delegate. This delegate is defined under System namespace. It works with those methods which contain some set of criteria and determine whether the passed parameter fulfill the given criteria or not. This delegate takes only one input and returns the value in the form of true or false.

```
// C# program to illustrate delegates
using System;

class GFG {

    public delegate bool my_delegate(string mystring);

    public static bool myfun(string mystring)
    {
        if (mystring.Length < 7)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static public void Main()
    {
        my_delegate obj = myfun;
        // Or
        //Predicate<string> obj
        Console.WriteLine(obj("Hello"));
    }
}
```

# Or

```
class GFG {

    public delegate bool my_delegate(string mystring);

    public static bool myfun(string mystring)
    {
        if (mystring.Length < 7)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static public void Main()
    {
        my_delegate obj = myfun;
        Console.WriteLine(obj("Hello"));
    }
}
```
