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
    public partial class PromotionUI : Form
    {
        private Employee employee;
        private Designation designation;
        private string employeeCode;
        public PromotionUI()
        {
            InitializeComponent();
            employeeNameDisplayTextBox.ReadOnly = true;
            employeeEmailDisplayTextBox.ReadOnly = true;
            employeeCurrentDesignationDisplayTextBox.ReadOnly = true;
            foreach (Employee employee in Global.Employess)
            {
                employeeCodeInputComboBox.Items.Add(employee.Code);
            }
            foreach (Designation designation in Global.Designations)
            {
                employeeDesignationInputComboBox.Items.Add(designation.Title);
            }
        }

        private void findEmployeeButton_Click(object sender, EventArgs e)
        {
            employeeCode = employeeCodeInputComboBox.Text;
            employee = Global.GetEmployeeByCode(employeeCode);
            if (employee == null)
            {
                ShowWarningMessage("Employee not found!");
                return;
            }
            employeeNameDisplayTextBox.Text = employee.Name;
            employeeEmailDisplayTextBox.Text = employee.Email;
            employeeCurrentDesignationDisplayTextBox.Text = employee.Designation.Title;
        }

        private void savePromotionButton_Click(object sender, EventArgs e)
        {
            if (employee == null)
            {
                ShowWarningMessage("Employee not found!");
                return;
            }
            string designationTitle = employeeDesignationInputComboBox.Text;
            designation = Global.GetDesignationByTitle(designationTitle);
            
            Promotion promotion = new Promotion();
            promotion.PromoteEmployee(employeeCode, designation);
            ShowSuccessMessage("Employee promoted");
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
