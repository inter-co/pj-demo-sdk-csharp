using System;

class Utils {
    public static string LastUrl;
    public static string LastRequest;

    public static string GetString(string prompt) {
        Console.Write(prompt + ": ");
        return Console.ReadLine();
    }

    public static string GetStringOrNull(string prompt) {
        Console.Write(prompt + ": ");
        return Console.ReadLine();
    }

    public static string GetTextoCompleto(string prompt) {
        Console.Write(prompt + ": ");
        return Console.ReadLine();
    }

    public static double GetDouble(string prompt) {
        Console.Write(prompt + ": ");
        return Convert.ToDouble(Console.ReadLine());
    }

    public static int GetInt(string prompt) {
        if (!prompt.Equals("")) {
            Console.Write(prompt + ": ");
        }
        return Convert.ToInt32(Console.ReadLine());
    }
}
