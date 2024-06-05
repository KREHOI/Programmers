using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        s = s.Replace(" ", "");
        
        if (s.Length < 0 || s.Length > 1000000)
            return;
        
        Console.WriteLine(s);
    }
}