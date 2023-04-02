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
    public partial class Login : Form
    {
        SqlRepository sqlRepository;
        public Login()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var user = sqlRepository.LoginUser(textBoxName.Text.Trim());
            if (user != null)
            {
                if (user.VerifyPassword(textBoxPassword.Text))
                {
                    if (user.Role == "admin")
                    {
                        AdminForm admin = new AdminForm(user);
                        admin.Show();
                        this.Hide();
                        return;
                    }
                    else if (user.Role == "user") ;
                    {
                        UserForm userF = new UserForm(user);
                        userF.Show();
                        this.Hide();
                        return;
                    }
                }
            }
            MessageBox.Show("Username or password incorrect.");
        }
    }
}
