namespace AssignmentEachDisplayDepartmentAllEmployees
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowDepartments = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowEmployees = new System.Windows.Forms.Button();
            this.lblEmployeeCount = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(223, 2);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(526, 150);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(274, 155);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.Size = new System.Drawing.Size(434, 150);
            this.dgvDepartments.TabIndex = 1;
            this.dgvDepartments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartments_CellContentClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(55, 129);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowDepartments
            // 
            this.btnShowDepartments.Location = new System.Drawing.Point(46, 237);
            this.btnShowDepartments.Name = "btnShowDepartments";
            this.btnShowDepartments.Size = new System.Drawing.Size(153, 23);
            this.btnShowDepartments.TabIndex = 3;
            this.btnShowDepartments.Text = "Show Departments";
            this.btnShowDepartments.UseVisualStyleBackColor = true;
            this.btnShowDepartments.Click += new System.EventHandler(this.btnShowDepartments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "EmployeeDetails";
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.Location = new System.Drawing.Point(46, 182);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(144, 23);
            this.btnShowEmployees.TabIndex = 5;
            this.btnShowEmployees.Text = "Show Employees";
            this.btnShowEmployees.UseVisualStyleBackColor = true;
            this.btnShowEmployees.Click += new System.EventHandler(this.btnShowEmployees_Click);
            // 
            // lblEmployeeCount
            // 
            this.lblEmployeeCount.AutoSize = true;
            this.lblEmployeeCount.Location = new System.Drawing.Point(24, 50);
            this.lblEmployeeCount.Name = "lblEmployeeCount";
            this.lblEmployeeCount.Size = new System.Drawing.Size(35, 13);
            this.lblEmployeeCount.TabIndex = 6;
            this.lblEmployeeCount.Text = "label2";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(24, 93);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(35, 13);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "label3";
            this.lblSalary.Click += new System.EventHandler(this.lblSalary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblEmployeeCount);
            this.Controls.Add(this.btnShowEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowDepartments);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvDepartments);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowDepartments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowEmployees;
        private System.Windows.Forms.Label lblEmployeeCount;
        private System.Windows.Forms.Label lblSalary;
    }
}

