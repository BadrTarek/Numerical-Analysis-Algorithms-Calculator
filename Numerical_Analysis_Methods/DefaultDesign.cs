using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;


namespace Numerical_Analysis_Methods
{
    public partial class DefaultDesign : Form
    {
        public DefaultDesign()
        {
            InitializeComponent();
        }
        private bool validation()
        {
            /*if(function.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Error Please Input Polynomial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else if( xl_input.Text.ToString() == string.Empty )
            {
                MessageBox.Show("Error Please Input Xl", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else if (xu_input.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Error Please Input Xu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Error.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Error Please Input Error Percentage", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else
                return true;*/
            return true;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            /*function.Clear();
            xl_input.Clear();
            xu_input.Clear();
            Error.Clear();
            Root.Clear();*/
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Methods methods = new Methods();
            methods.Show();
            this.Hide();
        }
    }
}
