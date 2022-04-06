using System;
using System.Windows.Forms;
using BusinessLayer.Models;
using DataAccess.Repository;

namespace EmployeeManagementApp
{
    public partial class SalaryFax : Form
    {
        private IDepartmentRepository departmentRepository;

        private readonly ISalaryRepository salaryRepository;

        public SalaryFax()
        {
            InitializeComponent();
            departmentRepository = new DeparmentRepository();
            salaryRepository = new SalaryRepository();
        }

        public Employee CurrentEmployee { get; set; }

        public DateTime CurrentDateTime { get; set; }

        private void SalaryFax_Load(object sender, EventArgs e)
        {
            try
            {
                var faxSalary = salaryRepository.GetSalaryByEmployeeIdAndDate(CurrentEmployee.EmployeeId, CurrentDateTime);
                var faxDepartment = departmentRepository.GetDepartmentById(CurrentEmployee.DepartmentId);
                lbSalaryDate.Text = CurrentDateTime.ToString();
                lbEmployeeId.Text = CurrentEmployee.EmployeeId;
                lbEmployeeName.Text = CurrentEmployee.Fullname;
                lbDepartmentName.Text = faxDepartment.DepartmentName;
                lbWorkHours.Text = faxSalary.WorkHour.ToString();
                lbBaseSalary.Text = faxDepartment.BaseSalary.ToString();
                lbTotal.Text = (faxSalary.WorkHour * faxDepartment.BaseSalary).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}