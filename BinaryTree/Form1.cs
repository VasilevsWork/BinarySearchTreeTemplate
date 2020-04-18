using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyTree tree = new MyTree();

        private void btn_Add_Click(object sender, EventArgs e)
        {
            tree.Add(Convert.ToInt32(tb_Add.Text));
            tb_Show.Text = tree.Show();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {

        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {

        }
    }
}
