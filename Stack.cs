namespace HomeWork_Basic_04;

internal class Stack
{
    private List<string> stackList = [];
    public int Size
    {
        get
        {
            return stackList.Count;
        }
    }
    public string? Top
    {
        get
        {
            if (stackList.Count == 0)
                return null;
            return stackList.Last();
        }
    }
    
    //static Stack() { }
    
    public Stack(params string[] strings)
    {
        stackList.AddRange(strings);
    }

    public void Add(string elemet)
    {
        stackList.Add(elemet);
    }

    public string Pop()
    {
        if(stackList.Count == 0)
        {
            throw new NullReferenceException("Stack is empty!");
        }
        string lastElement = stackList.Last();  
        stackList.RemoveAt(stackList.Count - 1);
        return lastElement;
    }

    public static Stack Concat(params Stack[] stacks)
    {
        var stackConcat = new Stack();
        for (int i = 0; i < stacks.Length; i++)
        {
            List<string> tempList = [];
            while (stacks[i].Size > 0)
            {
                tempList.Add(stacks[i].Pop());
            }
            for (int l = 0; l < tempList.Count; l++)
            {
                stackConcat.Add(tempList[l]);
                stacks[i].Add(tempList[tempList.Count - 1 - l]);
            }
        }
        return stackConcat;
    }
}
