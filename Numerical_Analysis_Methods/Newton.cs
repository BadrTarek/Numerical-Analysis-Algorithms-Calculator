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
    public partial class Newton : Form
    {
        public Newton()
        {
            InitializeComponent();
        }
        private bool validation()
        {
            if(function.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Error Please Input Polynomial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else if( xo_input.Text.ToString() == string.Empty )
            {
                MessageBox.Show("Error Please Input Xl", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } 
            else if (Error.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Error Please Input Error Percentage", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else
                return true;
            return true;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            function.Clear();
            xo_input.Clear();
            f_dash.Clear();
            Error.Clear();
            Root.Clear();
            dataGridView1.Rows.Clear();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Methods methods = new Methods();
            methods.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                double f(string x)
                {
                    string s = "f(x)=";
                    string ss = "x=";
                    Function fn = new Function(s + function.Text.ToString());
                    Argument a = new Argument(ss + x);
                    Expression e1 = new Expression("f(x)", fn, a);
                    return e1.calculate();
                }
                double fDash(string x)
                {
                    string s = "f(x)=";
                    string ss = "x=";
                    Function fn = new Function(s + f_dash.Text.ToString());
                    Argument a = new Argument(ss + x);
                    Expression e1 = new Expression("f(x)", fn, a);
                    return e1.calculate();
                }

                double iter = 0;
                double xiPlus1 = 0;
                double err = 100;
                do
                {
                    if(iter == 0)
                    {
                        dataGridView1.Rows.Add(iter.ToString(), xo_input.Text, f(xo_input.Text), fDash(xo_input.Text)
                        , "-");
                    }else
                    {
                        dataGridView1.Rows.Add(iter.ToString(), xo_input.Text, f(xo_input.Text), fDash(xo_input.Text)
                        , err.ToString());
                    }
                    if (err < double.Parse(Error.Text))
                        break;
                    xiPlus1 = double.Parse(xo_input.Text) - (f(xo_input.Text) / fDash(xo_input.Text));
                    err = Math.Abs((xiPlus1 - double.Parse(xo_input.Text)) / xiPlus1) * 100;
                    xo_input.Text = xiPlus1.ToString();
                    iter++;
                } while (true);//while (err > double.Parse(Error.Text));
                Root.Text = xo_input.Text;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SimpleFixedPoint_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void function_TextChanged(object sender, EventArgs e)
        {

        }

        private void xo_input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
