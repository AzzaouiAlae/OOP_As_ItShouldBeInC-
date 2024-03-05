using System;
public partial class Person
{
    partial void PrintAge()
    {
        Console.WriteLine($"Current age is {Age}");
    }
    
}
