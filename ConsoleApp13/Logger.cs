using System;

class Logger : IDisposable
{
    public void Log(string text)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"[LOG] {text}");
        Console.ResetColor();
    }

    public void Dispose()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("[LOG] Logger დახურულია.");
        Console.ResetColor();
    }
}
