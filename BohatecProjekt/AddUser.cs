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
    public partial class AddUser : Form
    {
        SqlRepository sqlRepository;
        public AddUser()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxPass.Text != "" && textBox1.Text == "admin" || textBox1.Text == "user")
            {
                sqlRepository.AddUser(textBoxUsername.Text, textBoxPass.Text, textBox1.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Vyplňtě všechny okna");
            }
        }
    }
}
