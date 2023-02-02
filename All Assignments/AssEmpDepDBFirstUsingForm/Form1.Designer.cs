namespace AssEmpDepDBFirstUsingForm
{
    partial class Form1
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
            this.lblEmployeeCount = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.btnShowEmployees = new System.Windows.Forms.Button();
            this.btnShowDepartments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmployeeDetails";
            // 
            // lblEmployeeCount
            // 
            this.lblEmployeeCount.AutoSize = true;
            this.lblEmployeeCount.Location = new System.Drawing.Point(38, 47);
            this.lblEmployeeCount.Name = "lblEmployeeCount";
            this.lblEmployeeCount.Size = new System.Drawing.Size(35, 13);
            this.lblEmployeeCount.TabIndex = 1;
            this.lblEmployeeCount.Text = "label2";
            this.lblEmployeeCount.Click += new System.EventHandler(this.lblEmployeeCount_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(38, 121);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(35, 13);
            this.lblSalary.TabIndex = 2;
            this.lblSalary.Text = "label3";
            this.lblSalary.Click += new System.EventHandler(this.lblSalary_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(350, 12);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(240, 150);
            this.dgvEmployees.TabIndex = 3;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(360, 191);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.Size = new System.Drawing.Size(240, 150);
            this.dgvDepartments.TabIndex = 4;
            this.dgvDepartments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartments_CellContentClick);
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.Location = new System.Drawing.Point(24, 218);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(113, 23);
            this.btnShowEmployees.TabIndex = 5;
            this.btnShowEmployees.Text = "Show Employees";
            this.btnShowEmployees.UseVisualStyleBackColor = true;
            this.btnShowEmployees.Click += new System.EventHandler(this.btnShowEmployees_Click);
            // 
            // btnShowDepartments
            // 
            this.btnShowDepartments.Location = new System.Drawing.Point(24, 302);
            this.btnShowDepartments.Name = "btnShowDepartments";
            this.btnShowDepartments.Size = new System.Drawing.Size(125, 23);
            this.btnShowDepartments.TabIndex = 6;
            this.btnShowDepartments.Text = "Show Departments";
            this.btnShowDepartments.UseVisualStyleBackColor = true;
            this.btnShowDepartments.Click += new System.EventHandler(this.btnShowDepartments_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowDepartments);
            this.Controls.Add(this.btnShowEmployees);
            this.Controls.Add(this.dgvDepartments);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblEmployeeCount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployeeCount;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Button btnShowEmployees;
        private System.Windows.Forms.Button btnShowDepartments;
    }
}

