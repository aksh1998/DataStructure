# C# | Multiple inheritance using interfaces

C# does not support multiple class inheritance. To overcome this problem we use interfaces to achieve multiple class inheritance.

```
using System;
using System.Collections;

interface GFG1 {
    void languages();
}

class Geeks1 : GFG1 {

    public void languages()
    {
        ArrayList My_list = new ArrayList();

        My_list.Add("C");
        My_list.Add("C++");
        My_list.Add("C#");
        My_list.Add("Java");

        Console.WriteLine("Languages provided by GeeksforGeeks:");
        foreach(var elements in My_list)
        {
            Console.WriteLine(elements);
        }
    }
}

interface GFG2 {
    void courses();
}

class Geeks2 : GFG2 {

    public void courses()
    {
        ArrayList My_list = new ArrayList();

        My_list.Add("System Design");
        My_list.Add("Fork Python");
        My_list.Add("Geeks Classes DSA");
        My_list.Add("Fork Java");

        Console.WriteLine("\nCourses provided by GeeksforGeeks:");
        foreach(var elements in My_list)
        {
            Console.WriteLine(elements);
        }
    }
}

class GeeksforGeeks : GFG1, GFG2 {
    Geeks1 obj1 = new Geeks1();
    Geeks2 obj2 = new Geeks2();

    public void languages()
    {
        obj1.languages();
    }

    public void courses()
    {
        obj2.courses();
    }
}

// Driver Class
public class GFG {

    static public void Main()
    {
        GeeksforGeeks obj = new GeeksforGeeks();
        obj.languages();
        obj.courses();
    }
}
```

---

---

# C# | Explicit Interface Implementation

An Interface is a collection of loosely bounded items that have a common functionality or attributes. Interfaces contain method signatures, properties, events etc. Interfaces are used so that one class or struct can implement multiple behaviors. C# doesn’t support the concept of Multiple Inheritance because of the ambiguity it causes. But a lot of real life objects inherit properties of more than just one type, therefore interfaces are used instead of extending classes.

```
using System;

interface I1 {
    void printMethod();
}

interface I2 {
    void printMethod();
}

class C : I1, I2 {

    void I1.printMethod()
    {
        Console.WriteLine("I1 printMethod");
    }
    void I2.printMethod()
    {
        Console.WriteLine("I2 printMethod");
    }
}

class GFG {
    static void Main(string[] args)
    {
        I1 i1 = new C();
        I2 i2 = new C();

        i1.printMethod();
        i2.printMethod();
    }
}
```

---

---
