using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{
    public class IntTree
    {
        public Node Root = new Node(0);
        public int GetHeight() => Root.GetHeight();

        public List<int> GetWidth()
        {
            List<int> widths = new List<int>();
            widths.Add(1);
            List<int> T = Root.GetWidth();
            if (T != null)
                widths.AddRange(T);
            return widths;
        }

        public IntTree() { }
        public IntTree(List<string> ways) => Root = new Node(ways);
        public IntTree(int N, int K, int minValue, int maxValue) => Root.Intit(N, K, minValue, maxValue);
        public List<string> GetWays() => Root.GetWays();
        public Node FindeParent(Node node, out int Index) => Root.FindeParent(node, out Index);
        public bool CheckOnBin() => Root.CheckOnBin();
        public string ToTextFirst() => string.Join("\r\n", Root.ToTextFirst());
        public string ToTextSecond() => string.Join("\r\n", Root.ToTextSecond());
    }
}
