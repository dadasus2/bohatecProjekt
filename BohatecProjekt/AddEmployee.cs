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
    public partial class AddEmployee : Form
    {
        SqlRepository sqlRepository;
        public AddEmployee()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxPosition.Text != "" && textBoxFirst.Text != "" && textBoxLast.Text != "" && textBoxEmail.Text != "" && textBoxPhone.Text != "")
            {
                sqlRepository.AddEmployee(textBoxPosition.Text, textBoxFirst.Text, textBoxLast.Text, dateTimePicker.Value.ToString("dd.MM.yyyy"), textBoxEmail.Text, textBoxPhone.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Vyplňtě všechny okna");
            }
        }
    }
}
