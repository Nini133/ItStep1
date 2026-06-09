namespace ConsoleApp8;

class Program
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("CarsData.txt");
        Car[] cars = new Car[lines.Length];

        for (int i = 0; i < lines.Length; i++)
            cars[i] = Car.ParseFromLine(lines[i]);

      
        Car mostExpensive = cars[0];
        for (int i = 1; i < cars.Length; i++)
            if (cars[i].Price > mostExpensive.Price)
                mostExpensive = cars[i];

        Console.WriteLine("=== ყველაზე ძვირი ===");
        Console.WriteLine(mostExpensive);

        Console.WriteLine("\n=== ახალი მანქანები ===");
        for (int i = 0; i < cars.Length; i++)
            if (cars[i].IsNew())
                Console.WriteLine(cars[i]);


        Console.WriteLine("\n=== 20,000$ - 60,000$ ფასის მანქანები ===");
        for (int i = 0; i < cars.Length; i++)
            if (cars[i].Price >= 20000 && cars[i].Price <= 60000)
                Console.WriteLine(cars[i]);

     
        Car oldest = cars[0];
        for (int i = 1; i < cars.Length; i++)
            if (cars[i].Year < oldest.Year)
                oldest = cars[i];

        Console.WriteLine("\n=== ყველაზე ძველი ===");
        Console.WriteLine(oldest);

      
        string searchBrand = "Toyota";
        Console.WriteLine($"\n=== {searchBrand}-ის მანქანები ===");
        for (int i = 0; i < cars.Length; i++)
            if (cars[i].Brand.Equals(searchBrand, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine(cars[i]);
    }
}
