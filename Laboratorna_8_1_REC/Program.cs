using System;

public class Program
{
    public static int CountRecursive(string s, int index = 0)
    {
        string searchString = "while";
        index = s.IndexOf(searchString, index, StringComparison.OrdinalIgnoreCase);

        if (index != -1)
        {
            return 1 + CountRecursive(s.Substring(index + searchString.Length), 0);
        }

        return 0;
    }

    public static string ChangeRecursive(string s, int index = 0)
    {
        string searchString = "while";
        index = s.IndexOf(searchString, index, StringComparison.OrdinalIgnoreCase);

        if (index != -1)
        {
            return ChangeRecursive(s.Substring(0, index) + "**" + s.Substring(index + searchString.Length), 0);
        }

        return s;
    }

    static void Main()
    {
        Console.WriteLine("Enter string:");
        string str = Console.ReadLine();

        int whileGroupsCount = CountRecursive(str);
        Console.WriteLine($"The string contains {whileGroupsCount} occurrences of 'while'");

        string modifiedStr = ChangeRecursive(str);
        Console.WriteLine($"Modified string: {modifiedStr}");
    }
}