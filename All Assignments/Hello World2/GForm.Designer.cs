namespace Hello_World2
{
    partial class GForm
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
            this.btnHi = new System.Windows.Forms.Button();
            this.btnBye = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHi
            // 
            this.btnHi.Location = new System.Drawing.Point(254, 204);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(75, 23);
            this.btnHi.TabIndex = 0;
            this.btnHi.Text = "SayHi";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBye
            // 
            this.btnBye.Location = new System.Drawing.Point(469, 204);
            this.btnBye.Name = "btnBye";
            this.btnBye.Size = new System.Drawing.Size(75, 23);
            this.btnBye.TabIndex = 1;
            this.btnBye.Text = "SayBye";
            this.btnBye.UseVisualStyleBackColor = true;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(469, 120);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 2;
            this.Name.Text = "txtName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "EnterName";
            // 
            // GForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.btnBye);
            this.Controls.Add(this.btnHi);
            this.Name = "GForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Button btnBye;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label1;
    }
}

