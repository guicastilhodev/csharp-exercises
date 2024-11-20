string expression = "a+b * (c+d)]";

Console.WriteLine(IsBalanced(expression));



static Boolean IsBalanced(string expression)
{
    Stack<char> parenteses = new Stack<char>();
    foreach (char c in expression)
    {
        if (c == '(' || c == '{' || c == '[')
        {
            parenteses.Push(c);
        }
        else if (c == ')' || c == '}' || c == ']')
        {
            if (parenteses.Count == 0)
            {
                return false;
            }

            char topo = parenteses.Pop();
            if ((topo == '(' && c != ')') || (topo == '{' && c != '}') || (topo == '[' && c != ']'))
            {
                return false;
            }
        }
    }
    return parenteses.Count == 0;
}