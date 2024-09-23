
namespace HomeWork_Basic_04;

internal class Stack
{
    protected class StackItem
    {
        public string? Value { get; set; }
        public StackItem? PreviousItem { get; set; }
    }

    public string? Top { get; private set; }
    public int Size { get; private set; }
    public Stack() { }

    private StackItem? _currentItem = null;
    public void Add(string stackItem)
    {
        var newItem = new StackItem
        {
            Value = stackItem,
            PreviousItem = _currentItem
        };
        _currentItem = newItem;           
        Top = stackItem;
        Size++;
    }

    public string? Pop()
    {
        if (Size == 0)
        {
            throw new NullReferenceException("Stack is empty!");
        }
        _currentItem = _currentItem?.PreviousItem;
        Top = _currentItem?.Value;
        Size--;
        return Top;
    }           
}
 

