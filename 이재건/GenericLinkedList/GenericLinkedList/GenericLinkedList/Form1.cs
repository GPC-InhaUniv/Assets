using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericLinkedList
{
    public partial class Form1 : Form
    {
        DList<int> list;

        public Form1()
        {
            InitializeComponent();
            list = new DList<int>();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            list.InsertNode((int)insertvalueUpDown.Value);
            LinkedListText.Clear();
            LinkedListText.AppendText(list.PrintHeadToTail());
            LinkedListText.Update();
            SetMaxValue();

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            LinkedListText.AppendText(list.DeleteAt((int)deletePositionUpdown.Value));
            LinkedListText.Update();
            SetMaxValue();

        }

        private void PrintNode_Click(object sender, EventArgs e)
        {
            LinkedListText.Clear();
            LinkedListText.AppendText(list.PrintHeadToTail());
            LinkedListText.Update();
        }

        private void insertAtbtn_Click(object sender, EventArgs e)
        {
            LinkedListText.AppendText(list.InsertAt((int)insertPostionUpDown.Value,(int)insertvalueUpDown.Value));
            LinkedListText.Update();
            SetMaxValue();
        }

        private void insertvalueUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
       
        private void SetMaxValue()
        {
            insertPostionUpDown.Maximum=DList<int>.listLength+1;
            deletePositionUpdown.Maximum = DList<int>.listLength+1;
        }
    }
}
