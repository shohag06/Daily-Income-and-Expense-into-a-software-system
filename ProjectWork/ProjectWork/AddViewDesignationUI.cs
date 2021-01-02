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
    public partial class AddViewDesignationUI : Form
    {
        private Designation designation;
        public AddViewDesignationUI()
        {
            InitializeComponent();
            totalSalaryDisplayTextBox.ReadOnly = true;
            ShowDesignation();
        }
        private void saveDesignationButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }
            string title = designationTitleInputTextBox.Text;
            string code = designationCodeInputTextBox.Text;
            double salaryBasic = Convert.ToDouble(salaryBasicInputTextBox.Text);
            double houseRent = Convert.ToDouble(houseRentInputTextBox.Text);
            double medicalAmount = Convert.ToDouble(medicalAmountInputTextBox.Text);

            designation = new Designation(title, code, salaryBasic, houseRent, medicalAmount);
            Global.Designations.Add(designation);

            ShowSuccessMessage("Designation added");
            totalSalaryDisplayTextBox.Text = designation.Salary.TotalSalary().ToString();
            ShowDesignation();
        }
        private void ShowDesignation()
        {
            if (Global.Designations.Count == 0)
            {
                return;
            }
            int index = 1;
            designationListView.Items.Clear();

            foreach (Designation designation in Global.Designations)
            {
                ListViewItem designationListViewItem = new ListViewItem();
                designationListViewItem.Text = index.ToString();
                designationListViewItem.SubItems.Add(designation.Title);
                designationListViewItem.SubItems.Add(designation.Code);
                designationListViewItem.SubItems.Add(designation.Salary.SalaryBasic.ToString());
                designationListViewItem.SubItems.Add(designation.Salary.HouseRent.ToString());
                designationListViewItem.SubItems.Add(designation.Salary.MedicalAmount.ToString());
                designationListViewItem.SubItems.Add(designation.Salary.TotalSalary().ToString());
                designationListView.Items.Add(designationListViewItem);
                index++;
        }
    }
    private bool ValidateInput()
        {
            if (designationTitleInputTextBox.Text == "" || designationCodeInputTextBox.Text == ""
                || salaryBasicInputTextBox.Text == "" || houseRentInputTextBox.Text == ""
                || medicalAmountInputTextBox.Text == "")
            {
                ShowErrorMessage("Please enter all the data!");
                return false;
            }
            if (Global.HasDesignation(designationCodeInputTextBox.Text))
            {
                ShowErrorMessage("Designation code must be unique!");
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
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
