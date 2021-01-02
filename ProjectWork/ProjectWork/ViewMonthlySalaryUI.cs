using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWork
{
    public partial class ViewMonthlySalaryUI : Form
    {
        public ViewMonthlySalaryUI()
        {
            InitializeComponent();
            yearTextBox.ReadOnly = true;
            monthTextBox.ReadOnly = true;
            yearTextBox.Text = DateTime.Now.Year.ToString("");
            monthTextBox.Text = DateTime.Now.ToString("MMMM");
        }

        private void showSalaryButton_Click(object sender, EventArgs e)
        {
            double totalSalary = 0;
            if (Global.Employess.Count == 0)
            {
                return;
            }
            foreach (Employee employee in Global.Employess)
            {
                DateTime joinedDate = employee.JoinedDate;
                string year = joinedDate.Year.ToString();
                string month = joinedDate.ToString("MMMM");
                if (year == yearInputComboBox.Text && month == monthTextBox.Text)
                {
                    ListViewItem employeeListViewItem = new ListViewItem();
                    employeeListViewItem.Text = employee.Name;
                    employeeListViewItem.SubItems.Add(employee.Code);
                    employeeListViewItem.SubItems.Add(employee.Designation.Salary.TotalSalary().ToString());
                    salaryListView.Items.Add(employeeListViewItem);

                    totalSalary += employee.Designation.Salary.TotalSalary();
                }
            }
            totalSalaryDisplayTextBox.Text = totalSalary.ToString();
        }
    }
}
