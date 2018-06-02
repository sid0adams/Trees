using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _18._1
{
    public partial class SyntacticAnalysisForm : Form
    {
        public SyntacticAnalysisForm()
        {
            InitializeComponent();
        }

        private void Input_TextChanged(object sender, EventArgs e)
         {
            try
            {
                AbstractSyntaxTree.INode node = AbstractSyntaxTree.Parser.Parse(Input.Text);
                Output.Text = "= " + node.Value;
            }
            catch(DivideByZeroException)
            {
                Output.Text = "деление на 0";
            }
            catch (Exception)
            {
                Output.Text = "";
            }
        }
    }
}
