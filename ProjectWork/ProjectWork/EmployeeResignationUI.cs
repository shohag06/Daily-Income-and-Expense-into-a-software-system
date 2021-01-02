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
    public partial class EmployeeResignationUI : Form
    {
        private Employee employee;
        private string employeeCode;
        public EmployeeResignationUI()
        {
            InitializeComponent();
            employeeNameDisplayTextBox.ReadOnly = true;
            employeeEmailDisplayTextBox.ReadOnly = true;
            employeeDesignationDisplayTextBox.ReadOnly = true;
            foreach (Employee employee in Global.Employess)
            {
                employeeCodeInputComboBox.Items.Add(employee.Code);
            }
        }

        private void findEmployeeForResignButton_Click(object sender, EventArgs e)
        {
            employeeCode = employeeCodeInputComboBox.Text;
            employee = Global.GetEmployeeByCode(employeeCode);
            if(employee == null)
            {
                ShowWarningMessage("Employee not found!");
                return;
            }
            employeeNameDisplayTextBox.Text = employee.Name;
            employeeEmailDisplayTextBox.Text = employee.Email;
            employeeDesignationDisplayTextBox.Text = employee.Designation.Title;
        }

        private void resignButton_Click(object sender, EventArgs e)
        {
            if (employee == null)
            {
                ShowWarningMessage("Employee not found!");
                return;
            }

            Global.ResignEmployee(employeeCode);
           
            ShowSuccessMessage("Employee resignation done");
        }
        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message + " successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
