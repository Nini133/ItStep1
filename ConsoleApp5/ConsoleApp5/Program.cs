decimal balance = 1000;
int choice = 0;

while (choice != 4)
{
    Console.WriteLine("1-Balance  2-Deposit  3-Withdraw  4-Exit");
    Console.Write("Choose operation: ");
    choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        Console.WriteLine($"Balance: {balance}GEL");
    }
    else if (choice == 2)
    {
        Console.Write("Amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        if (amount > 0) balance += amount;
        else Console.WriteLine("Invalid amount!");
    }
    else if (choice == 3)
    {
        Console.Write("Amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        if (amount > 0 && amount <= balance) balance -= amount;
        else Console.WriteLine("Invalid amount or insufficient funds!");
    }
}

Console.WriteLine("Exit");