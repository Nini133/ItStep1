using System;
using System.Collections.Generic;
using System.Linq;

public class Array : IOutput2
{
    private readonly List<int> _data;

    public Array(params int[] numbers)
    {
        _data = new List<int>(numbers);
    }

    public void ShowEven()
    {
        List<int> evens = _data.Where(n => n % 2 == 0).ToList();
        Console.Write("Even numbers: ");
        if (evens.Count == 0)
            Console.WriteLine("(no even numbers found)");
        else
            Console.WriteLine(string.Join(", ", evens));
    }

    public void ShowOdd()
    {
        List<int> odds = _data.Where(n => n % 2 != 0).ToList();
        Console.Write("Odd numbers:  ");
        if (odds.Count == 0)
            Console.WriteLine("(no odd numbers found)");
        else
            Console.WriteLine(string.Join(", ", odds));
    }
}