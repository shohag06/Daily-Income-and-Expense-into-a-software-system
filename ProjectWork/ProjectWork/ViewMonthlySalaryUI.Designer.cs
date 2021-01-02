namespace ProjectWork
{
    partial class ViewMonthlySalaryUI
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
            this.yearInputComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salaryListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showSalaryButton = new System.Windows.Forms.Button();
            this.totalSalaryDisplayTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.exportToPdfButton = new System.Windows.Forms.Button();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Year";
            // 
            // yearInputComboBox
            // 
            this.yearInputComboBox.FormattingEnabled = true;
            this.yearInputComboBox.Location = new System.Drawing.Point(263, 159);
            this.yearInputComboBox.Name = "yearInputComboBox";
            this.yearInputComboBox.Size = new System.Drawing.Size(121, 21);
            this.yearInputComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Month";
            // 
            // salaryListView
            // 
            this.salaryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.salaryListView.Location = new System.Drawing.Point(66, 81);
            this.salaryListView.Name = "salaryListView";
            this.salaryListView.Size = new System.Drawing.Size(398, 162);
            this.salaryListView.TabIndex = 5;
            this.salaryListView.UseCompatibleStateImageBehavior = false;
            this.salaryListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employee Name";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Code";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Salary Amount";
            this.columnHeader3.Width = 127;
            // 
            // showSalaryButton
            // 
            this.showSalaryButton.Location = new System.Drawing.Point(357, 39);
            this.showSalaryButton.Name = "showSalaryButton";
            this.showSalaryButton.Size = new System.Drawing.Size(75, 23);
            this.showSalaryButton.TabIndex = 6;
            this.showSalaryButton.Text = "Show";
            this.showSalaryButton.UseVisualStyleBackColor = true;
            this.showSalaryButton.Click += new System.EventHandler(this.showSalaryButton_Click);
            // 
            // totalSalaryDisplayTextBox
            // 
            this.totalSalaryDisplayTextBox.Location = new System.Drawing.Point(326, 258);
            this.totalSalaryDisplayTextBox.Name = "totalSalaryDisplayTextBox";
            this.totalSalaryDisplayTextBox.Size = new System.Drawing.Size(138, 20);
            this.totalSalaryDisplayTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total";
            // 
            // exportToPdfButton
            // 
            this.exportToPdfButton.Location = new System.Drawing.Point(389, 297);
            this.exportToPdfButton.Name = "exportToPdfButton";
            this.exportToPdfButton.Size = new System.Drawing.Size(75, 23);
            this.exportToPdfButton.TabIndex = 6;
            this.exportToPdfButton.Text = "PDF";
            this.exportToPdfButton.UseVisualStyleBackColor = true;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(230, 16);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(117, 20);
            this.yearTextBox.TabIndex = 8;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(230, 41);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(117, 20);
            this.monthTextBox.TabIndex = 8;
            // 
            // ViewMonthlySalaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 349);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.totalSalaryDisplayTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exportToPdfButton);
            this.Controls.Add(this.showSalaryButton);
            this.Controls.Add(this.salaryListView);
            this.Controls.Add(this.yearInputComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewMonthlySalaryUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Monthly Salary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox yearInputComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView salaryListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button showSalaryButton;
        private System.Windows.Forms.TextBox totalSalaryDisplayTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button exportToPdfButton;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
    }
}