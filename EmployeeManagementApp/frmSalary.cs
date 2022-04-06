using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLayer.Models;
using DataAccess.Repository;

namespace EmployeeManagementApp
{
    public partial class from : UserControl
    {
        //Singleton
        private static from _instance;
        private readonly ISalaryRepository salaryRepository;

        private IEmployeeRepository employeeRepository;

        private IDepartmentRepository departmentRepository;

        public Employee CurrentUser { get; set; }


        private BindingSource source;

        public from()
        {
            InitializeComponent();
            salaryRepository = new SalaryRepository();
            employeeRepository = new EmployeeRepository();
            departmentRepository = new DeparmentRepository();
        }

        

        public static from Instance
        {
            get
            {
                if (_instance is null) _instance = new @from();

                return _instance;
            }
        }

        private int getSelectedSalaryId()
        {
            //Get Id in gridview
            var index = grvSalary.CurrentCell.RowIndex;
            var id = grvSalary.Rows[index].Cells[0].Value.ToString();
            return int.Parse(id);
        }


        private void grvSalary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = grvSalary.CurrentCell.RowIndex;
            var employeeId = grvSalary.Rows[index].Cells[1].Value.ToString();
            var selectedDate = grvSalary.Rows[index].Cells[3].Value.ToString();
            var selectedEmployee = employeeRepository.GetEmployeeById(employeeId);
            SalaryFax salaryFax = new SalaryFax()
            {
                CurrentEmployee = selectedEmployee,
                CurrentDateTime = DateTime.Parse(selectedDate),
            };
            salaryFax.Show();
        }

        private void btnFilterSalary_Click(object sender, EventArgs e)
        {
            loadSalaries();
        }

        private void loadSalaries()
        {
           
            source = new BindingSource();
            var fromDate = dtpFromDate.Value.Date;
            var toDate = dtpToDate.Value.Date;
            var managerDepartment = departmentRepository.GetDepartmentOfManager(CurrentUser.EmployeeId);
            try
            {
                txtWorkHours.DataBindings.Clear();
                if (managerDepartment == null)
                {
                    MessageBox.Show("You haven't manage any department yet!");
                    return;
                }
                source.DataSource = salaryRepository.GetSalariesWithMember(fromDate, toDate, managerDepartment.DepartmentId);
                
                txtWorkHours.DataBindings.Add("Text", source, "WorkHours");
                grvSalary.DataSource = source;
                if (grvSalary.Rows.Count > 0)
                {
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateWorkHours = int.Parse(txtWorkHours.Text);
            var salaryNeedUpdate = salaryRepository.GetSalaryById(getSelectedSalaryId());
            var updateSalary = new Salary
            {
                SalaryId = salaryNeedUpdate.SalaryId,
                SalaryDate = salaryNeedUpdate.SalaryDate,
                EmployeeId = salaryNeedUpdate.EmployeeId,
                WorkHour = updateWorkHours
            };
            salaryRepository.UpdateSalary(updateSalary);
            loadSalaries();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                var dateNeedCreate = dtpNewSalaryDate.Value.Date;
                var d = MessageBox.Show("Create Salary for this month?", "Salary Management - Question",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (d == DialogResult.OK)
                {
                    Department ManagingDepart = departmentRepository.GetDepartmentOfManager(CurrentUser.EmployeeId);
                    if (ManagingDepart == null)
                    {
                        MessageBox.Show("You haven't manage any department yet!");
                        return;
                    }
                    List<Employee> listEmployees = employeeRepository.GetEmployeeOfDepartment(ManagingDepart.DepartmentId);
                    foreach (Employee employee in listEmployees)
                    {
                        salaryRepository.NewSalary(new Salary()
                        {
                            EmployeeId = employee.EmployeeId,
                            SalaryDate = dateNeedCreate,
                            WorkHour = 0,
                        });
                    }
                    loadSalaries();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void from_Load(object sender, EventArgs e)
        {
        }

        private void txtWorkHours_BindingContextChanged(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var d = MessageBox.Show("Are you sure wanted to Delete Salary?", "Salary Management - Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (d == DialogResult.OK)
            {
                try
                {
                    int currentSelectedId = getSelectedSalaryId();
                    Salary deleteSalary = salaryRepository.GetSalaryById(currentSelectedId);
                    salaryRepository.DeleteSalary(deleteSalary);
                    loadSalaries();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}