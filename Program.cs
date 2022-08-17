using System;
using System.Collections;

public class Example
{
    public static void Main()
    {
        Console.Write("Hello ");
    }

    public float Add(int a, int b)
    {
        int c = a + b;
        return (float)c;
    }

    public float Sub(int a, int b)
    {
        int c = a - b;
        return (float)c;
    }
}