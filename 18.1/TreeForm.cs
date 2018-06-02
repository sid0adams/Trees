using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyTree;
using Drawing;

namespace _18._1
{
    public partial class TreeForm : Form
    {
        IntTree tree;
        TreeDraw draw;
        public TreeForm()
        {
            InitializeComponent();
            tree = new IntTree();
        }

        private void TreeForm_Paint(object sender, PaintEventArgs e)
        {
            draw.Width = Width - 42;
            draw.Height = Height - 90;
            draw.Draw();
            e.Graphics.DrawImage(draw.Image, 12, 31);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tree = new IntTree(new List<string>(File.ReadLines(openFileDialog.FileName)));
                    draw.Tree = tree;
                    this.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("ошибка чтения", "Error");
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllLines(saveFileDialog.FileName, tree.GetWays());
                }
                catch (Exception)
                {
                    MessageBox.Show("ошибка записи", "Error");
                }
            }
        }

        Node SelectedNode;
        private void TreeForm_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                SelectedNode = draw.GetNodeOnDraw(e.X-12, e.Y-31);
                if(SelectedNode!=null)
                {
                    if(SelectedNode == tree.Root)
                    {
                        RemoveBtn.Enabled = false;
                        ChangeBtn.Enabled = false;
                    }
                    else
                    {
                        RemoveBtn.Enabled = true;
                        ChangeBtn.Enabled = true;
                    }
                    contextMenuStrip.Show(this,e.Location);
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Node parent = SelectedNode;
            List<int> BusyNumber = new List<int>();
            for (int i = 0; i < parent.nodes.Count; i++)
            {
                if (parent.nodes[i] != SelectedNode)
                    BusyNumber.Add(parent.nodes[i].Value);
            }
            NodeChange nodeChange = new NodeChange(BusyNumber, parent.nodes.Count+1);
            if (nodeChange.ShowDialog() == DialogResult.OK)
            {
                if (nodeChange.Index - 1 == parent.nodes.Count)
                    parent.nodes.Add(new Node(nodeChange.Value));
                else
                    parent.nodes.Insert(nodeChange.Index - 1, new Node(nodeChange.Value));
            }
            Refresh();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            Node parent = tree.FindeParent(SelectedNode, out int index);
            List<int> BusyNumber = new List<int>();
            for (int i = 0; i < parent.nodes.Count; i++)
            {
                if (parent.nodes[i] != SelectedNode)
                    BusyNumber.Add(parent.nodes[i].Value);
            }
            NodeChange nodeChange = new NodeChange(BusyNumber, parent.nodes.Count,index+1,SelectedNode.Value);
            if (nodeChange.ShowDialog() == DialogResult.OK)
            {
                SelectedNode.Value = nodeChange.Value;
                if(nodeChange.Index-1!=index)
                {
                    parent.nodes.Remove(SelectedNode);
                    parent.nodes.Insert(nodeChange.Index - 1, SelectedNode);
                }
            }
            Refresh();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            Node parent = tree.FindeParent(SelectedNode, out int index);
            parent.nodes.Remove(SelectedNode);
            Refresh();
        }

        private void TreeForm_Load(object sender, EventArgs e)
        {
            draw = new TreeDraw(Width, Height, tree);
        }
        
        private void TreeForm_ResizeEnd(object sender, EventArgs e)
        {
            Refresh();
        }

        private void TreeForm_Resize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void PrintFirstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tree.CheckOnBin())
            {
                string text = tree.ToTextFirst();
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ошибка записи", "Error");
                    }
                }
            }
            else
                MessageBox.Show("дерево не бинарное", "Error");
        }

        private void PrintSecondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tree.CheckOnBin())
            {
                string text = tree.ToTextSecond();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ошибка записи", "Error");
                    }
                }
            }
            else
                MessageBox.Show("дерево не бинарное", "Error");
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree = new IntTree();
            draw.Tree = tree;
            Refresh();
        }

        private void QuickInitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuickCreate quickCreate = new QuickCreate();
            if (quickCreate.ShowDialog() == DialogResult.OK)
            {
                tree = new IntTree(quickCreate.N, quickCreate.K,1,10);
                draw.Tree = tree;
                Refresh();
            }
        }
    }
}
