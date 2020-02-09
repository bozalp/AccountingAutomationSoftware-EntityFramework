namespace accounting_automation_software
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
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.emp_add_button = new System.Windows.Forms.Button();
            this.git_link = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(143, 121);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 41);
            this.button6.TabIndex = 13;
            this.button6.TabStop = false;
            this.button6.Text = "Money Case";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Accounting Automation Software";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(12, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 41);
            this.button4.TabIndex = 10;
            this.button4.TabStop = false;
            this.button4.Text = "Sales";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(273, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 41);
            this.button3.TabIndex = 9;
            this.button3.TabStop = false;
            this.button3.Text = "Purchase";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(143, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 41);
            this.button2.TabIndex = 8;
            this.button2.TabStop = false;
            this.button2.Text = "Depatment Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // emp_add_button
            // 
            this.emp_add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_add_button.Location = new System.Drawing.Point(12, 63);
            this.emp_add_button.Name = "emp_add_button";
            this.emp_add_button.Size = new System.Drawing.Size(110, 41);
            this.emp_add_button.TabIndex = 7;
            this.emp_add_button.TabStop = false;
            this.emp_add_button.Text = "Employee Add/List";
            this.emp_add_button.UseVisualStyleBackColor = true;
            this.emp_add_button.Click += new System.EventHandler(this.emp_add_button_Click);
            // 
            // git_link
            // 
            this.git_link.AutoSize = true;
            this.git_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.git_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.git_link.ForeColor = System.Drawing.SystemColors.ControlText;
            this.git_link.Location = new System.Drawing.Point(331, 149);
            this.git_link.Name = "git_link";
            this.git_link.Size = new System.Drawing.Size(52, 13);
            this.git_link.TabIndex = 14;
            this.git_link.Text = "by bozalp";
            this.git_link.Click += new System.EventHandler(this.git_link_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::accounting_automation_software.Properties.Resources.GitHub_Mark_32px;
            this.panel1.Location = new System.Drawing.Point(293, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 32);
            this.panel1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(395, 180);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.git_link);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.emp_add_button);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Accounting Automation Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button emp_add_button;
        private System.Windows.Forms.Label git_link;
        private System.Windows.Forms.Panel panel1;
    }
}

