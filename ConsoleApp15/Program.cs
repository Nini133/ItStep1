using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 3, 8, 1, 9, 3, 5, 2, 8 };

        Console.WriteLine("Where: " + string.Join(", ", Where(numbers, x => x % 2 == 0)));
        Console.WriteLine("OrderBy: " + string.Join(", ", OrderBy(numbers)));
        Console.WriteLine("First: " + First(numbers, x => x > 5));
        Console.WriteLine("FirstOrDefault: " + FirstOrDefault(numbers, x => x > 100));
        Console.WriteLine("Single: " + Single(numbers, x => x == 9));
        Console.WriteLine("SingleOrDefault: " + SingleOrDefault(numbers, x => x == 100));
        Console.WriteLine("Any: " + Any(numbers, x => x < 0));
        Console.WriteLine("All: " + All(numbers, x => x > 0));
        Console.WriteLine("Count: " + Count(numbers, x => x > 3));
        Console.WriteLine("Distinct: " + string.Join(", ", Distinct(numbers)));
    }

    // 1. Where — აბრუნებს მხოლოდ იმ ელემენტებს, რომლებიც პირობას აკმაყოფილებენ
    static List<T> Where<T>(List<T> list, Func<T, bool> condition)
    {
        List<T> result = new List<T>();

        foreach (T item in list)
        {
            if (condition(item))
                result.Add(item);
        }

        return result;
    }

    // 2. OrderBy — ალაგებს რიცხვებს ზრდადობით (Bubble Sort)
    static List<int> OrderBy(List<int> list)
    {
        List<int> result = new List<int>(list);

        for (int i = 0; i < result.Count - 1; i++)
        {
            for (int j = 0; j < result.Count - 1 - i; j++)
            {
                if (result[j] > result[j + 1])
                {
                    int temp = result[j];
                    result[j] = result[j + 1];
                    result[j + 1] = temp;
                }
            }
        }

        return result;
    }

    // 3. First — აბრუნებს პირველ შესაბამის ელემენტს, თუ არ მოიძებნა → Exception
    static T First<T>(List<T> list, Func<T, bool> condition)
    {
        foreach (T item in list)
        {
            if (condition(item))
                return item;
        }

        throw new Exception("ელემენტი ვერ მოიძებნა");
    }

    // 4. FirstOrDefault — აბრუნებს პირველ შესაბამის ელემენტს, თუ არა → default
    static T FirstOrDefault<T>(List<T> list, Func<T, bool> condition)
    {
        foreach (T item in list)
        {
            if (condition(item))
                return item;
        }

        return default(T);
    }

    // 5. Single — აბრუნებს ერთადერთ შესაბამის ელემენტს, თუ 0 ან 2+ → Exception
    static T Single<T>(List<T> list, Func<T, bool> condition)
    {
        T found = default(T);
        int count = 0;

        foreach (T item in list)
        {
            if (condition(item))
            {
                found = item;
                count++;
            }
        }

        if (count != 1)
            throw new Exception("უნდა იყოს ზუსტად ერთი შესაბამისი ელემენტი");

        return found;
    }

    // 6. SingleOrDefault — იგივეა რაც Single, მაგრამ 0-ის შემთხვევაში default
    static T SingleOrDefault<T>(List<T> list, Func<T, bool> condition)
    {
        T found = default(T);
        int count = 0;

        foreach (T item in list)
        {
            if (condition(item))
            {
                found = item;
                count++;
            }
        }

        if (count > 1)
            throw new Exception("ერთზე მეტი ელემენტი აკმაყოფილებს პირობას");

        return found; // count == 0 -> default(T)
    }

    // 7. Any — არსებობს თუ არა მინიმუმ ერთი შესაბამისი ელემენტი
    static bool Any<T>(List<T> list, Func<T, bool> condition)
    {
        foreach (T item in list)
        {
            if (condition(item))
                return true;
        }

        return false;
    }

    // 8. All — ყველა ელემენტი აკმაყოფილებს თუ არა პირობას
    static bool All<T>(List<T> list, Func<T, bool> condition)
    {
        foreach (T item in list)
        {
            if (!condition(item))
                return false;
        }

        return true;
    }

    // 9. Count — ითვლის რამდენი ელემენტი აკმაყოფილებს პირობას
    static int Count<T>(List<T> list, Func<T, bool> condition)
    {
        int count = 0;

        foreach (T item in list)
        {
            if (condition(item))
                count++;
        }

        return count;
    }

    // 10. Distinct — შლის დუბლიკატებს
    static List<T> Distinct<T>(List<T> list)
    {
        List<T> result = new List<T>();

        foreach (T item in list)
        {
            if (!result.Contains(item))
                result.Add(item);
        }

        return result;
    }
}