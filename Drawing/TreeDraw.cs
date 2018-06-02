using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MyTree;

namespace Drawing
{
    public class TreeDraw
    {
        private int height;
        private int width;
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 1)
                    throw new ArgumentException();
                height = value;
                Draw();
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 1)
                    throw new ArgumentException();
                width = value;
                Draw();
            }
        }
        public IntTree Tree { get; set; }
        public Bitmap Image { get; set; }
        Graphics G;
        public TreeDraw(int width, int height, IntTree tree)
        {
            this.width = width;
            this.height = height;
            this.Tree = tree;
        }
        private List<int> GetLeftIndentDif(List<int> Widths)
        {
            List<int> LeftIndentDif = new List<int>();
            for (int i = 0; i < Widths.Count; i++)
            {
                LeftIndentDif.Add(Width / (Widths[i] + 1));
            }
            return LeftIndentDif;
        }
        public void Draw()
        {
            Image = new Bitmap(width, height);
            G = Graphics.FromImage(Image);
            if (Tree == null)
                return;
            List<int> Widths = Tree.GetWidth();
            List<int> LeftIndentDif = GetLeftIndentDif(Widths);
            int UpIndentDif = Height / (Widths.Count + 1);
            Queue<Node> LineQueue = new Queue<Node>();
            Queue<Node> NodeQueue = new Queue<Node>();
            LineQueue.Enqueue(Tree.Root);
            int level = 0;
            bool DrawNodes = false;
            int LeftIndent = 1, nextLeftindent = 1;
            while (DrawNodes||LineQueue.Count!=0)
            {
                if (DrawNodes)
                {
                    Node node = NodeQueue.Dequeue();
                    int R = Math.Min(UpIndentDif, LeftIndentDif[level]) / 4;
                    int MidX = LeftIndentDif[level] * LeftIndent++;
                    int MidY = UpIndentDif * (level + 1);
                    float t = 0;
                    string text = node.Value.ToString();
                    do
                    {
                        t += (float)0.2;
                    }
                    while (G.MeasureString(text, new Font("Microsoft Sans Serif", t)).Width < R);
                    //t -= (float)0.2;
                    G.FillEllipse(Brushes.Red, MidX - R, MidY - R, 2 * R, 2 * R);
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    G.DrawString(text, new Font("Microsoft Sans Serif", t), Brushes.Black, new Rectangle(MidX - R, MidY - R, 2 * R, 2 * R), sf);
                    if(LeftIndent == Widths[level]+1)
                    {
                        DrawNodes = false;
                        LeftIndent = 1;
                        level++;
                    }
                }
                else
                {
                    Node node = LineQueue.Dequeue();
                    for (int i = 0; i < node.nodes.Count; i++)
                    {
                        LineQueue.Enqueue(node.nodes[i]);
                        G.DrawLine(Pens.Black, LeftIndent * LeftIndentDif[level], (level + 1) * UpIndentDif, nextLeftindent++ * LeftIndentDif[level + 1], (level + 2) * UpIndentDif);
                    }
                    NodeQueue.Enqueue(node);
                    LeftIndent++;
                    if (LeftIndent == Widths[level]+1)
                    {
                        DrawNodes = true;
                        LeftIndent = 1;
                        nextLeftindent = 1;
                    }
                }
            }

        }
        public Node GetNodeOnDraw(int X, int Y)
        {
            if (Tree == null)
                return null;
            List<int> Widths = Tree.GetWidth();
            List<int> LeftIndentDif = GetLeftIndentDif(Widths);
            int UpIndentDif = Height / (Widths.Count + 1);
            Queue<Node> NodeQueue = new Queue<Node>();
            NodeQueue.Enqueue(Tree.Root);
            int level = 0, LeftIndent = 1;
            while (NodeQueue.Count!=0)
            {
                Node node = NodeQueue.Dequeue();
                int R = Math.Min(UpIndentDif, LeftIndentDif[level]) / 4;
                int MidX = LeftIndentDif[level] * LeftIndent++;
                int MidY = UpIndentDif * (level + 1);
                if (Math.Pow(MidX - X, 2) + Math.Pow(MidY - Y, 2) <= R * R)
                    return node;
                if (LeftIndent == Widths[level] + 1)
                {
                    LeftIndent = 1;
                    level++;
                }
                for (int i = 0; i < node.nodes.Count; i++)
                {
                    NodeQueue.Enqueue(node.nodes[i]);
                }
            }
            return null;
        }
    }
}
