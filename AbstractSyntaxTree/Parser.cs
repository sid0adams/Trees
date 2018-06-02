using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSyntaxTree
{
    public static class Parser
    {
        public static bool CheckBrace(char l, char r)
        {
            switch (l)
            {
                case '(':
                    if (r == ')')
                        return true;
                    else
                        return false;
                case '[':
                    if (r == ']')
                        return true;
                    else
                        return false;
                case '{':
                    if (r == '}')
                        return true;
                    else
                        return false;
                default:
                    return false;
            }
        }
        public static INode Parse(string str)
        {
            Stack<char> brace = new Stack<char>();
            int index = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '[' || str[i] == '{')
                    brace.Push(str[i]);
                else if (str[i] == ')' || str[i] == ']' || str[i] == '}')
                {
                    if (!CheckBrace(brace.Pop(), str[i]))
                        throw new Exception();
                }
                else if (brace.Count == 0 && (str[i] == '+' || str[i] == '-'))
                    index = i;
            }
            if(index!=-1)
                return new SignNode(Parse(str.Substring(0, index)), Parse(str.Substring(index + 1)), str[index] == '+' ? Sign.plus : Sign.minus);
            index = -1;
            if (brace.Count != 0)
                throw new Exception();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '[' || str[i] == '{')
                    brace.Push(str[i]);
                else if (str[i] == ')' || str[i] == ']' || str[i] == '}')
                {
                    if (!CheckBrace(brace.Pop(), str[i]))
                        throw new Exception();
                }
                else if (brace.Count == 0 && (str[i] == '*' || str[i] == '/'))
                    index = i;
            }
            if(index != -1)
                return new SignNode(Parse(str.Substring(0, index)), Parse(str.Substring(index + 1)), str[index] == '*' ? Sign.multiply : Sign.divide);
            int left = -1, right = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '[' || str[i] == '{')
                {
                    if (left == -1)
                        left = i + 1;
                }
                if (str[i] == ')' || str[i] == ']' || str[i] == '}')
                {
                    right = i;
                }
                if (str[i] != '(' && str[i] != '[' && str[i] != '{' && str[i] != ')' && str[i] != ']' && str[i] != '}' && str[i] != ' ' && left == -1)
                {
                    break;
                }
            }
            if(left!=-1)
            return Parse(str.Substring(left, right - left));
            return new NumberNode(double.Parse(str));
        }
    }
}
