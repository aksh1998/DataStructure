# Typical usage

Assuming this definition:

```bash
class Person
{
    // Not every person has a middle name. We express "no middle name" as "null"
    public string? MiddleName;
}
```

## The usage would be:

```
void LogPerson(Person person)
{
    Console.WriteLine(person.MiddleName.Length);  // WARNING: may be null
    Console.WriteLine(person.MiddleName!.Length); // No warning
}
```

The "nullability" can be modified by 2 new (type-level) operators:

```
! = from Nullable to Non-Nullable
```

````
? = from Non-Nullable to Nullable
Nullable string? x;

x is a reference type - So by default non-nullable.
We apply the ? operator - which makes it nullable.
x = null Works fine.
Nice to know: Using string? is syntactic sugar for System.Nullable<string>
```s
````
