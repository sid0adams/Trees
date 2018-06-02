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
    public partial class QuickCreate : Form
    {
        public QuickCreate()
        {
            InitializeComponent();
        }
        public int N { get; private set; }
        public int K { get; private set; }
        private void OkBtn_Click(object sender, EventArgs e)
        {
            N = (int)GetN.Value;
            K = (int)GetK.Value;
        }
    }
}
