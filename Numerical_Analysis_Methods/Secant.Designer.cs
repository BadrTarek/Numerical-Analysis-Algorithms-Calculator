
namespace Numerical_Analysis_Methods
{
    partial class Secant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.function = new System.Windows.Forms.TextBox();
            this.Root = new System.Windows.Forms.TextBox();
            this.Error = new System.Windows.Forms.TextBox();
            this.xminus1_input = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.xi_input = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iterations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fXi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.back_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secant Method";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "f(x) =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "xi-1 =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Root =";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(363, 103);
            this.start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(117, 50);
            this.start.TabIndex = 5;
            this.start.Text = "Calculate";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Error =";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // function
            // 
            this.function.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.function.Location = new System.Drawing.Point(97, 11);
            this.function.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(383, 30);
            this.function.TabIndex = 7;
            this.function.TextChanged += new System.EventHandler(this.function_TextChanged);
            // 
            // Root
            // 
            this.Root.Enabled = false;
            this.Root.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Root.Location = new System.Drawing.Point(75, 20);
            this.Root.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(179, 30);
            this.Root.TabIndex = 8;
            // 
            // Error
            // 
            this.Error.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.Location = new System.Drawing.Point(97, 149);
            this.Error.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(105, 30);
            this.Error.TabIndex = 9;
            // 
            // xminus1_input
            // 
            this.xminus1_input.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xminus1_input.Location = new System.Drawing.Point(97, 57);
            this.xminus1_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xminus1_input.Name = "xminus1_input";
            this.xminus1_input.Size = new System.Drawing.Size(109, 30);
            this.xminus1_input.TabIndex = 11;
            this.xminus1_input.TextChanged += new System.EventHandler(this.xo_input_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.xi_input);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.Error);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.xminus1_input);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.function);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(67, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 443);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "xi =";
            // 
            // xi_input
            // 
            this.xi_input.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xi_input.Location = new System.Drawing.Point(97, 103);
            this.xi_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xi_input.Name = "xi_input";
            this.xi_input.Size = new System.Drawing.Size(105, 30);
            this.xi_input.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iterations,
            this.cul,
            this.fXi,
            this.dd,
            this.value,
            this.error_value});
            this.dataGridView1.Location = new System.Drawing.Point(10, 189);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1127, 240);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iterations
            // 
            this.iterations.HeaderText = "i";
            this.iterations.MinimumWidth = 8;
            this.iterations.Name = "iterations";
            this.iterations.Width = 150;
            // 
            // cul
            // 
            this.cul.HeaderText = "xi-1";
            this.cul.MinimumWidth = 8;
            this.cul.Name = "cul";
            this.cul.Width = 150;
            // 
            // fXi
            // 
            this.fXi.HeaderText = "f(xi-1)";
            this.fXi.MinimumWidth = 8;
            this.fXi.Name = "fXi";
            this.fXi.Width = 150;
            // 
            // dd
            // 
            this.dd.HeaderText = "xi";
            this.dd.MinimumWidth = 8;
            this.dd.Name = "dd";
            this.dd.Width = 150;
            // 
            // value
            // 
            this.value.HeaderText = "f(xi)";
            this.value.MinimumWidth = 8;
            this.value.Name = "value";
            this.value.Width = 150;
            // 
            // error_value
            // 
            this.error_value.HeaderText = "Error";
            this.error_value.MinimumWidth = 8;
            this.error_value.Name = "error_value";
            this.error_value.Width = 150;
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(231, 104);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(114, 50);
            this.reset.TabIndex = 13;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Root);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(649, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 65);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(1135, 583);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(78, 39);
            this.back_button.TabIndex = 14;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Secant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 652);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Secant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secant";
            this.Load += new System.EventHandler(this.SimpleFixedPoint_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox function;
        private System.Windows.Forms.TextBox Root;
        private System.Windows.Forms.TextBox Error;
        private System.Windows.Forms.TextBox xminus1_input;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox xi_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn iterations;
        private System.Windows.Forms.DataGridViewTextBoxColumn cul;
        private System.Windows.Forms.DataGridViewTextBoxColumn fXi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dd;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn error_value;
    }
}