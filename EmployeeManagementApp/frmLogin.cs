using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using EmployeeManagementApp;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        private readonly IEmployeeRepository employeeRepository;
        private Admin admin;

        public frmLogin()
        {
            employeeRepository = new EmployeeRepository();
            ReadFileJson();
            InitializeComponent();
        }

        private void ReadFileJson()
        {
            using StreamReader streamReader = new StreamReader("appsettings.json");
            string json = streamReader.ReadToEnd();
            admin = JsonConvert.DeserializeObject<Admin>(json);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All field are required! ");
            }
            else
            {
                if (admin.email.Equals(email) && admin.password.Equals(password))
                {
                    frmMenu menuForm = frmMenu.Instance;
                    menuForm.IsAdmin = true;
                    menuForm.Closed += (sender, e) => this.Close();
                    this.Hide();
                    menuForm.frmMenu_Load(sender, e);
                    menuForm.Show();
                }
                else
                {
                    var currentUser = employeeRepository.CheckLogin(email, password);
                    if (currentUser is null)
                    {
                        MessageBox.Show("Email or password is incorrect!");
                    }
                    else
                    {
                        frmMenu menuForm = frmMenu.Instance;
                        menuForm.IsAdmin = false;
                        menuForm.CurrentMember = currentUser;
                        menuForm.Closed += (sender, e) => this.Close();
                        this.Hide();
                        menuForm.frmMenu_Load(sender, e);
                        menuForm.Show();
                    }
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

    }
}
