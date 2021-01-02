﻿namespace ProjectWork
{
    partial class PromotionUI
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
            this.findEmployeeButton = new System.Windows.Forms.Button();
            this.employeeNameDisplayTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeCodeInputComboBox = new System.Windows.Forms.ComboBox();
            this.employeeEmailDisplayTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.promotionListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeCurrentDesignationDisplayTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeDesignationInputComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Code";
            // 
            // findEmployeeButton
            // 
            this.findEmployeeButton.Location = new System.Drawing.Point(270, 21);
            this.findEmployeeButton.Name = "findEmployeeButton";
            this.findEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.findEmployeeButton.TabIndex = 1;
            this.findEmployeeButton.Text = "Find";
            this.findEmployeeButton.UseVisualStyleBackColor = true;
            this.findEmployeeButton.Click += new System.EventHandler(this.findEmployeeButton_Click);
            // 
            // employeeNameDisplayTextBox
            // 
            this.employeeNameDisplayTextBox.Location = new System.Drawing.Point(153, 60);
            this.employeeNameDisplayTextBox.Name = "employeeNameDisplayTextBox";
            this.employeeNameDisplayTextBox.Size = new System.Drawing.Size(114, 20);
            this.employeeNameDisplayTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // employeeCodeInputComboBox
            // 
            this.employeeCodeInputComboBox.FormattingEnabled = true;
            this.employeeCodeInputComboBox.Location = new System.Drawing.Point(146, 23);
            this.employeeCodeInputComboBox.Name = "employeeCodeInputComboBox";
            this.employeeCodeInputComboBox.Size = new System.Drawing.Size(121, 21);
            this.employeeCodeInputComboBox.TabIndex = 0;
            // 
            // employeeEmailDisplayTextBox
            // 
            this.employeeEmailDisplayTextBox.Location = new System.Drawing.Point(153, 86);
            this.employeeEmailDisplayTextBox.Name = "employeeEmailDisplayTextBox";
            this.employeeEmailDisplayTextBox.Size = new System.Drawing.Size(114, 20);
            this.employeeEmailDisplayTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // promotionListView
            // 
            this.promotionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.promotionListView.Location = new System.Drawing.Point(35, 261);
            this.promotionListView.Name = "promotionListView";
            this.promotionListView.Size = new System.Drawing.Size(475, 97);
            this.promotionListView.TabIndex = 7;
            this.promotionListView.UseCompatibleStateImageBehavior = false;
            this.promotionListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Start Date";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "End Date";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Designation";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Salary";
            this.columnHeader4.Width = 108;
            // 
            // employeeCurrentDesignationDisplayTextBox
            // 
            this.employeeCurrentDesignationDisplayTextBox.Location = new System.Drawing.Point(153, 112);
            this.employeeCurrentDesignationDisplayTextBox.Name = "employeeCurrentDesignationDisplayTextBox";
            this.employeeCurrentDesignationDisplayTextBox.Size = new System.Drawing.Size(114, 20);
            this.employeeCurrentDesignationDisplayTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Current Designation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "New Designation";
            // 
            // employeeDesignationInputComboBox
            // 
            this.employeeDesignationInputComboBox.FormattingEnabled = true;
            this.employeeDesignationInputComboBox.Location = new System.Drawing.Point(146, 160);
            this.employeeDesignationInputComboBox.Name = "employeeDesignationInputComboBox";
            this.employeeDesignationInputComboBox.Size = new System.Drawing.Size(121, 21);
            this.employeeDesignationInputComboBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(273, 158);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.savePromotionButton_Click);
            // 
            // PromotionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 390);
            this.Controls.Add(this.promotionListView);
            this.Controls.Add(this.employeeDesignationInputComboBox);
            this.Controls.Add(this.employeeCodeInputComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.findEmployeeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeCurrentDesignationDisplayTextBox);
            this.Controls.Add(this.employeeEmailDisplayTextBox);
            this.Controls.Add(this.employeeNameDisplayTextBox);
            this.Name = "PromotionUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promotion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findEmployeeButton;
        private System.Windows.Forms.TextBox employeeNameDisplayTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox employeeCodeInputComboBox;
        private System.Windows.Forms.TextBox employeeEmailDisplayTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView promotionListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox employeeCurrentDesignationDisplayTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox employeeDesignationInputComboBox;
        private System.Windows.Forms.Button saveButton;
    }
}