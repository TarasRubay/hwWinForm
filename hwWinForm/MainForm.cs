using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hwWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            NumericBox numericBox = new NumericBox();
            numericBox.Parent = this;
            this.Controls.Add(numericBox);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
         
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            listBox1.Items.Add($"{e.KeyCode} {e.Control} {e.Handled}");
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            listBox1.Items.Add($"{e.KeyChar}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' && e.KeyChar > '9' || e.KeyChar != '\b') e.Handled = true;
            
        }
    }
    //public class NumericBox : TextBox
    //{
    //    protected override void OnKeyPress(KeyPressEventArgs e)
    //    {
    //        base.OnKeyPress(e);
    //        if(!(char.IsDigit(e.KeyChar) || e.KeyChar == '\b')) e.Handled = true;
    //    }
    //}
}
