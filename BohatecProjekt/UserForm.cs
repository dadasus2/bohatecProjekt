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
    public partial class UserForm : Form
    {
        private List<Employee> employees;
        SqlRepository sqlRepository;
        public UserForm(User user)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();

            LoadEmployee();
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
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

        private void textEmployeeSearch_TextChanged(object sender, EventArgs e)
        {
            LoadEmployee();
        }
    }
}
