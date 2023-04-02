using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BohatecProjekt
{
    public partial class AdminForm : Form
    {
        SqlRepository sqlRepository;
        private User user;
        private List<User> users;
        private List<Employee> employees;
        public AdminForm(User user)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();

            LoadUser();
            LoadEmployee();
        }
        public void LoadUser()
        {
            users = sqlRepository.GetUsers(textUserSearch.Text);
            listViewUser.Items.Clear();

            foreach (var user in users)
            {
                listViewUser.Items.Add(user.ToListViewItem());
            }
        }
        public void LoadEmployee()
        {
            employees = sqlRepository.GetEmployees(textEmployeeSearch.Text);
            listViewEmployee.Items.Clear();

            foreach (var employee in employees)
            {
                listViewEmployee.Items.Add(employee.ToListViewItem());
            }
        }
        private void buttonUserDelete_Click(object sender, EventArgs e)
        {
            var row = listViewUser.SelectedItems[0];
            var id = row.SubItems[0].Text;
            sqlRepository.DeleteUser(Convert.ToInt32(id));
            listViewUser.SelectedItems[0].Remove();

            LoadUser();
        }
        private void buttonUserAdd_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            var result = addUser.ShowDialog();
            if (result == DialogResult.OK)
                LoadUser();
        }

        private void textUserSearch_TextChanged(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void textEmployeeSearch_TextChanged(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        private void buttonEmpDelete_Click(object sender, EventArgs e)
        {
            var row = listViewEmployee.SelectedItems[0];
            var id = row.SubItems[0].Text;
            sqlRepository.DeleteEmployee(Convert.ToInt32(id));
            listViewEmployee.SelectedItems[0].Remove();

            LoadEmployee();
        }

        private void buttonEmpAdd_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            var result = addEmployee.ShowDialog();
            if (result == DialogResult.OK)
                LoadEmployee();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
