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
    public partial class NodeChange : Form
    {
        private List<int> BusyNumber;
        private int IndexCount;
        public int Index { get; set; }
        public int Value { get; set; }
        
        public NodeChange(List<int> busyNumber, int indexCount, int index = 0, int value = 0)
        {
            InitializeComponent();
            BusyNumber = busyNumber;
            IndexCount = indexCount;
            int min = 1, max = 9;
            while (busyNumber.IndexOf(min) != -1)
            {
                min++;
            }
            while (BusyNumber.IndexOf(max) != -1)
            {
                max--;
            }
            ValueBox.Minimum = min;
            ValueBox.Maximum = max;
            IndexBox.Maximum = IndexCount;
            if (value == 0)
                ValueBox.Value = min;
            else
                ValueBox.Value = value;
            if (index == 0)
                IndexBox.Value = IndexCount;
            else
                IndexBox.Value = index;
            Value = (int)ValueBox.Value;
            Index = (int)IndexBox.Value;
            valueBoxNeedChange = true;
        }

        bool valueBoxNeedChange = false;
        private void ValueBox_ValueChanged(object sender, EventArgs e)
        {
            if (!valueBoxNeedChange)
                return;
            valueBoxNeedChange = false;
            if (ValueBox.Value > Value)
            {
                do
                {
                    Value++;
                } while (BusyNumber.IndexOf(Value)!=-1);
            }
            else
            {
                do
                {
                    Value--;
                } while (BusyNumber.IndexOf(Value) != -1);
            }
            ValueBox.Value = Value;
            valueBoxNeedChange = true;
        }

        private void IndexBox_ValueChanged(object sender, EventArgs e) => Index = (int)IndexBox.Value;
    }
}
