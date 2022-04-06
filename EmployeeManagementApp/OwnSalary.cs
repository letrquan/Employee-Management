using System;
using System.Windows.Forms;
using BusinessLayer.Models;
using DataAccess.Repository;

namespace EmployeeManagementApp
{
    public partial class OwnSalary : Form
    {
        private readonly ISalaryRepository salaryRepository;

        private IDepartmentRepository departmentRepository;

        public OwnSalary()
        {
            InitializeComponent();
            salaryRepository = new SalaryRepository();
            departmentRepository = new DeparmentRepository();
        }

        public Employee CurrentEmployee { get; set; }

        private void OwnSalary_Load(object sender, EventArgs e)
        {
            try
            {
                var employeeSalaries = salaryRepository.GetSalariesOfEmployee(CurrentEmployee.EmployeeId);
                foreach (var salary in employeeSalaries) comboDate.Items.Add(salary.SalaryDate);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var selectedValue = comboDate.Text;
            if (String.IsNullOrEmpty(selectedValue))
            {
                MessageBox.Show("Please Select a date");
                return;
            }
            DateTime selectedDateTime = DateTime.Parse(selectedValue);
            try
            {
                try
                {
                    var faxSalary = salaryRepository.GetSalaryByEmployeeIdAndDate(CurrentEmployee.EmployeeId, selectedDateTime);
                    var faxDepartment = departmentRepository.GetDepartmentById(CurrentEmployee.DepartmentId);
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}