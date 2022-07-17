using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NicClass;

namespace NICpersonDetails
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtGender.Clear();
            txtNic.Clear();
            txtDate.Clear();
            txtVote.Clear();
        }

        private void btnNext_KeyDown(object sender, KeyEventArgs e)
        {
         if(e.KeyCode == Keys.Enter)
            {
                btnNext.PerformClick();
            }
        }

        private void txtNic_KeyDown(object sender, KeyEventArgs e)
        {
            int iclength = txtNic.Text.Length;
            string ic = txtNic.Text;
            int GenCheck;
            string year;
            NicClass.Class1 ob1 = new NicClass.Class1();
            if(e.KeyCode == Keys.Enter)
            {
                btnNext.Enabled = true;
                {
                    if(iclength==10)
                    {
                        GenCheck = Convert.ToInt32(ic.Substring(2, 3));
                        txtGender.Text = ob1.CheckGender(GenCheck);
                        txtVote.Text = ob1.Vote(ic);
                        year = "19" + ic.Substring(0, 2);
                        txtDate.Text = year + "." + ob1.DateofBirth(GenCheck);
                    }
                    else if (iclength ==12)
                    {
                        GenCheck = Convert.ToInt32(ic.Substring(4, 3));
                        txtGender.Text = ob1.CheckGender(GenCheck);
                        txtVote.Text = ob1.Vote(ic);
                        year = ic.Substring(0, 4);
                        txtDate.Text = year + "." + ob1.DateofBirth(GenCheck);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Nic");
                        txtNic.Clear();
                    }
                }
            }
        }
    }
}
