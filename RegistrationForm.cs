using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KinoProjekt
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) &&
                !string.IsNullOrEmpty(txtEmail.Text) &&
                !string.IsNullOrEmpty(txtPassword.Text))
            {
                // Переход на форму выбора фильма
                MovieSelectionForm movieForm = new MovieSelectionForm();
                movieForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
