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
    public partial class GaussElimination : Form
    {
        double[,] matrix = new double[3,4] ; /// = new double[3,4];
        double m21, m31, m32 , x1 , x2 , x3;
        public GaussElimination()
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
            step1.Rows.Clear();
            step1.Refresh();
            step2.Rows.Clear();
            step2.Refresh();
            step3.Rows.Clear();
            step3.Refresh();
            m21_label.Text = "m21 = ";
            m31_label.Text = "m21 = ";
            m32_label.Text = "m21 = ";
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
        private void calculate_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        matrix[i, j] = double.Parse(matrix_input.Rows[i].Cells[j].Value.ToString());
                    }
                }
                m21 = double.Parse(matrix_input.Rows[1].Cells[0].Value.ToString()) / double.Parse(matrix_input.Rows[0].Cells[0].Value.ToString());
                m31 = double.Parse(matrix_input.Rows[2].Cells[0].Value.ToString()) / double.Parse(matrix_input.Rows[0].Cells[0].Value.ToString());

                m21_label.Text = "m21 = " + Convert.ToString(m21);
                m31_label.Text = "m31 = " + Convert.ToString(m31);

                // E2 - (m21) E1 --> E2
                for (int i = 0; i < 4; i++)
                {
                    matrix[1, i] = matrix[1, i] - m21 * matrix[0, i];
                }
                print(step1, matrix, 3, 4);

                //E3 - (m31) E1 --> E3
                for (int i = 0; i < 4; i++)
                {
                    matrix[2, i] = matrix[2, i] - m31 * matrix[0, i];
                }
                print(step2, matrix, 3, 4);

                //E3 - (m32) E2 --> E3
                m32 = matrix[2, 1] / matrix[1, 1];
                m32_label.Text = "m32 = " + Convert.ToString(m32);
                for (int i = 0; i < 4; i++)
                {
                    matrix[2, i] = matrix[2, i] - m32 * matrix[1, i];
                }
                print(step3, matrix, 3, 4);

                // calculate x
                x3 = matrix[2, 3] / matrix[2, 2];
                x2 = ((matrix[1, 2] * x3 * -1) + matrix[1, 3]) / matrix[1, 1];
                x1 = ((matrix[0, 1] * x2 * -1) + (matrix[0, 2] * x3 * -1) + matrix[0, 3]) / matrix[0, 0];

                x1_label.Text = "X1 = " + Convert.ToString(x1);
                x2_label.Text = "X2 = " + Convert.ToString(x2);
                x3_label.Text = "X3 = " + Convert.ToString(x3);
            }


        }
    }
}
