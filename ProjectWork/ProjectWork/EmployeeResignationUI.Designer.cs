namespace ProjectWork
{
    partial class EmployeeResignationUI
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
            this.employeeCodeInputComboBox = new System.Windows.Forms.ComboBox();
            this.findEmployeeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeDesignationDisplayTextBox = new System.Windows.Forms.TextBox();
            this.employeeEmailDisplayTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameDisplayTextBox = new System.Windows.Forms.TextBox();
            this.resignButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeCodeInputComboBox
            // 
            this.employeeCodeInputComboBox.FormattingEnabled = true;
            this.employeeCodeInputComboBox.Location = new System.Drawing.Point(103, 30);
            this.employeeCodeInputComboBox.Name = "employeeCodeInputComboBox";
            this.employeeCodeInputComboBox.Size = new System.Drawing.Size(121, 21);
            this.employeeCodeInputComboBox.TabIndex = 0;
            // 
            // findEmployeeButton
            // 
            this.findEmployeeButton.Location = new System.Drawing.Point(227, 28);
            this.findEmployeeButton.Name = "findEmployeeButton";
            this.findEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.findEmployeeButton.TabIndex = 1;
            this.findEmployeeButton.Text = "Find";
            this.findEmployeeButton.UseVisualStyleBackColor = true;
            this.findEmployeeButton.Click += new System.EventHandler(this.findEmployeeForResignButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // employeeDesignationDisplayTextBox
            // 
            this.employeeDesignationDisplayTextBox.Location = new System.Drawing.Point(110, 127);
            this.employeeDesignationDisplayTextBox.Name = "employeeDesignationDisplayTextBox";
            this.employeeDesignationDisplayTextBox.Size = new System.Drawing.Size(114, 20);
            this.employeeDesignationDisplayTextBox.TabIndex = 4;
            // 
            // employeeEmailDisplayTextBox
            // 
            this.employeeEmailDisplayTextBox.Location = new System.Drawing.Point(110, 101);
            this.employeeEmailDisplayTextBox.Name = "employeeEmailDisplayTextBox";
            this.employeeEmailDisplayTextBox.Size = new System.Drawing.Size(114, 20);
            this.employeeEmailDisplayTextBox.TabIndex = 3;
            // 
            // employeeNameDisplayTextBox
            // 
            this.employeeNameDisplayTextBox.Location = new System.Drawing.Point(110, 75);
            this.employeeNameDisplayTextBox.Name = "employeeNameDisplayTextBox";
            this.employeeNameDisplayTextBox.Size = new System.Drawing.Size(114, 20);
            this.employeeNameDisplayTextBox.TabIndex = 2;
            // 
            // resignButton
            // 
            this.resignButton.Location = new System.Drawing.Point(149, 153);
            this.resignButton.Name = "resignButton";
            this.resignButton.Size = new System.Drawing.Size(75, 23);
            this.resignButton.TabIndex = 5;
            this.resignButton.Text = "Resign";
            this.resignButton.UseVisualStyleBackColor = true;
            this.resignButton.Click += new System.EventHandler(this.resignButton_Click);
            // 
            // EmployeeResignationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeDesignationDisplayTextBox);
            this.Controls.Add(this.employeeEmailDisplayTextBox);
            this.Controls.Add(this.employeeNameDisplayTextBox);
            this.Controls.Add(this.employeeCodeInputComboBox);
            this.Controls.Add(this.resignButton);
            this.Controls.Add(this.findEmployeeButton);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeResignationUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Resignation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox employeeCodeInputComboBox;
        private System.Windows.Forms.Button findEmployeeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeeDesignationDisplayTextBox;
        private System.Windows.Forms.TextBox employeeEmailDisplayTextBox;
        private System.Windows.Forms.TextBox employeeNameDisplayTextBox;
        private System.Windows.Forms.Button resignButton;
    }
}