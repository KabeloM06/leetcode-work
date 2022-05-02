public class Solution {
    
    private static Dictionary<string, string> SymbolMapping = 
        new Dictionary<string, string>()
        {
            { ")", "(" }, { "}", "{" }, { "]", "[" }
        };
    
    public bool IsValid(string s) {
        var symbolChars = s.ToCharArray();
        var temp = new Stack<string>();
        foreach(var symbolChar in symbolChars)
        {
            var symbol = symbolChar.ToString();
            if (SymbolMapping.ContainsKey(symbol))
            {
                var bracket = SymbolMapping[symbol];
                if (IsStackEmpty(temp) || temp.Pop() != bracket) return false;
            }
            else
            {
                temp.Push(symbol);
            }
        }
        return IsStackEmpty(temp);
    }
    
    private bool IsStackEmpty(Stack<string> stack)
    {
        return (stack.Count == 0);
    }
}