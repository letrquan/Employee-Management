using BusinessLayer.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeeManagementApp
{
    public partial class frmDepartmentDetail : Form
    {
        public IDepartmentRepository deparmentRepository { get; set; }
        public IEmployeeRepository employeeRepository { get; set; }
        public frmDepartmentDetail()
        {
            InitializeComponent();
            deparmentRepository = new DeparmentRepository();
            employeeRepository = new EmployeeRepository();
        }
        
        //---------------------------------------------------------------

        private string managerRoleId = "R2";
        public bool InsertOrUpdate { get; set; }
        public Department DepartmentInfo { get; set; }

        private void frmDepartmentDetail_Load(object sender, EventArgs e)
        {
            List<Employee> managerList = employeeRepository.GetAllManager(managerRoleId);
            foreach (Employee manager in managerList)
            {
                comboBoxManagerId.Items.Add(manager.EmployeeId);
            }
            txtDepartmentID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                txtDepartmentID.Text = DepartmentInfo.DepartmentId;
                txtDepartmentName.Text = DepartmentInfo.DepartmentName;
                comboBoxManagerId.SelectedText = DepartmentInfo.ManagerId;
                txtDepartmentBaseSalary.Text = DepartmentInfo.BaseSalary.ToString();
            }
        }


        //---------------------------------------------------------------

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDepartmentID.Text) || string.IsNullOrEmpty(txtDepartmentBaseSalary.Text))
            {
                MessageBox.Show("Depart Id and Base Salary are Required!");
                return;
            }
            try
            {
                var managerIdCheck = comboBoxManagerId.Text;
                if (managerIdCheck == "")
                {
                    managerIdCheck = null;
                }
                var Department = new Department
                {
                    DepartmentId = txtDepartmentID.Text.ToUpper(),
                    DepartmentName = txtDepartmentName.Text.ToUpper(),
                    ManagerId = managerIdCheck,
                    BaseSalary = short.Parse(txtDepartmentBaseSalary.Text),
                };

                if(InsertOrUpdate == false)
                {
                    deparmentRepository.AddDepartment(Department);
                } else
                {
                    deparmentRepository.UpdateDepartment(Department);
                }
                Close();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate ? "Insert Department" : "Update Department");
            }
        }

        //---------------------------------------------------------------

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
