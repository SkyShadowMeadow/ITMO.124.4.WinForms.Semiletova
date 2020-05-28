using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLists
{
    public partial class TestLists : Form
    {
        public TestLists()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            membersList.Sorted = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(peopleList.Text.Length != 0)
            {
                membersList.Items.Add(peopleList.Text);
            }
            else
            {
                MessageBox.Show("Choose an object from the list or add yours");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while (membersList.CheckedIndices.Count > 0)
            {
                membersList.Items.RemoveAt(membersList.CheckedIndices[0]);
            }
        }
    }
}
