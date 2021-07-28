## (try-catch-final)(try-catch)(try-final)

**using** is equivalent **try-finally**. You will only use try-finally when you want to do some clean up inside finally and don't care about the exception.
s
The best approach will be

```
try
{
   using(resource)
   {
       //Do something here
   }
}catch(Exception)
{
     //Handle Error
}
```

## Doing so even clean up called by **using** fails, your code will not fail.

There are some condition when finally will not get executed.

1. If there is any StackOverflowException or ExecutingEngineException.
2. Process is killed from external source.
   Hope this answers your doubt.

---

---

# C# | Nesting of try and catch blocks

In C#, the nesting of the try & catch block is allowed. The nesting of try block means one try block can be nested into another try block. The various programmer uses the outer try block to handling serious exceptions, whereas the inner block for handling normal exceptions.

```
// outer try block
try
{

   // inner try block
   try
     {
       // code...
     }

   // inner catch block
   catch
     {
       // code...
     }
}

// outer catch block
catch
  {
    // code...
  }
```

---

---

### Q. Is it valid to have finally block without try and catch?

> If an exception is thrown prior to the **try block**, the **finally code** will not execute. The finally block always executes when the try block exits. So you can use finally without catch but you must use try.

> A finally clause ensures that the finally block is executed after the try block and any catch block that might be executed, no matter how control leaves the try block or catch block.

Hence a finally should always be preceded by a try block.

---

### Q. If our program does not catch an exception then the who?

> If our program does not catch an exception then the .NET CLR catches it.

---

---

# Arithmetic Overflow

Overflow is an operation that occurs when a calculation produces a result that is greater in magnitude than that which a given register or storage location can store or represent.

> As you can see, when reaching the maximum value of a given numeric type, trying to add anything will overflow the capacity and result in a wrong value.

By default, the .Net runtime will not raise exceptions when doing numeric calculations. If you want to ensure that arithmetic operations will throw overflow exceptions if an overflow happens, you need to use the `checked { ... }`s code block.

```
checked
    {
        try
        {
            var intValue = Int32.MaxValue;
            var overflow = intValue + 1;

            Console.WriteLine($"intValue: {intValue}");
            Console.WriteLine($"overflow: {overflow}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow !");
        }
    }
```

---

---

# Difference between "throw" and "throw ex" in C#

> throw : If we use "throw" statement, it preserve original error stack information. In exception handling "throw" with empty parameter is also called re-throwing the last exception.

> throw ex : If we use "throw ex" statement, stack trace of exception will be replaced with a stack trace starting at the re-throw point. It is used to intentionally hide stack trace information.

```
catch (Exception ex)
{
    // do some stuff here
    throw; // a) continue ex
    throw new MyException("failed", ex); // b) wrap
    throw new MyException("failed"); // c)  replace
    throw ex; // d)  reset stack-trace
}
```

So it is good practice to use the "throw" statement, rather than "throw ex" because it will give us more accurate stack information rather than "throw ex".
