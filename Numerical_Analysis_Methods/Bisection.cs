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
    public partial class Bisection : Form
    {
        public Bisection()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Function_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool validation()
        {
            if(function.Text.ToString() == string.Empty)
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
                return true;
        }
        private void start_Click(object sender, EventArgs e)
        {
           if(validation())
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

                double iter = 0;
                double xr = 0;
                double xrOld = 0;
                double err = 0;
                do
                {
                    xrOld = xr;
                    xr = (double.Parse(xl_input.Text) + double.Parse(xu_input.Text)) / 2;
                    err = Math.Abs((xr - xrOld) / xr) * 100;
                    if(iter==0)
                    {
                        dataGridView1.Rows.Add(iter.ToString(), xl_input.Text, f(xl_input.Text).ToString(), xu_input.Text
                        , f(xu_input.Text).ToString(), xr.ToString(), f(xr.ToString()), "-");
                    }
                    else
                    {
                        dataGridView1.Rows.Add(iter.ToString(), xl_input.Text, f(xl_input.Text).ToString(), xu_input.Text
                        , f(xu_input.Text).ToString(), xr.ToString(), f(xr.ToString()), err.ToString());
                    }
                    
                    if (f(xl_input.Text) * f(xr.ToString()) < 0)
                    {
                        xu_input.Text = xr.ToString();
                    }
                    else
                    {
                        xl_input.Text = xr.ToString();
                    }
                    iter++;
                } while (err > double.Parse(Error.Text));
                Root.Text = xr.ToString();
            }
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            function.Clear();
            xl_input.Clear();
            xu_input.Clear();
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
    }
}
