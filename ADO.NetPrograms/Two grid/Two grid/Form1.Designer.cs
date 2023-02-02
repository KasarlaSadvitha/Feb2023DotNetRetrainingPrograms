namespace Two_grid
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowDepartments = new System.Windows.Forms.Button();
            this.btnShowEmployees = new System.Windows.Forms.Button();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmployeeCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnShowDepartments
            // 
            this.btnShowDepartments.Location = new System.Drawing.Point(650, 251);
            this.btnShowDepartments.Name = "btnShowDepartments";
            this.btnShowDepartments.Size = new System.Drawing.Size(75, 23);
            this.btnShowDepartments.TabIndex = 1;
            this.btnShowDepartments.Text = "ShowDept";
            this.btnShowDepartments.UseVisualStyleBackColor = true;
            this.btnShowDepartments.Click += new System.EventHandler(this.btnShowDepartments_Click);
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.Location = new System.Drawing.Point(650, 124);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(75, 23);
            this.btnShowEmployees.TabIndex = 2;
            this.btnShowEmployees.Text = "ShowEmp";
            this.btnShowEmployees.UseVisualStyleBackColor = true;
            this.btnShowEmployees.Click += new System.EventHandler(this.btnShowEmployees_Click);
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(12, 124);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.Size = new System.Drawing.Size(240, 150);
            this.dgvDepartments.TabIndex = 3;
            this.dgvDepartments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(344, 124);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(240, 150);
            this.dgvEmployees.TabIndex = 4;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Salary";
            // 
            // lblSalary
            // 
            this.lblSalary.Location = new System.Drawing.Point(73, 22);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(220, 20);
            this.lblSalary.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employee:";
            // 
            // lblEmployeeCount
            // 
            this.lblEmployeeCount.Location = new System.Drawing.Point(73, 73);
            this.lblEmployeeCount.Name = "lblEmployeeCount";
            this.lblEmployeeCount.Size = new System.Drawing.Size(220, 20);
            this.lblEmployeeCount.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEmployeeCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.dgvDepartments);
            this.Controls.Add(this.btnShowEmployees);
            this.Controls.Add(this.btnShowDepartments);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowDepartments;
        private System.Windows.Forms.Button btnShowEmployees;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblEmployeeCount;
    }
}

