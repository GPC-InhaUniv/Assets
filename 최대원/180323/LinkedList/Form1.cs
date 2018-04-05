using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class Form1 : Form
    {
        Linked Link;

        public Form1()
        {
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            if(Link != null) { label1.Text = "Count : " + Link.Count; } 
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (Link == null)
            {
                Link = new Linked();
                textBox1.Text += "링크리스트 생성 성공!" + Environment.NewLine;
            }
            else textBox1.Text += "링크리스트가 이미 있습니다." + Environment.NewLine;
            Update();
        }

        private void btNodeAdd_Click(object sender, EventArgs e)
        {
            if(Link == null)
            {
                textBox1.Text += "생성된 링크 리스트가 없습니다!" + Environment.NewLine;
            }
            else
            {
                Link.NodeAdd(tBData.Text);
                textBox1.Text += "노드 추가 성공!" + Environment.NewLine;
            }
            Update();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btView_Click(object sender, EventArgs e)
        {
            if (Link == null)
            {
                textBox1.Text += "생성된 링크 리스트가 없습니다!" + Environment.NewLine;
            }
            else textBox1.Text += Link.NodeView();
            Update();
        }

        private void btNodeDel_Click(object sender, EventArgs e)
        {
            if (Link == null)
            {
                textBox1.Text += "생성된 링크 리스트가 없습니다!" + Environment.NewLine;
            }
            else
            {
                textBox1.Text += Link.NodeDel(tBData.Text) + Environment.NewLine;
            }
            Update();
        }
    }
}
