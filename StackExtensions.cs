namespace HomeWork_Basic_04;

internal static class StackExtensions
{
    public static void Merge(this Stack stask, Stack mergeStack)
    {
        List<string> tempList = [];
        while (mergeStack.Size > 0)
        {
            tempList.Add(mergeStack.Pop ());
        }            
        for (int i = 0; i < tempList.Count; i++) 
        {
            stask.Add(tempList[i]);
            mergeStack.Add (tempList[tempList.Count - i - 1]);
        }
    }        
}
