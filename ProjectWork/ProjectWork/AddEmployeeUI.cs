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
    public partial class AddEmployeeUI : Form
    {
        private Employee employee;
        private Designation designation;
        public AddEmployeeUI()
        {
            InitializeComponent();

            foreach (Designation designation in Global.Designations)
            {
                employeeDesignationInputComboBox.Items.Add(designation.Title);
            }
            ViewEmployee();
        }

        private void saveEmployeeButton_Click(object sender, EventArgs e)
        {
            if (Global.Designations.Count == 0)
            {
                ShowWarningMessage("Add designation first!");
                return;
            }
            if (!ValidateInput())
            {
                return;
            }
            string code = employeeCodeInputTextBox.Text;
            string name = employeeNameInputTextBox.Text;
            string email = employeeEmailInputTextBox.Text;
            string contactNo = employeeContactNoInputTextBox.Text;
            string address = employeeAddressInputTextBox.Text;
            designation = Global.GetDesignationByTitle(employeeDesignationInputComboBox.Text);
            DateTime joinedDate = employeeJoinedDateInputDateTimePicker.Value;

            employee = new Employee(code, name, email, contactNo, address, designation, joinedDate);

            Global.Employess.Add(employee);
            ShowSuccessMessage("Employee added");
            ViewEmployee();
        }
        private void newEmployeeButton_Click(object sender, EventArgs e)
        {
            employeeCodeInputTextBox.Text = "";
            employeeNameInputTextBox.Text = "";
            employeeEmailInputTextBox.Text = "";
            employeeContactNoInputTextBox.Text = "";
            employeeAddressInputTextBox.Text = "";
            employeeDesignationInputComboBox.Text = "";
            employeeJoinedDateInputDateTimePicker.Text = "";
        }
        private void ViewEmployee()
        {
            if (Global.Employess.Count == 0)
            {
                return;
            }
            employeeListView.Items.Clear();
            int index = 1;
            foreach (Employee employee in Global.Employess)
            {
                ListViewItem employeeListviewItem = new ListViewItem();
                employeeListviewItem.Text = index.ToString();
                employeeListviewItem.SubItems.Add(employee.Code);
                employeeListviewItem.SubItems.Add(employee.Name);
                employeeListviewItem.SubItems.Add(employee.Email);
                employeeListviewItem.SubItems.Add(employee.ContactNo);
                employeeListviewItem.SubItems.Add(employee.Address);
                employeeListviewItem.SubItems.Add(employee.Designation.Title);
                employeeListviewItem.SubItems.Add(employee.JoinedDate.ToString("dddd: MMM dd, yyy"));
                employeeListView.Items.Add(employeeListviewItem);
                index++;
            }
        }
        private bool ValidateInput()
        {
            if (employeeCodeInputTextBox.Text == "" || employeeNameInputTextBox.Text == ""
                || employeeEmailInputTextBox.Text == "" || employeeContactNoInputTextBox.Text == ""
                || employeeAddressInputTextBox.Text == "" || employeeDesignationInputComboBox.Text == "")
            {
                ShowErrorMessage("Please enter all the data!");
                return false;
            }
            if (Global.HasEmployee(employeeCodeInputTextBox.Text))
            {
                ShowErrorMessage("Employee's code must be unique!");
                return false;
            }
            if (Global.HasEmployee(employeeEmailInputTextBox.Text))
            {
                ShowErrorMessage("Employee's email must be unique!");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message + " successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
