namespace HomeWork_Basic_04;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Home work 4 ---");

        Console.WriteLine(" Main exercise");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("  1. Create a new stack");
        var s1 = new Stack();
        Console.WriteLine($"     Size: {s1.Size}, Top: {(s1.Top == null ? "null" : s1.Top)}");

        Console.WriteLine("\n  2. Added new elements to the stack");
        s1.Add("1");
        Console.WriteLine($"     Size: {s1.Size}, Top: {(s1.Top == null ? "null" : s1.Top)}");       
        s1.Add("2");
        Console.WriteLine($"     Size: {s1.Size}, Top: {(s1.Top == null ? "null" : s1.Top)}");
        s1.Add("a");
        Console.WriteLine($"     Size: {s1.Size}, Top: {(s1.Top == null ? "null" : s1.Top)}");       
        s1.Add("b");
        Console.WriteLine($"     Size: {s1.Size}, Top: {(s1.Top == null ? "null" : s1.Top)}");

        Console.WriteLine("\n  3. Retrieving and removing the top element of the stack");
        var deleted = s1.Pop();
        Console.WriteLine($"     Removed the top element [{deleted}] Size: {s1.Size}, Top: {(s1.Top == null ? "null" : s1.Top)}");
        deleted = s1.Pop();
        Console.WriteLine($"     Removed the top element [{deleted}] Size: {s1.Size}, Top: {(s1.Top == null ? "null" : s1.Top)}");
        deleted = s1.Pop();
        Console.WriteLine($"     Removed the top element [{deleted}] Size: {s1.Size}, Top: {(s1.Top == null ? "null" : s1.Top)}");
        deleted = s1.Pop();
        Console.WriteLine($"     Removed the top element [{deleted}] Size: {s1.Size}, Top: {(s1.Top == null ? "null" : s1.Top)}");
        //deleted = s1.Pop();
        //Console.WriteLine($"Removed the top element [{deleted}] Size: {s1.Size}, Top: {(s1.Top == null ? "null" : s1.Top)}");

        Console.WriteLine("\n Additional exercise No. 1");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("\n     Application of the Merge() method");
        var s2 = new Stack("a", "b", "c");
        var s3 = new Stack("1", "2", "3");
        Console.WriteLine("     stack_1 -> \"a\", \"b\", \"c\"");
        Console.WriteLine("     stack_2 -> \"1\", \"2\", \"3\"");
        s2.Merge(s3);
        Console.WriteLine($"     Top => {s2.Top}");
        Console.Write("     stack_2.Merge(stack_1) => ");
        while (s2.Size > 0)
            Console.Write($"\"{s2.Pop()}\" ");

        Console.WriteLine("\n\n Additional exercise No. 2");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("\n     Application of the Concat() method");
        var s4 = new Stack("a", "b", "c");
        var s5 = new Stack("1", "2", "3");
        var s6 = new Stack("A", "B", "C");
        Console.WriteLine("     stack_1 -> \"a\", \"b\", \"c\"");
        Console.WriteLine("     stack_2 -> \"1\", \"2\", \"3\"");
        Console.WriteLine("     stack_3 -> \"A\", \"B\", \"C\"");
        //var s7 = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
        var s7 = Stack.Concat(s4, s5, s6);
        Console.WriteLine($"     Top => {s7.Top}");
        Console.Write("     stack_4 = Concat(stack_1, stack_2, stack_3) => ");
        while (s7.Size > 0)
            Console.Write($"\"{s7.Pop()}\" ");
        Console.WriteLine("\n");
    }
}
