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
    public partial class Cramer : Form
    {
        double[,] matrix = new double[3,4] ;
        double   a1 , a2 , a3 ,a;
        public Cramer()
        {
            InitializeComponent();
        }
        private bool validation()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Convert.ToString(matrix_input.Rows[i].Cells[j].Value) == string.Empty)
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
            a_matrix.Rows.Clear();
            a_matrix.Refresh();
            a1_matrix.Rows.Clear();
            a1_matrix.Refresh();
            a2_matrix.Rows.Clear();
            a2_matrix.Refresh();
            a3_matrix.Rows.Clear();
            a3_matrix.Refresh();
            a1_label.Text = "A1 = ";
            a2_label.Text = "A2 = ";
            a3_label.Text = "A3 = ";
            x1_label.Text = "X1 = ";
            x2_label.Text = "X2 = ";
            x3_label.Text = "X3 = ";
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Methods methods = new Methods();
            methods.Show();
            this.Hide();
        }

        private void GaussElimination_Load(object sender, EventArgs e)
        {
            matrix_input.RowCount = 3;
            matrix_input.ColumnCount = 4;
            matrix_input.Rows[0].Cells[0].Selected = false;
        }
        private void copyMatrix(double[,] matrix1, double[,] matrix2)
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix1[i, j] = matrix2[i, j];
                }
            }
        }

        private void print(DataGridView dataGridView , double[,] matrix , int numberOfRows , int numberOfCells)
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
        private double det( double[,] matrix) {
            double det=0;
            for (int i = 0; i < 3; i++) { 
                det += (matrix[0, i] * (matrix[1, (i + 1) % 3] * matrix[2, (i + 2) % 3] - matrix[1, (i + 2) % 3] * matrix[2, (i + 1) % 3]));
            }
            return det;
        }
        private void calculate_Click(object sender, EventArgs e)
        {
            if(validation())
            {
                double[] b = new double[3];
                double[,] a_matrix_v = new double[3, 3];
                double[,] a1_matrix_v = new double[3, 3];
                double[,] a2_matrix_v = new double[3, 3];
                double[,] a3_matrix_v = new double[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        matrix[i,j] =  double.Parse(matrix_input.Rows[i].Cells[j].Value.ToString());
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    b[i] = double.Parse(matrix_input.Rows[i].Cells[3].Value.ToString());
                }

                //calculate A
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        a_matrix_v[i, j] = matrix[i, j];
                    }
                }
                a = det(a_matrix_v);
                a_label.Text = "A = " + Convert.ToString(a);
                print(a_matrix, a_matrix_v, 3, 3);

                // Calcualte A1
                copyMatrix(a1_matrix_v, a_matrix_v);
                for(int i = 0; i < 3; i++)
                {
                    a1_matrix_v[i, 0] = b[i];
                }
                a1 = det(a1_matrix_v);
                a1_label.Text = "A1 = " + Convert.ToString(a1);
                print(a1_matrix, a1_matrix_v,3,3);

                // Calcualte A2
                copyMatrix(a2_matrix_v, a_matrix_v);
                for (int i = 0; i < 3; i++)
                {
                    a2_matrix_v[i, 1] = b[i];
                }
                a2 = det(a2_matrix_v);
                a2_label.Text = "A2 = " + Convert.ToString(a2);
                print(a2_matrix, a2_matrix_v, 3, 3);

                // Calcualte A3
                copyMatrix(a3_matrix_v, a_matrix_v);
                for (int i = 0; i < 3; i++)
                {
                    a3_matrix_v[i, 2] = b[i];
                }
                a3 = det(a3_matrix_v);
                a3_label.Text = "A3 = " + Convert.ToString(a3);
                print(a3_matrix, a3_matrix_v, 3, 3);

                x1_label.Text = "X1 = " + Convert.ToString(a1 / a);
                x2_label.Text = "X2 = " + Convert.ToString(a2 / a);
                x3_label.Text = "X3 = " + Convert.ToString(a3 / a);
            }
            

        }
    }
}
