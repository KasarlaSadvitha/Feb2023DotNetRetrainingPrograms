namespace TypedUntyped
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
            this.btnDisplayTyped = new System.Windows.Forms.Button();
            this.btnDisplayUntyped = new System.Windows.Forms.Button();
            this.btnUpdateUntyped = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisplayTyped
            // 
            this.btnDisplayTyped.Location = new System.Drawing.Point(65, 275);
            this.btnDisplayTyped.Name = "btnDisplayTyped";
            this.btnDisplayTyped.Size = new System.Drawing.Size(91, 23);
            this.btnDisplayTyped.TabIndex = 0;
            this.btnDisplayTyped.Text = "DisplayTyped";
            this.btnDisplayTyped.UseVisualStyleBackColor = true;
            this.btnDisplayTyped.Click += new System.EventHandler(this.btnDisplayTyped_Click);
            // 
            // btnDisplayUntyped
            // 
            this.btnDisplayUntyped.Location = new System.Drawing.Point(211, 275);
            this.btnDisplayUntyped.Name = "btnDisplayUntyped";
            this.btnDisplayUntyped.Size = new System.Drawing.Size(110, 23);
            this.btnDisplayUntyped.TabIndex = 1;
            this.btnDisplayUntyped.Text = "DisplayUntyped";
            this.btnDisplayUntyped.UseVisualStyleBackColor = true;
            this.btnDisplayUntyped.Click += new System.EventHandler(this.btnDisplayUntyped_Click);
            // 
            // btnUpdateUntyped
            // 
            this.btnUpdateUntyped.Location = new System.Drawing.Point(374, 275);
            this.btnUpdateUntyped.Name = "btnUpdateUntyped";
            this.btnUpdateUntyped.Size = new System.Drawing.Size(115, 23);
            this.btnUpdateUntyped.TabIndex = 2;
            this.btnUpdateUntyped.Text = "UpdateUntyped";
            this.btnUpdateUntyped.UseVisualStyleBackColor = true;
            this.btnUpdateUntyped.Click += new System.EventHandler(this.btnUpdateUntyped_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(283, 28);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(308, 208);
            this.dgvEmployees.TabIndex = 5;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnUpdateUntyped);
            this.Controls.Add(this.btnDisplayUntyped);
            this.Controls.Add(this.btnDisplayTyped);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayTyped;
        private System.Windows.Forms.Button btnDisplayUntyped;
        private System.Windows.Forms.Button btnUpdateUntyped;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmployees;



        private System.Data.SqlClient.SqlConnection objConn;
        private System.Data.SqlClient.SqlCommand objCmd;
        private System.Data.SqlClient.SqlDataAdapter da;
        
    }
}

