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
    public partial class Methods : Form
    {
        public Methods()
        {
            InitializeComponent();
        }
       

       

        private void gauss_elimination_Click(object sender, EventArgs e)
        {
            GaussElimination gaussElimination = new GaussElimination();
            gaussElimination.Show();
            this.Hide();
        }

        private void lu_decomposition_Click(object sender, EventArgs e)
        {
            LuDecomposition luDecomposition = new LuDecomposition();
            luDecomposition.Show();
            this.Hide();
        }

        private void cramer_Click(object sender, EventArgs e)
        {
            Cramer cramer = new Cramer();
            cramer.Show();
            this.Hide();
        }

        private void bisection_Click(object sender, EventArgs e)
        {
            Bisection bisection = new Bisection();
            bisection.Show();
            this.Hide();
        }

        private void false_position_Click(object sender, EventArgs e)
        {
            FalsePosition falsePosition = new FalsePosition();
            falsePosition.Show();
            this.Hide();
        }

        private void simple_fixed_Click(object sender, EventArgs e)
        {
            SimpleFixedPoint simpleFixedPoint = new SimpleFixedPoint();
            simpleFixedPoint.Show();
            this.Hide();
        }

        private void newton_Click(object sender, EventArgs e)
        {
            Newton newton = new Newton();
            newton.Show();
            this.Hide();
        }

        private void secant_Click(object sender, EventArgs e)
        {
            Secant secant = new Secant();
            secant.Show();
            this.Hide();
        }
    }
}
