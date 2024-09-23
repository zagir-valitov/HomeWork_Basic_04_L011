namespace HomeWork_Basic_04;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("--- Home work 4 ---");

        Console.WriteLine("\n Additional exercise No. 3");
        Console.WriteLine("-----------------------------------------------------------");

        Console.WriteLine("  1. Create a new stack");
        var s1 = new Stack();
        Console.WriteLine($"     Top: {(s1.Top == null ? "null" : s1.Top)} Size: {s1.Size}");

        Console.WriteLine("\n  2. Added new elements to the stack");
        s1.Add("2");
        Console.WriteLine($"     Top: {(s1.Top == null ? "null" : s1.Top)} Size: {s1.Size}");
        s1.Add("1");
        Console.WriteLine($"     Top: {(s1.Top == null ? "null" : s1.Top)} Size: {s1.Size}");
        s1.Add("b");
        Console.WriteLine($"     Top: {(s1.Top == null ? "null" : s1.Top)} Size: {s1.Size}");
        s1.Add("a");
        Console.WriteLine($"     Top: {(s1.Top == null ? "null" : s1.Top)} Size: {s1.Size}");

        Console.WriteLine("\n  3. Retrieving and removing the top element of the stack");
        Console.Write($"     Removed the top element {s1.Top}  ");
        var deleted = s1.Pop();
        Console.WriteLine($" Top: {(s1.Top == null ? "null" : s1.Top)}  Size: {s1.Size},");

        Console.Write($"     Removed the top element {s1.Top}  ");
        deleted = s1.Pop();
        Console.WriteLine($" Top: {(s1.Top == null ? "null" : s1.Top)}  Size: {s1.Size},");

        Console.Write($"     Removed the top element {s1.Top}  ");
        deleted = s1.Pop();
        Console.WriteLine($" Top: {(s1.Top == null ? "null" : s1.Top)}  Size: {s1.Size},");

        Console.Write($"     Removed the top element {s1.Top}  ");
        deleted = s1.Pop();
        Console.WriteLine($" Top: {(s1.Top == null ? "null" : s1.Top)}  Size: {s1.Size},");

        //Console.Write($"     Removed the top element {s1.Top}");
        //deleted = s1.Pop();
        //Console.WriteLine($" Top: {(s1.Top == null ? "null" : s1.Top)} Size: {s1.Size},");

    }
}
