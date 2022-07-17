using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nictext
{
    public partial class Nictext: TextBox
    {
        public Nictext()
        {
            BackColor = Color.DimGray;
            ForeColor = Color.White;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == 'V' || e.KeyChar == 'X')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
