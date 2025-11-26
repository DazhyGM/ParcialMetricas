using System;

namespace Infrastructure.Logging;

public static class Logger
{
    public static bool Enabled { get; set; } = true;

    public static void Log(string message)
    {
        if (!Enabled) return;
        Console.WriteLine($"[LOG] {DateTime.Now} - {message}");
    }

    public static void Try(Action action)
    {
        if (action == null)
        {
            Log("Attempted to execute a null action.");
            return;
        }

        try
        {
            action();
        }
        catch (Exception ex)
        {
            Log($"Error executing action: {ex.Message}");
        }
    }
}
