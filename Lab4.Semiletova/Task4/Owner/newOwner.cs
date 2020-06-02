using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owner
{
    public partial class newOwner : Form
    {
        public newOwner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string together = textBoxF21.Text + " " + textBoxF22.Text + " " + textBoxF23.Text;
            Owner owner = this.Owner as Owner;
            if (owner != null)
            {
                owner.SolData = together;
            }
            this.Close();
        }
    }
}
