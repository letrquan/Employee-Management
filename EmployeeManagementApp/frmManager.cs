using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using BusinessLayer.Models;


namespace EmployeeManagementApp
{
    public partial class frmManager : UserControl
    {
        private IEmployeeRepository employeeRepository;
        private IDepartmentRepository departmentRepository;
        private IEnumerable<Employee> list;
        private BindingSource source;
        private string memberRoleId = "R3";

        public Employee CurrentUser { get; set; }
        //Singleton
        private static frmManager _instance;

        public static frmManager Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new frmManager();
                }

                return _instance;
            }
        }

        public frmManager()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository();
            departmentRepository = new DeparmentRepository();
        }

        private void clearText()
        {
            txtEmployeeID.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtDepartmentID.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtFullName.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtRoleID.Text = String.Empty;
        }
        public void LoadEmployeeList()
        {
            
            try
            {
                Department manaDepart = departmentRepository.GetDepartmentOfManager(CurrentUser.EmployeeId);
                if (manaDepart == null)
                {
                    MessageBox.Show("You are not manage any Depart yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                btnDelete.Enabled = true;
                var employees = employeeRepository.GetEmployeeOfDepartment(manaDepart.DepartmentId);
                if (list.Count() == 0)
                {
                    // hien lable list trong 
                    btnDelete.Enabled = false;
                    clearText();
                }
                else
                {
                    //list khong trong
                    btnDelete.Enabled = true;
                }

                source = new BindingSource();
                source.DataSource = list;

                txtEmail.DataBindings.Clear();
                txtFullName.DataBindings.Clear();
                txtEmployeeID.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtDepartmentID.DataBindings.Clear();
                txtRoleID.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtPhone.DataBindings.Clear();

                txtEmployeeID.DataBindings.Add("Text", source, "EmployeeId");
                txtFullName.DataBindings.Add("Text", source, "Fullname");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtDepartmentID.DataBindings.Add("Text", source, "DepartmentId");
                txtAddress.DataBindings.Add("Text", source, "Address");
                txtRoleID.DataBindings.Add("Text", source, "RoleId");

                dgvManager.DataSource = null;
                dgvManager.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }

        }

        private void Editable()
        {
            txtEmail.ReadOnly = false;
            txtFullName.ReadOnly = false;
            txtEmployeeID.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtDepartmentID.Enabled = false;
            txtRoleID.Enabled = false;
            txtAddress.ReadOnly = false;
            btnCancel.Visible = true;
            btnConfirm.Visible = true;
                
        }

        private void UnEditable()
        {
            txtEmail.ReadOnly = true;
            txtFullName.ReadOnly = true;
            txtEmployeeID.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtDepartmentID.Enabled = false;
            txtRoleID.Enabled = false;
            txtAddress.ReadOnly = true;
            btnCancel.Visible = false;
            btnConfirm.Visible = false;

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Department manaDepart = departmentRepository.GetDepartmentOfManager(CurrentUser.EmployeeId);
            if (manaDepart == null)
            {
                MessageBox.Show("You are not manage any Depart yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            list = employeeRepository.GetEmployeeOfDepartment(manaDepart.DepartmentId);
            LoadEmployeeList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Editable();
            clearText();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Department manaDepart = departmentRepository.GetDepartmentOfManager(CurrentUser.EmployeeId);
                if (manaDepart == null)
                {
                    MessageBox.Show("You are not manage any Depart yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Employee deleteEmplyee = employeeRepository.GetEmployeeById(txtEmployeeID.Text);
                if (deleteEmplyee.Salaries.Count > 0)
                {
                    MessageBox.Show("This Employee Has Salary, Clear this Employee's Salaries First!");
                    return;
                }
                employeeRepository.DeleteEmployee(deleteEmplyee);
                list = employeeRepository.GetEmployeeOfDepartment(manaDepart.DepartmentId);
                LoadEmployeeList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deleted Employee");
            }
        }

            private void LoadOneMember()
        {
            Employee employee = new Employee();
            var employees = employeeRepository.GetAllEmployees();
            try
            {
                        List<Employee> list = new List<Employee>();
                        list.Add(employeeRepository.GetEmployeeById(txtEmployeeID.Text));
                        source = new BindingSource();
                        source.DataSource = list;

                        txtEmployeeID.DataBindings.Clear();
                        txtFullName.DataBindings.Clear();
                        txtPassword.DataBindings.Clear();
                        txtEmail.DataBindings.Clear();
                        txtRoleID.DataBindings.Clear();
                        txtDepartmentID.DataBindings.Clear();
                        txtAddress.DataBindings.Clear();

                        txtEmployeeID.DataBindings.Add("Text", source, "EmployeeId");
                        txtFullName.DataBindings.Add("Text", source, "Fullname");
                        txtEmail.DataBindings.Add("Text", source, "Email");
                        txtPassword.DataBindings.Add("Text", source, "Password");
                        txtDepartmentID.DataBindings.Add("Text", source, "DepartmentId");
                        txtAddress.DataBindings.Add("Text", source, "Address");
                        txtRoleID.DataBindings.Add("Text", source, "RoleId");

                        dgvManager.DataSource = null;
                        dgvManager.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadOneMember();
        }

        private void comboBoxDepartmentID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEmployeeID.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtPassword.Text)
                )
                {
                    MessageBox.Show("Employee Id, Email, Password are required!");
                    return;
                }
                //Get current Manager Department
                Department manaDepart = departmentRepository.GetDepartmentOfManager(CurrentUser.EmployeeId);
                if (manaDepart == null)
                {
                    MessageBox.Show("You are not manage any Depart yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Employee employee = new Employee()
                {
                    EmployeeId = txtEmployeeID.Text,
                    Fullname = txtFullName.Text,
                    Password = txtPassword.Text,
                    BirthDate = dtpBirthday.Value.Date,
                    RoleId = memberRoleId,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    DepartmentId = manaDepart.DepartmentId,
                };
                employeeRepository.AddEmployee(employee);
                list = employeeRepository.GetEmployeeOfDepartment(manaDepart.DepartmentId);
                LoadEmployeeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add new Employee");
            }

           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearText();
            UnEditable();
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
        }
    }
}
