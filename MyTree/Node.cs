using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{
    public class Node
    {
        #region base
        public int Value { get; set; }
        public List<Node> nodes = new List<Node>();
        public Node(int value) => Value = value;
        public void Add(int value) => nodes.Add(new Node(value));
        public void Add(Node node) => nodes.Add(node);
        public Node FindeParent(Node node, out int Index)
        {
            Index = nodes.IndexOf(node);
            if (Index != -1)
                return this;
            if (nodes.Count == 0)
                return null;
            for (int i = 0; i < nodes.Count; i++)
            {
                Node parent = nodes[i].FindeParent(node, out Index);
                if (Index != -1)
                    return parent;
            }
            return null;
        }
        private static Random rnd = new Random();
        public void Intit(int N, int K, int minValue, int maxValue)
        {
            if (N == 1)
                return;
            /*if (rnd == null)
                rnd = new Random();*/
            int t = 0;
            List<int> was = new List<int>();
            for (int i = 0; i < K; i++)
            {
                do
                {
                    t = rnd.Next(minValue, maxValue);
                } while (was.IndexOf(t) != -1);
                Add(i+1);
                was.Add(t);
            }
            for (int i = 0; i < K; i++)
                nodes[i].Intit(N - 1, K, minValue, maxValue);
        }
        #endregion
        #region ways
        public List<string> GetWays() => GetWays("");
        private List<string> GetWays(string PrewWay)
        {
            if (nodes.Count == 0)
                return new List<string> { PrewWay + Value.ToString() };
            List<string> list = new List<string>();
            for (int i = 0; i < nodes.Count; i++)
            {
                list.AddRange(nodes[i].GetWays(PrewWay + Value.ToString()));
            }
            return list;
        }
        public Node(List<string> ways)
        {
            List<string> WaysNew = new List<string>();
            for (int i = 0; i < ways.Count; i++)
            {
                WaysNew.Add(ways[i].Substring(1));
            }
            InitByWays(WaysNew);
        }
        private void InitByWays(List<string> ways)
        {
            if (ways.Count == 0 || ways[0].Length == 0)
                return;
            int t = ways[0][0];
            List<string> WaysNew = new List<string>() { ways[0].Substring(1) };
            bool check;
            for (int i = 1; i < ways.Count; i++)
            {
                if (ways[i][0] != t)
                {
                    check = true;
                    for (int j = 0; j < nodes.Count; j++)
                        if (nodes[j].Value == t - 48)
                        {
                            check = false;
                            break;
                        }
                    if (check)
                        nodes.Add(new Node(t - 48));
                    nodes[nodes.Count - 1].InitByWays(WaysNew);
                    t = ways[i][0];
                    WaysNew.Clear();
                    if (ways[i].Length != 1)
                        WaysNew.Add(ways[i].Substring(1));
                }
                else
                {
                    if (ways[i].Length != 1)
                        WaysNew.Add(ways[i].Substring(1));
                }
            }
            check = true;
            for (int j = 0; j < nodes.Count; j++)
                if (nodes[j].Value == t - 48)
                {
                    check = false;
                    break;
                }
            if (check)
                nodes.Add(new Node(t - 48));
            nodes[nodes.Count - 1].InitByWays(WaysNew);
        }
        #endregion
        #region forDraw
        public int GetHeight()
        {
            int t = 0;
            for (int i = 0; i < nodes.Count; i++)
            {
                int d = nodes[i].GetHeight();
                if (d > t) t = d;
            }
            return t + 1;
        }
        public List<int> GetWidth()
        {
            if (nodes.Count == 0)
                return null;
            List<int> list = new List<int> { nodes.Count };
            for (int i = 0; i < nodes.Count; i++)
            {
                List<int> down = nodes[i].GetWidth();
                if (down != null)
                    for (int j = 0; j < down.Count; j++)
                    {
                        if (j + 1 < list.Count)
                            list[j + 1] += down[j];
                        else
                            list.Add(down[j]);
                    }
            }
            return list;
        }
        #endregion
        #region BinTree
        public bool CheckOnBin()
        {
            if (nodes.Count > 2)
                return false;
            for (int i = 0; i < nodes.Count; i++)
                if (!nodes[i].CheckOnBin())
                    return false;
            return true;
        }
        public List<string> ToTextFirst()
        {
            StringBuilder sb = new StringBuilder();
            List<string> now = new List<string>();
            int width, l, r;
            switch (nodes.Count)
            {
                case 0:
                    return new List<string> { Value.ToString() };
                case 1:
                    List<string> down = nodes[0].ToTextFirst();
                    width = Math.Max(Value.ToString().Length, down[0].Length);
                    width += (width + 1) % 2;
                    r = (width - Value.ToString().Length) / 2;
                    l = width - r - Value.ToString().Length;
                    if (l > 0) sb.Append(' ', l);
                    sb.Append(Value);
                    if (r > 0) sb.Append(' ', r);
                    now.Add(sb.ToString());
                    sb.Clear();
                    l = (width - 1) / 2;
                    r = width - 1 - l;
                    if (l > 0) sb.Append(' ', l);
                    sb.Append('┃');
                    if (r > 0) sb.Append(' ', r);
                    now.Add(sb.ToString());
                    l = (width - down[0].Length) / 2;
                    r = width - l - down[0].Length;
                    if (r > 0)
                        for (int i = 0; i < down.Count; i++)
                        {
                            sb.Clear();
                            if (l > 0) sb.Append(' ', l);
                            sb.Append(down[i]);
                            if (r > 0) sb.Append(' ', r);
                        }
                    else now.AddRange(down);
                    break;
                case 2:
                    List<string> downL = nodes[0].ToTextFirst();
                    List<string> downR = nodes[1].ToTextFirst();
                    width = Math.Max(Value.ToString().Length, downL[0].Length+downR[0].Length+1);
                    width += (width + 1) % 2;
                    r = (width - Value.ToString().Length) / 2;
                    l = width - r - Value.ToString().Length;
                    if (l > 0) sb.Append(' ', l);
                    sb.Append(Value);
                    if (r > 0) sb.Append(' ', r);
                    now.Add(sb.ToString());
                    sb.Clear();
                    r = (width - downL[0].Length - downR[0].Length - 1)/2;
                    l = width - downL[0].Length - downR[0].Length - 1 - r;
                    sb.Append(' ', l+downL[0].Length/2);
                    sb.Append('┏');
                    sb.Append('━', width / 2 - l - downL[0].Length / 2 - 1);
                    sb.Append('┻');
                    sb.Append('━', width / 2 - r - downR[0].Length / 2 - 1);
                    sb.Append('┓');
                    sb.Append(' ', r + downR[0].Length / 2);
                    now.Add(sb.ToString());
                    r = (width - downR[0].Length - downL[0].Length - 1) / 2;
                    l = width - r - downR[0].Length - downL[0].Length - 1;
                    for (int i = 0; i < Math.Max(downL.Count, downR.Count); i++)
                    {
                        sb.Clear();
                        sb.Append(' ', l);
                        if (i < downL.Count)
                            sb.Append(downL[i]);
                        else
                            sb.Append(' ', downL[0].Length);
                        sb.Append(' ');
                        if (i < downR.Count)
                            sb.Append(downR[i]);
                        else
                            sb.Append(' ', downR[0].Length);
                        sb.Append(' ', r);
                        now.Add(sb.ToString());
                    }
                    break;
                default:
                    throw new InvalidOperationException();
            }
            return now;
        }
        public List<string> ToTextSecond()
        {
            List<string> now = new List<string>() { Value.ToString() };
            List<string> down;
            StringBuilder sb = new StringBuilder();
            switch (nodes.Count())
            {
                case 0:
                    return now;
                case 1:
                    down = nodes[0].ToTextSecond();
                    now.Add("└───" + down[0]);
                    for (int i = 1; i < down.Count; i++)
                        now.Add("    " + down[i]);
                    return now;
                case 2:
                    down = nodes[0].ToTextSecond();
                    now.Add("├───" + down[0]);
                    for (int i = 1; i < down.Count; i++)
                        now.Add("│   " + down[i]);
                    down = nodes[1].ToTextSecond();
                    now.Add("└───" + down[0]);
                    for (int i = 1; i < down.Count; i++)
                        now.Add("    " + down[i]);
                    return now;
                default:
                    throw new InvalidOperationException();
            }
        }
        #endregion
    }
}
