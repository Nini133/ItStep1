namespace ConsoleApp8;

class Product
{
    public int Id;
    public string Name;
    public string Description;
    public double Price;
    public int Quantity;
    public string Brand;
    public string Category;
    public double Rating;
    public bool IsAvailable;
    public double DiscountPercent;
    public string ImageUrl;
    public double Weight;
    public string MadeIn;
    public bool IsNew;

    public string GetPriceCategory()
    {
        if (Price < 100)  return "იაფი";
        if (Price < 1000) return "საშუალო";
        return "ძვირი";
    }

    public void CheckAvailability()
    {
        if (Quantity > 0)
        {
            IsAvailable = true;
            Console.WriteLine(Name + " ხელმისაწვდომია");
        }
        else
        {
            IsAvailable = false;
            Console.WriteLine(Name + " არ არის ხელმისაწვდომი");
        }
    }

    public void CheckIsNew(bool isUsed)
    {
        if (isUsed)
        {
            IsNew = false;
            Console.WriteLine(Name + " არის მეორადი პროდუქტი");
        }
        else
        {
            IsNew = true;
            Console.WriteLine(Name + " არის ახალი პროდუქტი");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product();

        product1.Name = "Adidas runners";
        product1.Description = "ადიდასის სპორტული ფეხსაცმელი";
        product1.Price = 230;
        product1.Quantity = 120;
        product1.Brand = "Adidas";
        product1.Rating = 4.8;
        product1.DiscountPercent = 10;

        Console.WriteLine(product1.GetPriceCategory());
        product1.CheckAvailability();
        product1.CheckIsNew(false);
    }
}