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
    public partial class LuDecomposition : Form
    {
        double[,] matrix = new double[3, 4];
        double[,] a = new double[3,3] ; 
        double m21, m31, m32 , x1 , x2 , x3 , c1 , c2 , c3;
        double[] b = new double[3];
        double[,] l = new double[3, 3];
        double[,] u = new double[3, 3];

        public LuDecomposition()
        {
            InitializeComponent();
        }
        private bool validation()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Convert.ToString( matrix_input.Rows[i].Cells[j].Value) == string.Empty)
                    {
                        MessageBox.Show("Please Input Valid Matrix", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix_input.Rows[i].Cells[j].Value = string.Empty;
                }
            }

            matrix_a.Rows.Clear();
            matrix_a.Refresh();

            matrix_u.Rows.Clear();
            matrix_u.Refresh();

            matrix_b.Rows.Clear();
            matrix_b.Refresh();

            matrix_l.Rows.Clear();
            matrix_l.Refresh();

            m21_label.Text = "m21 = ";
            m31_label.Text = "m21 = ";
            m32_label.Text = "m21 = ";

            x1_label.Text = "X1 = ";
            x2_label.Text = "X2 = ";
            x3_label.Text = "X3 = ";

            c1_label.Text = "C1 = ";
            c2_label.Text = "C2 = ";
            c3_label.Text = "C3 = ";
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Methods methods = new Methods();
            methods.Show();
            this.Hide();
        }

        private void LuDecomposition_Load(object sender, EventArgs e)
        {
            matrix_input.RowCount = 3;
            matrix_input.ColumnCount = 4;
            matrix_input.Rows[0].Cells[0].Selected = false;
        }
        private void copyMatrix( double[,] matrix1 , double[,] matrix2 )
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix1[i,j] = matrix2[i,j];
                }
            }
        }

        private void print(DataGridView dataGridView, double[,] matrix, int numberOfRows, int numberOfCells)
        {
            dataGridView.RowCount = numberOfRows;
            dataGridView.ColumnCount = numberOfCells;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
            dataGridView.ClearSelection();
        }

        private void print(DataGridView dataGridView, double[] matrix, int numberOfRows, int numberOfCells)
        {
            dataGridView.RowCount = numberOfRows;
            dataGridView.ColumnCount = numberOfCells;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                dataGridView.Rows[i].Cells[0].Value = Convert.ToString(matrix[i]);
                
            }
        }


        private void calculate_Click(object sender, EventArgs e)
        {
            if(validation())
            {
                // Calculate A
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        a[i,j] =  double.Parse(matrix_input.Rows[i].Cells[j].Value.ToString());
                    }
                }
                print(matrix_a, a, 3, 3);

                // Calculte b
                for (int i = 0; i < 3; i++)
                {
                    b[i] = double.Parse(matrix_input.Rows[i].Cells[3].Value.ToString());
                }
                print(matrix_b, b, 3, 1);
                

                m21 = double.Parse(matrix_input.Rows[1].Cells[0].Value.ToString()) / double.Parse(matrix_input.Rows[0].Cells[0].Value.ToString());
                m31 = double.Parse(matrix_input.Rows[2].Cells[0].Value.ToString()) / double.Parse(matrix_input.Rows[0].Cells[0].Value.ToString());
                m21_label.Text = "m21 = " + Convert.ToString(m21);
                m31_label.Text = "m31 = " + Convert.ToString(m31);

                // E2 - (m21) E1 --> E2
                for (int i = 0; i < 3; i++)
                {
                    a[1,i] = a[1,i] - m21 * a[0,i];
                }

                //E3 - (m31) E1 --> E3
                for (int i = 0; i < 3; i++)
                {
                    a[2,i] = a[2,i] - m31 * a[0,i];
                }

                //E3 - (m32) E2 --> E3   || U 
                m32 = a[2,1] / a[1,1];
                m32_label.Text = "m32 = " + Convert.ToString(m32);
                for (int i = 0; i < 3; i++)
                {
                    a[2,i] = a[2,i] - m32 * a[1,i];
                }
                copyMatrix(u, a);
                print(matrix_u, u, 3, 3);

                // Calculate L
                double[,] lCopy = { { 1 ,0 ,0} ,{ m21 , 1 , 0 } , { m31 , m32 , 1 } };
                copyMatrix(l, lCopy);
                print(matrix_l, l, 3, 3);

                // Calculate C      ,, LC= b
                c1 = b[0];
		        c2 = ((l[1,0] * c1 * -1) + b[1]) / l[1,1];
		        c3 = ((l[2,1] * c2 * -1) + (l[2,0] * c1 * -1) + b[2]) / l[2,2];
                c1_label.Text = "C1 = " + Convert.ToString(c1);
                c2_label.Text = "C2 = " + Convert.ToString(c2);
                c3_label.Text = "C3 = " + Convert.ToString(c3);

                //Calculate X      ,, ux = c
                x3 = c3 / u[2,2];
                x2 = ((u[1,2] * x3 * -1) + c2) / u[1,1];
                x1 = ((u[0,1] * x2 * -1) + (u[0,2] * x3 * -1) + c1) / u[0,0];
                x1_label.Text = "X1 = " + Convert.ToString(x1);
                x2_label.Text = "X2 = " + Convert.ToString(x2);
                x3_label.Text = "X3 = " + Convert.ToString(x3);
            }
            

        }
    }
}
