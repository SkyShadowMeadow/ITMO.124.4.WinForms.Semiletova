using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owner
{
    public partial class Owner : Form
    {
        public string SolData
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        public Owner()
        {
            InitializeComponent();
        }

        private void Owner_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                newOwner newOwner = new newOwner();
                newOwner.Show(this);

        }
    }
}
