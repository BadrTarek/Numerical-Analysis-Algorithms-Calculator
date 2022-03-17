
namespace Numerical_Analysis_Methods
{
    partial class Methods
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
            this.bisection = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.secant = new System.Windows.Forms.Button();
            this.simple_fixed = new System.Windows.Forms.Button();
            this.newton = new System.Windows.Forms.Button();
            this.false_position = new System.Windows.Forms.Button();
            this.cramer = new System.Windows.Forms.Button();
            this.lu_decomposition = new System.Windows.Forms.Button();
            this.gauss_elimination = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numerical Analysis";
            // 
            // bisection
            // 
            this.bisection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bisection.Location = new System.Drawing.Point(168, 53);
            this.bisection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bisection.Name = "bisection";
            this.bisection.Size = new System.Drawing.Size(251, 50);
            this.bisection.TabIndex = 5;
            this.bisection.Text = "Bisection";
            this.bisection.UseVisualStyleBackColor = true;
            this.bisection.Click += new System.EventHandler(this.bisection_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.secant);
            this.panel1.Controls.Add(this.simple_fixed);
            this.panel1.Controls.Add(this.newton);
            this.panel1.Controls.Add(this.false_position);
            this.panel1.Controls.Add(this.cramer);
            this.panel1.Controls.Add(this.lu_decomposition);
            this.panel1.Controls.Add(this.gauss_elimination);
            this.panel1.Controls.Add(this.bisection);
            this.panel1.Location = new System.Drawing.Point(188, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 426);
            this.panel1.TabIndex = 12;
            // 
            // secant
            // 
            this.secant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secant.Location = new System.Drawing.Point(449, 53);
            this.secant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secant.Name = "secant";
            this.secant.Size = new System.Drawing.Size(251, 50);
            this.secant.TabIndex = 12;
            this.secant.Text = "Secant";
            this.secant.UseVisualStyleBackColor = true;
            this.secant.Click += new System.EventHandler(this.secant_Click);
            // 
            // simple_fixed
            // 
            this.simple_fixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simple_fixed.Location = new System.Drawing.Point(168, 233);
            this.simple_fixed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simple_fixed.Name = "simple_fixed";
            this.simple_fixed.Size = new System.Drawing.Size(251, 50);
            this.simple_fixed.TabIndex = 11;
            this.simple_fixed.Text = "Simple Fixed";
            this.simple_fixed.UseVisualStyleBackColor = true;
            this.simple_fixed.Click += new System.EventHandler(this.simple_fixed_Click);
            // 
            // newton
            // 
            this.newton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newton.Location = new System.Drawing.Point(168, 323);
            this.newton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newton.Name = "newton";
            this.newton.Size = new System.Drawing.Size(251, 50);
            this.newton.TabIndex = 10;
            this.newton.Text = "Newton";
            this.newton.UseVisualStyleBackColor = true;
            this.newton.Click += new System.EventHandler(this.newton_Click);
            // 
            // false_position
            // 
            this.false_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.false_position.Location = new System.Drawing.Point(168, 143);
            this.false_position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.false_position.Name = "false_position";
            this.false_position.Size = new System.Drawing.Size(251, 50);
            this.false_position.TabIndex = 9;
            this.false_position.Text = "False Position";
            this.false_position.UseVisualStyleBackColor = true;
            this.false_position.Click += new System.EventHandler(this.false_position_Click);
            // 
            // cramer
            // 
            this.cramer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cramer.Location = new System.Drawing.Point(449, 323);
            this.cramer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cramer.Name = "cramer";
            this.cramer.Size = new System.Drawing.Size(251, 50);
            this.cramer.TabIndex = 8;
            this.cramer.Text = "Cramer Rule";
            this.cramer.UseVisualStyleBackColor = true;
            this.cramer.Click += new System.EventHandler(this.cramer_Click);
            // 
            // lu_decomposition
            // 
            this.lu_decomposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lu_decomposition.Location = new System.Drawing.Point(449, 233);
            this.lu_decomposition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lu_decomposition.Name = "lu_decomposition";
            this.lu_decomposition.Size = new System.Drawing.Size(251, 50);
            this.lu_decomposition.TabIndex = 7;
            this.lu_decomposition.Text = "Lu Decomposition";
            this.lu_decomposition.UseVisualStyleBackColor = true;
            this.lu_decomposition.Click += new System.EventHandler(this.lu_decomposition_Click);
            // 
            // gauss_elimination
            // 
            this.gauss_elimination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauss_elimination.Location = new System.Drawing.Point(449, 143);
            this.gauss_elimination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gauss_elimination.Name = "gauss_elimination";
            this.gauss_elimination.Size = new System.Drawing.Size(251, 50);
            this.gauss_elimination.TabIndex = 6;
            this.gauss_elimination.Text = "Gauss Elimination";
            this.gauss_elimination.UseVisualStyleBackColor = true;
            this.gauss_elimination.Click += new System.EventHandler(this.gauss_elimination_Click);
            // 
            // Methods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Methods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bisection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button secant;
        private System.Windows.Forms.Button simple_fixed;
        private System.Windows.Forms.Button newton;
        private System.Windows.Forms.Button false_position;
        private System.Windows.Forms.Button cramer;
        private System.Windows.Forms.Button lu_decomposition;
        private System.Windows.Forms.Button gauss_elimination;
    }
}