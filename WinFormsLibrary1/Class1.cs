using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class NumericBox : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == '\b')) e.Handled = true;
        }
    }
}
