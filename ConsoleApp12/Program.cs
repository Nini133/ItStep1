class Program
{
    static void Main()
    {
        Console.WriteLine("Mixed numbers");
        Array arr1 = new Array(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        arr1.ShowEven();
        arr1.ShowOdd();

        Console.WriteLine();

        Console.WriteLine("Only odd numbers");
        Array arr2 = new Array(1, 3, 5, 7, 9);
        arr2.ShowEven();
        arr2.ShowOdd();

        Console.WriteLine();

        
    }
}