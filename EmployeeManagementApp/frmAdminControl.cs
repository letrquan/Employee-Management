using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLayer.Models;
using DataAccess.Repository;
using MyStoreWinApp;

namespace EmployeeManagementApp
{
    public partial class frmAdminControl : UserControl
    {
        private IEmployeeRepository employeeRepository;

        private IDepartmentRepository departmentRepository;

        BindingSource source;
        //Singleton
        private static frmAdminControl _instance;

        public static frmAdminControl Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new frmAdminControl();
                }

                return _instance;
            }
        }
        public frmAdminControl()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository();
            departmentRepository = new DeparmentRepository();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            grvMemberList.AutoGenerateColumns = true;
            loadManagerList();
        }

        private void grvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string employeeId = getSelectedEmployeeId();
            Employee updateEmployee = employeeRepository.GetEmployeeById(employeeId);
            frmManagerDetail frmManagerDetail = new frmManagerDetail()
            {
                isUpdate = true,
                isAdmin = true,
                employeeInfomation = updateEmployee
            };
            frmManagerDetail.Show();
            frmManagerDetail.Closed += (sender, e) =>
            {
                loadManagerList();
            };
        }

        private string getSelectedEmployeeId()
        {
            //Get Id in gridview
            int index = grvMemberList.CurrentCell.RowIndex;
            string emId = grvMemberList.Rows[index].Cells[0].Value.ToString();
            return emId; 
        }

        private void loadManagerList()
        {
            grvMemberList.DataSource = employeeRepository.GetAllManager("R2");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string employeeId = getSelectedEmployeeId();
            DialogResult d;
            d = MessageBox.Show("Are you sure wanted to delete manager?", "Admin Manager - Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (d == DialogResult.Yes)
            {
                try
                {
                    Employee deleteEmployee = employeeRepository.GetEmployeeById(employeeId);
                    employeeRepository.DeleteEmployee(deleteEmployee);
                    loadManagerList();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    MessageBox.Show("Manager Is Manage Department! Please Remove Manager From Department First");
                }
                
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmManagerDetail frmManagerDetail = new frmManagerDetail()
            {
                isUpdate = false,
                isAdmin = true,
            };
            frmManagerDetail.Show();
            frmManagerDetail.Closed += (sender, e) =>
            {
                loadManagerList();
            };
        }


        //---------------------------------------------------------------------------------------------

        //Get only one department
        private Department GetDepartment()
        {
            Department depart = null;
            depart = new Department
            {
                DepartmentId = txtDepartmentID.Text,
                DepartmentName = txtDepartmentName.Text,
                ManagerId = txtDeparmentManagerId.Text,
                BaseSalary = short.Parse(txtDepartmentBaseSalary.Text),
            };
            return depart;
        }

        //Load department base on action (all = load all, department = load one department)
        private void LoadDepartmentList(string action)
        {
            source = new BindingSource();
            if (action == "all")
            {
                IEnumerable<Department> departments = null;
                departments = departmentRepository.GetAllDepartments();
                source.DataSource = departments;
            }
            else if(action == "department")
            {
                Department department = departmentRepository.SearchDepartmentByDepartmentId(txtSearchDepartment.Text.ToUpper());
                source.DataSource = department;
            }

            try
            { 
                txtDepartmentID.DataBindings.Clear();
                txtDepartmentName.DataBindings.Clear();
                txtDeparmentManagerId.DataBindings.Clear();
                txtDepartmentBaseSalary.DataBindings.Clear();


                txtDepartmentID.DataBindings.Add("Text", source, "DepartmentId");
                txtDepartmentName.DataBindings.Add("Text", source, "DepartmentName");
                txtDeparmentManagerId.DataBindings.Add("Text", source, "ManagerId");
                txtDepartmentBaseSalary.DataBindings.Add("Text", source, "BaseSalary");

                dgvDepartment.DataSource = null;
                dgvDepartment.DataSource = source;
                dgvDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDepartment.Columns[4].Visible = false;
                dgvDepartment.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load department list");
            }


        }

        //button load department
        private void btnLoadDepartment_Click(object sender, EventArgs e)
        {
            LoadDepartmentList("all");
        }

        //button new department
        private void btnNewDepartment_Click(object sender, EventArgs e)
        {
            frmDepartmentDetail frmDepartmentDetail = new frmDepartmentDetail
            {
                InsertOrUpdate = false,
                Text = "New Department",
                deparmentRepository = departmentRepository,
            };
            if(frmDepartmentDetail.ShowDialog() == DialogResult.OK)
            {
                LoadDepartmentList("all");
                source.Position = source.Count - 1;
            }
        }
        
        //button search department
        private void btnSearchDepartment_Click(object sender, EventArgs e)
        {
            LoadDepartmentList("department");
        }

        //Click to data grid view to update department
        private void dgvDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDepartmentDetail frmDepartmentDetail = new frmDepartmentDetail
            {
                Text = "Update Department",
                InsertOrUpdate = true,
                deparmentRepository = departmentRepository,
                DepartmentInfo = GetDepartment()
            };
            if(frmDepartmentDetail.ShowDialog() == DialogResult.OK)
            {
                LoadDepartmentList("all");
                source.Position = source.Count - 1;
            }

        }

        //Delete department button
        private void btnDepartmentDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Department depart = GetDepartment();
                departmentRepository.DeleteDepartment(depart);
                LoadDepartmentList("all");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Delete Department");
            }
        }

        private void frmAdminControl_Load(object sender, EventArgs e)
        {
            dgvDepartment.CellDoubleClick += dgvDepartment_CellContentClick;
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearchManagerWithId.Text;
            Employee searchedEmployee = employeeRepository.GetEmployeeById(searchValue);
            List<Employee> searchList = new List<Employee>();
            searchList.Add(searchedEmployee);
            grvMemberList.DataSource = searchList;
        }
    }
}
