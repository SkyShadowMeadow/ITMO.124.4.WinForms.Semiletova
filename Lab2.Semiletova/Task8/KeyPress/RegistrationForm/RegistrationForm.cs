﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void checkExtension_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkExtension.Checked == true)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(16, 96);
                lbl.Size = new System.Drawing.Size(32, 23);
                lbl.Name = "labell1";
                lbl.TabIndex = 2;
                lbl.Text = "PIN2";
                groupBox1.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(96, 96);
                txt.Size = new System.Drawing.Size(184, 20);
                txt.Name = "textbox";
                txt.TabIndex = 1;
                txt.Text = "";
                groupBox1.Controls.Add(txt);
                txt.KeyPress += new
            System.Windows.Forms.KeyPressEventHandler(this.textPIN_KeyPress);
            }
            else 
            {
                int lcv;
                lcv = groupBox1.Controls.Count;
                while (lcv > 4)
                {
                    groupBox1.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }
            }
            
        }

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле Name не может содержать цифры");
                errorProvider8.SetError(textName, "Must be letter");
            }
        }

     

        private void textPIN_Validating(object sender, CancelEventArgs e)
        {
            if (textPIN.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textPIN.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле PIN не может содержать буквы");
                }
            }
        }

        
            private void textPIN_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Поле PIN не может содержать буквы");
                }
            }

        }
    }

