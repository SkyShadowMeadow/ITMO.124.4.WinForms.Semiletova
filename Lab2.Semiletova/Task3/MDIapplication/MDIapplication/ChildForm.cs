using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIapplication
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void childWindowMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toggleMenuItem_Click(object sender, EventArgs e)
        {
            if (toggleMenuItem.Checked)
            {
                toggleMenuItem.Checked = false;
                ChildTextBox.ForeColor = System.Drawing.Color.Black; 
            }
            else
            {
                toggleMenuItem.Checked = true;
                ChildTextBox.ForeColor = System.Drawing.Color.Blue;
            }

        }

        private void ChildTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
